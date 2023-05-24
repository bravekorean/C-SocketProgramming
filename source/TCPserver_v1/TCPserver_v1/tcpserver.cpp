#include <iostream>
#include <WinSock2.h>
#include <ws2tcpip.h>
#include <string>
#include <vector>
#include <thread>
#pragma comment(lib, "ws2_32.lib")

#define MAX_CLIENTS 100
#define BUFFER_SIZE 1024

struct ClientInfo {
    SOCKET socket;
    std::string name;
};

std::vector<ClientInfo> clients;
SOCKET listeningSocket;

void BroadcastMessage(const std::string& message, int senderIndex) {
    for (int i = 0; i < clients.size(); i++) {
        if (i != senderIndex) {
            send(clients[i].socket, message.c_str(), message.length() + 1, 0);
        }
    }
}

void ClientThread(int clientIndex) {
    ClientInfo& client = clients[clientIndex];
    char buffer[BUFFER_SIZE];

    while (true) {
        memset(buffer, 0, BUFFER_SIZE);

        int bytesReceived = recv(client.socket, buffer, BUFFER_SIZE, 0);
        if (bytesReceived == SOCKET_ERROR) {
            std::cerr << "Error in recv(). Quitting thread..." << std::endl;
            break;
        }

        if (bytesReceived == 0) {
            std::cout << "Client disconnected. Quitting thread..." << std::endl;
            break;
        }

        std::string message = client.name + ": " + buffer;
        std::cout << message << std::endl;

        BroadcastMessage(message, clientIndex);
    }

    closesocket(client.socket);
    clients.erase(clients.begin() + clientIndex);
}

void ServerInputThread() {
    std::string input;
    while (true) {
        std::getline(std::cin, input);
        if (input == "quit") {
            break;
        }

        std::string message = "CS: " + input;
        std::cout << message << std::endl;

        BroadcastMessage(message, -1);
    }

    closesocket(listeningSocket);
    WSACleanup();
    std::cout << "Server shutting down..." << std::endl;
    exit(0);
}

int main() {
    WSADATA wsData;
    if (WSAStartup(MAKEWORD(2, 2), &wsData) != 0) {
        std::cerr << "Failed to initialize Winsock." << std::endl;
        return 1;
    }

    listeningSocket = socket(AF_INET, SOCK_STREAM, 0);
    if (listeningSocket == INVALID_SOCKET) {
        std::cerr << "Failed to create listening socket." << std::endl;
        WSACleanup();
        return 1;
    }

    sockaddr_in hint;
    hint.sin_family = AF_INET;
    hint.sin_port = htons(9000);
    hint.sin_addr.s_addr = htonl(INADDR_ANY);

    if (bind(listeningSocket, (sockaddr*)&hint, sizeof(hint)) == SOCKET_ERROR) {
        std::cerr << "Failed to bind the listening socket." << std::endl;
        closesocket(listeningSocket);
        WSACleanup();
        return 1;
    }

    if (listen(listeningSocket, SOMAXCONN) == SOCKET_ERROR) {
        std::cerr << "Failed to listen on the socket." << std::endl;
        closesocket(listeningSocket);
        WSACleanup();
        return 1;
    }

    std::cout << "Server started. Waiting for connections..." << std::endl;

    std::thread inputThread(ServerInputThread);
    inputThread.detach();

    while (true) {
        sockaddr_in clientAddr;
        int clientAddrSize = sizeof(clientAddr);
        SOCKET clientSocket = accept(listeningSocket, (sockaddr*)&clientAddr, &clientAddrSize);
        if (clientSocket == INVALID_SOCKET) {
            std::cerr << "Failed to accept client connection." << std::endl;
            continue;
        }

        if (clients.size() >= MAX_CLIENTS) {
            std::cerr << "Maximum number of clients reached. Rejecting new connection." << std::endl;
            closesocket(clientSocket);
            continue;
        }

        ClientInfo newClient;
        newClient.socket = clientSocket;

        std::string nickname = "고객 " + std::to_string(clients.size());
        newClient.name = nickname;

        std::string assignedMsg = "폭언 및 욕설은 제제 될 수있습니다.";
        send(clientSocket, assignedMsg.c_str(), assignedMsg.length() + 1, 0);

        clients.push_back(newClient);

        std::thread clientThread(ClientThread, clients.size() - 1);
        clientThread.detach();

        std::cout << "고객이 접속했습니다. 고객 번호는 :" << clients.size() - 1 << std::endl;
    }

    closesocket(listeningSocket);
    WSACleanup();
    return 0;
}


