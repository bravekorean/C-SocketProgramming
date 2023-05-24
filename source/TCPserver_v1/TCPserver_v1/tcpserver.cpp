#include <iostream>
#include <WinSock2.h>
#include <ws2tcpip.h>
#include <string>
#include <thread>
#pragma comment(lib, "ws2_32.lib")

#define MAX_CLIENTS 100
#define BUFFER_SIZE 1024

SOCKET clients[MAX_CLIENTS];
std::string clientNames[MAX_CLIENTS];
int numClients = 0;
SOCKET listeningSocket; // listeningSocket�� ���� ������ ����

void BroadcastMessage(const std::string& message, int senderIndex) {
    for (int i = 0; i < numClients; i++) {
        if (i != senderIndex) {
            send(clients[i], message.c_str(), message.length() + 1, 0);
        }
    }
}

void ClientThread(int clientIndex) {
    SOCKET clientSocket = clients[clientIndex];
    char buffer[BUFFER_SIZE];

    while (true) {
        memset(buffer, 0, BUFFER_SIZE);

        // Ŭ���̾�Ʈ �޼��� ����
        int bytesReceived = recv(clientSocket, buffer, BUFFER_SIZE, 0);
        if (bytesReceived == SOCKET_ERROR) {
            std::cerr << "Error in recv(). Quitting thread..." << std::endl;
            break;
        }

        if (bytesReceived == 0) {
            // Ŭ���̾�Ʈ �������� 
            std::cout << "Client disconnected. Quitting thread..." << std::endl;
            break;
        }

        // Ŭ���̾�Ʈ�κ��� �� �޼��� ó��
        std::string message = clientNames[clientIndex] + ": " + buffer;
        std::cout << message << std::endl;

        // �ٸ� Ŭ���̾�Ʈ�� �޼����� �����մϴ�.(��ε�ĳ��Ʈ ���)
        BroadcastMessage(message, clientIndex);
    }

    // Ŭ���̾�Ʈ�� ������ �ݰ� Ŭ���̾�Ʈ �迭���� ����
    closesocket(clientSocket);
    clients[clientIndex] = INVALID_SOCKET;
}

void AssignNickname(SOCKET clientSocket, int clientIndex) {
    std::string nicknameMsg = "Please enter your nickname: ";
    send(clientSocket, nicknameMsg.c_str(), nicknameMsg.length() + 1, 0);

    char nicknameBuffer[BUFFER_SIZE];
    memset(nicknameBuffer, 0, BUFFER_SIZE);
    int nicknameReceived = recv(clientSocket, nicknameBuffer, BUFFER_SIZE, 0);
    if (nicknameReceived <= 0) {
        std::cerr << "Failed to receive client's nickname. Closing connection." << std::endl;
        closesocket(clientSocket);
        return;
    }
    std::string nickname = nicknameBuffer;

    // Assign the nickname to the client
    clientNames[clientIndex] = nickname;

    std::string assignedMsg = "Your nickname has been set as: " + nickname + "\n";
    send(clientSocket, assignedMsg.c_str(), assignedMsg.length() + 1, 0);
}

// �������� Ŭ���̾�Ʈ�� �߽�
void ServerInputThread() {
    std::string input;
    while (true) {
        std::getline(std::cin, input);
        if (input == "quit") {
            break;
        }

        // ���� �޼��� ó��
        std::string message = "Server: " + input;
        std::cout << message << std::endl;

        // ��� Ŭ���̾�Ʈ�� �޼��� ���� 
        BroadcastMessage(message, -1);
    }

    // �۾� ����
    closesocket(listeningSocket);
    WSACleanup();
    std::cout << "Server shutting down..." << std::endl;
    exit(0);
}



int main() {
    // ���� �ʱ�ȭ
    WSADATA wsData;
    if (WSAStartup(MAKEWORD(2, 2), &wsData) != 0) {
        std::cerr << "Failed to initialize Winsock." << std::endl;
        return 1;
    }

    // ���� ���� ����� 
    listeningSocket = socket(AF_INET, SOCK_STREAM, 0);
    if (listeningSocket == INVALID_SOCKET) {
        std::cerr << "Failed to create listening socket." << std::endl;
        WSACleanup();
        return 1;
    }

    // ���Ͽ� IP�ּҿ� ��Ʈ��ȣ�� bind()
    sockaddr_in hint;
    hint.sin_family = AF_INET;
    hint.sin_port = htons(9000); // ��Ʈ��ȣ ���� 
    hint.sin_addr.s_addr = htonl(INADDR_ANY);
 
    if (bind(listeningSocket, (sockaddr*)&hint, sizeof(hint)) == SOCKET_ERROR) {
        std::cerr << "Failed to bind the listening socket." << std::endl;
        closesocket(listeningSocket);
        WSACleanup();
        return 1;
    }

    // Ŭ���̾�Ʈ ���� ���� ���� 
    if (listen(listeningSocket, SOMAXCONN) == SOCKET_ERROR) {
        std::cerr << "Failed to listen on the socket." << std::endl;
        closesocket(listeningSocket);
        WSACleanup();
        return 1;
    }

    std::cout << "Server started. Waiting for connections..." << std::endl;

    // ���� �Է¿� ���� �����带 ���� (���� �����带 �̿��ϱ�����)
    std::thread inputThread(ServerInputThread);
    inputThread.detach();

    // Ŭ���̾�Ʈ ������ �����ϰ� Ŭ���̾�Ʈ ������ ����
    while (true) {
        // Ŭ���̾�Ʈ�� ����� ������ ���
        sockaddr_in clientAddr;
        int clientAddrSize = sizeof(clientAddr);
        SOCKET clientSocket = accept(listeningSocket, (sockaddr*)&clientAddr, &clientAddrSize);
        if (clientSocket == INVALID_SOCKET) {
            std::cerr << "Failed to accept client connection." << std::endl;
            continue;
        }

        // �ִ� Ŭ���̾�Ʈ���� 100���� 100���� �ǰų� �̻��� �Ǹ� ������ �ݴ´�. 
        if (numClients >= MAX_CLIENTS) {
            std::cerr << "Maximum number of clients reached. Rejecting new connection." << std::endl;
            closesocket(clientSocket);
            continue;
        }

        // Ŭ���̾�Ʈ�� �г����� �Ҵ��Ѵ�.
        AssignNickname(clientSocket, numClients);

    

        // Ŭ���̾�Ʈ�� �۾��� ó���� �����带 �����Ѵ�.
        std::thread clientThread(ClientThread, numClients - 1);
        clientThread.detach();

        std::cout << "Client connected. Client index: " << numClients - 1 << std::endl;
    }

    // ���� ����
    closesocket(listeningSocket);
    // Cleanup();
    WSACleanup();
    return 0;
}


