#include <iostream>
#include <WinSock2.h>
#include <ws2tcpip.h>
#include <string>
#include <thread>
#pragma comment(lib, "ws2_32.lib")

#define BUFFER_SIZE 1024

void ReceiveMessages(SOCKET clientSocket) {
    char buffer[BUFFER_SIZE];
    int bytesReceived;

    while (true) {
        memset(buffer, 0, BUFFER_SIZE);
        bytesReceived = recv(clientSocket, buffer, BUFFER_SIZE - 1, 0);
        if (bytesReceived == SOCKET_ERROR) {
            std::cerr << "Failed to receive response from the server." << std::endl;
            break;
        }

        if (bytesReceived > 0) {
            std::cout << buffer << std::endl;
        }
    }
}

int main() {
    // Initialize Winsock
    WSADATA wsData;
    if (WSAStartup(MAKEWORD(2, 2), &wsData) != 0) {
        std::cerr << "Failed to initialize Winsock." << std::endl;
        return 1;
    }

    // Create a socket
    SOCKET clientSocket = socket(AF_INET, SOCK_STREAM, 0);
    if (clientSocket == INVALID_SOCKET) {
        std::cerr << "Failed to create socket." << std::endl;
        WSACleanup();
        return 1;
    }

    // Set up the server address
    sockaddr_in serverAddr;
    serverAddr.sin_family = AF_INET;
    serverAddr.sin_port = htons(9000);  // 서버 포트 번호
    inet_pton(AF_INET, "127.0.0.1", &(serverAddr.sin_addr));  // 서버 IP 주소

    // Connect to the server
    if (connect(clientSocket, (sockaddr*)&serverAddr, sizeof(serverAddr)) == SOCKET_ERROR) {
        std::cerr << "Failed to connect to the server." << std::endl;
        closesocket(clientSocket);
        WSACleanup();
        return 1;
    }

    // Receive server's entrance message
    char buffer[BUFFER_SIZE];
    memset(buffer, 0, BUFFER_SIZE);
    int bytesReceived = recv(clientSocket, buffer, BUFFER_SIZE - 1, 0);
    if (bytesReceived == SOCKET_ERROR) {
        std::cerr << "Failed to receive server's entrance message." << std::endl;
    }
    else {
        std::cout << "Server: " << buffer << std::endl;
    }

    // Receive and display the assigned nickname from the server
    memset(buffer, 0, BUFFER_SIZE);
    bytesReceived = recv(clientSocket, buffer, BUFFER_SIZE - 1, 0);
    if (bytesReceived == SOCKET_ERROR) {
        std::cerr << "Failed to receive nickname from the server." << std::endl;
    }
    else {
        std::cout << "Assigned Nickname: " << buffer << std::endl;
    }

    std::string message;

    // Create a thread for receiving messages
    std::thread receiveThread(ReceiveMessages, clientSocket);

    while (true) {
        // Get user input
        std::getline(std::cin, message);

        // Send message to the server
        int bytesSent = send(clientSocket, message.c_str(), message.length() + 1, 0);
        if (bytesSent == SOCKET_ERROR) {
            std::cerr << "Failed to send message to the server." << std::endl;
            break;
        }

        // Check if the message is "quit" to exit the loop
        if (message == "quit") {
            break;
        }
    }

    // Close the socket
    closesocket(clientSocket);
    // Wait for the receive thread to finish
    receiveThread.join();

    // Cleanup
    WSACleanup();
    return 0;
}
