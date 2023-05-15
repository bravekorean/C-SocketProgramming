#include <iostream>
#include <WinSock2.h>
#include <ws2tcpip.h>
#include <string>
#include <thread>
#pragma comment(lib, "ws2_32.lib")

#define MAX_CLIENTS 10
#define BUFFER_SIZE 1024

SOCKET clients[MAX_CLIENTS];
int numClients = 0;
SOCKET listeningSocket; // listeningSocket을 전역 변수로 선언

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

        // Receive client message
        int bytesReceived = recv(clientSocket, buffer, BUFFER_SIZE, 0);
        if (bytesReceived == SOCKET_ERROR) {
            std::cerr << "Error in recv(). Quitting thread..." << std::endl;
            break;
        }

        if (bytesReceived == 0) {
            // Client disconnected
            std::cout << "Client disconnected. Quitting thread..." << std::endl;
            break;
        }

        // Process the received message
        std::string message = "Client " + std::to_string(clientIndex) + ": " + buffer;
        std::cout << message << std::endl;

        // Broadcast the message to other clients
        BroadcastMessage(message, clientIndex);
    }

    // Close the client socket and remove it from the clients array
    closesocket(clientSocket);
    clients[clientIndex] = INVALID_SOCKET;
}

void ServerInputThread() {
    std::string input;
    while (true) {
        std::getline(std::cin, input);
        if (input == "quit") {
            break;
        }

        // Process server message
        std::string message = "Server: " + input;
        std::cout << message << std::endl;

        // Broadcast the message to all clients
        BroadcastMessage(message, -1);
    }

    // Cleanup
    closesocket(listeningSocket);
    WSACleanup();
    std::cout << "Server shutting down..." << std::endl;
    exit(0);
}

int main() {
    // Initialize Winsock
    WSADATA wsData;
    if (WSAStartup(MAKEWORD(2, 2), &wsData) != 0) {
        std::cerr << "Failed to initialize Winsock." << std::endl;
        return 1;
    }

    // Create a listening socket
    listeningSocket = socket(AF_INET, SOCK_STREAM, 0);
    if (listeningSocket == INVALID_SOCKET) {
        std::cerr << "Failed to create listening socket." << std::endl;
        WSACleanup();
        return 1;
    }

    // Bind the socket to an IP address and port
    sockaddr_in hint;
    hint.sin_family = AF_INET;
    hint.sin_port = htons(9000); // Choose your desired port number
    hint.sin_addr.s_addr = INADDR_ANY;
 
    if (bind(listeningSocket, (sockaddr*)&hint, sizeof(hint)) == SOCKET_ERROR) {
        std::cerr << "Failed to bind the listening socket." << std::endl;
        closesocket(listeningSocket);
        WSACleanup();
        return 1;
    }

    // Start listening for client connections
    if (listen(listeningSocket, SOMAXCONN) == SOCKET_ERROR) {
        std::cerr << "Failed to listen on the socket." << std::endl;
        closesocket(listeningSocket);
        WSACleanup();
        return 1;
    }

    std::cout << "Server started. Waiting for connections..." << std::endl;

    // Create a thread for server input
    std::thread inputThread(ServerInputThread);
    inputThread.detach();

    // Accept client connections and create client threads
    while (true) {
        // Wait for a client to connect
        sockaddr_in clientAddr;
        int clientAddrSize = sizeof(clientAddr);
        SOCKET clientSocket = accept(listeningSocket, (sockaddr*)&clientAddr, &clientAddrSize);
        if (clientSocket == INVALID_SOCKET) {
            std::cerr << "Failed to accept client connection." << std::endl;
            continue;
        }

        // Check if the maximum number of clients is reached
        if (numClients >= MAX_CLIENTS) {
            std::cerr << "Maximum number of clients reached. Rejecting new connection." << std::endl;
            closesocket(clientSocket);
            continue;
        }

        // Add the client socket to the array
        if (numClients < MAX_CLIENTS) {
            clients[numClients] = clientSocket;
            numClients++;

            // Create a thread to handle the client
            std::thread clientThread(ClientThread, numClients - 1);
            clientThread.detach();

            // Send a welcome message to the client
            std::string welcomeMsg = "Welcome to the chat server, Client " + std::to_string(numClients - 1) + "!\n";
            send(clientSocket, welcomeMsg.c_str(), welcomeMsg.length() + 1, 0);

            std::cout << "Client connected. Client index: " << numClients - 1 << std::endl;
        }
        else {
            // Maximum number of clients reached
            std::cerr << "Maximum number of clients reached. Rejecting new connection." << std::endl;
            closesocket(clientSocket);
        }
    }

    // Cleanup
    closesocket(listeningSocket);
    WSACleanup();
    return 0;
}


