#include <iostream>
#include <string>
#include <thread>
#include <vector>
#include <mutex>
#include <WinSock2.h>

std::vector<SOCKET> clients;
std::mutex clientsMutex;

void HandleClient(SOCKET clientSocket) {
    while (true) {
        char buffer[1024];
        int bytesRead = recv(clientSocket, buffer, sizeof(buffer), 0);
        if (bytesRead <= 0) {
            break;
        }

        // 수신한 메시지를 다른 클라이언트에게 전파
        std::lock_guard<std::mutex> lock(clientsMutex);
        for (const auto& client : clients) {
            if (client != clientSocket) {
                send(client, buffer, bytesRead, 0);
            }
        }
    }

    // 클라이언트 연결 종료
    std::lock_guard<std::mutex> lock(clientsMutex);
    auto it = std::find(clients.begin(), clients.end(), clientSocket);
    if (it != clients.end()) {
        clients.erase(it);
    }
    closesocket(clientSocket);
}

int main() {
    WSADATA wsaData;
    if (WSAStartup(MAKEWORD(2, 2), &wsaData) != 0) {
        std::cerr << "Failed to initialize winsock" << std::endl;
        return 1;
    }

    SOCKET serverSocket = socket(AF_INET, SOCK_STREAM, 0);
    if (serverSocket == INVALID_SOCKET) {
        std::cerr << "Failed to create socket" << std::endl;
        return 1;
    }

    sockaddr_in serverAddress;
    serverAddress.sin_family = AF_INET;
    serverAddress.sin_addr.s_addr = INADDR_ANY;
    serverAddress.sin_port = htons(5000);

    if (bind(serverSocket, (sockaddr*)&serverAddress, sizeof(serverAddress)) == SOCKET_ERROR) {
        std::cerr << "Failed to bind socket" << std::endl;
        closesocket(serverSocket);
        WSACleanup();
        return 1;
    }

    if (listen(serverSocket, SOMAXCONN) == SOCKET_ERROR) {
        std::cerr << "Failed to listen on socket" << std::endl;
        closesocket(serverSocket);
        WSACleanup();
        return 1;
    }

    std::cout << "Chat server started on port 5000" << std::endl;

    while (true) {
        SOCKET clientSocket = accept(serverSocket, nullptr, nullptr);
        if (clientSocket == INVALID_SOCKET) {
            std::cerr << "Failed to accept client connection" << std::endl;
            continue;
        }

        std::lock_guard<std::mutex> lock(clientsMutex);
        clients.push_back(clientSocket);

        std::thread clientThread(HandleClient, clientSocket);
        clientThread.detach();
    }

    closesocket(serverSocket);
    WSACleanup();

    return 0;
}

