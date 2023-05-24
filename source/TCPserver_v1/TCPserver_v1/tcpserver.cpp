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

        // 클라이언트 메세지 수신
        int bytesReceived = recv(clientSocket, buffer, BUFFER_SIZE, 0);
        if (bytesReceived == SOCKET_ERROR) {
            std::cerr << "Error in recv(). Quitting thread..." << std::endl;
            break;
        }

        if (bytesReceived == 0) {
            // 클라이언트 연결해제 
            std::cout << "Client disconnected. Quitting thread..." << std::endl;
            break;
        }

        // 클라이언트로부터 온 메세지 처리
        std::string message = clientNames[clientIndex] + ": " + buffer;
        std::cout << message << std::endl;

        // 다른 클라이언트에 메세지를 전파합니다.(브로드캐스트 방식)
        BroadcastMessage(message, clientIndex);
    }

    // 클라이언트의 소켓을 닫고 클라이언트 배열에서 제거
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

// 서버에서 클라이언트로 발신
void ServerInputThread() {
    std::string input;
    while (true) {
        std::getline(std::cin, input);
        if (input == "quit") {
            break;
        }

        // 서버 메세지 처리
        std::string message = "Server: " + input;
        std::cout << message << std::endl;

        // 모든 클라이언트에 메세지 수신 
        BroadcastMessage(message, -1);
    }

    // 작업 정리
    closesocket(listeningSocket);
    WSACleanup();
    std::cout << "Server shutting down..." << std::endl;
    exit(0);
}



int main() {
    // 윈속 초기화
    WSADATA wsData;
    if (WSAStartup(MAKEWORD(2, 2), &wsData) != 0) {
        std::cerr << "Failed to initialize Winsock." << std::endl;
        return 1;
    }

    // 수신 소켓 만들기 
    listeningSocket = socket(AF_INET, SOCK_STREAM, 0);
    if (listeningSocket == INVALID_SOCKET) {
        std::cerr << "Failed to create listening socket." << std::endl;
        WSACleanup();
        return 1;
    }

    // 소켓에 IP주소와 포트번호를 bind()
    sockaddr_in hint;
    hint.sin_family = AF_INET;
    hint.sin_port = htons(9000); // 포트번호 설정 
    hint.sin_addr.s_addr = htonl(INADDR_ANY);
 
    if (bind(listeningSocket, (sockaddr*)&hint, sizeof(hint)) == SOCKET_ERROR) {
        std::cerr << "Failed to bind the listening socket." << std::endl;
        closesocket(listeningSocket);
        WSACleanup();
        return 1;
    }

    // 클라이언트 연결 수신 시작 
    if (listen(listeningSocket, SOMAXCONN) == SOCKET_ERROR) {
        std::cerr << "Failed to listen on the socket." << std::endl;
        closesocket(listeningSocket);
        WSACleanup();
        return 1;
    }

    std::cout << "Server started. Waiting for connections..." << std::endl;

    // 서버 입력에 대한 스레드를 생성 (다중 스레드를 이용하기위함)
    std::thread inputThread(ServerInputThread);
    inputThread.detach();

    // 클라이언트 연결을 수락하고 클라이언트 스레드 생성
    while (true) {
        // 클라이언트가 연결될 때까지 대기
        sockaddr_in clientAddr;
        int clientAddrSize = sizeof(clientAddr);
        SOCKET clientSocket = accept(listeningSocket, (sockaddr*)&clientAddr, &clientAddrSize);
        if (clientSocket == INVALID_SOCKET) {
            std::cerr << "Failed to accept client connection." << std::endl;
            continue;
        }

        // 최대 클라이언트수는 100개로 100개가 되거나 이상이 되면 소켓을 닫는다. 
        if (numClients >= MAX_CLIENTS) {
            std::cerr << "Maximum number of clients reached. Rejecting new connection." << std::endl;
            closesocket(clientSocket);
            continue;
        }

        // 클라이언트의 닉네임을 할당한다.
        AssignNickname(clientSocket, numClients);

    

        // 클라이언트의 작업을 처리할 스레드를 생성한다.
        std::thread clientThread(ClientThread, numClients - 1);
        clientThread.detach();

        std::cout << "Client connected. Client index: " << numClients - 1 << std::endl;
    }

    // 소켓 닫음
    closesocket(listeningSocket);
    // Cleanup();
    WSACleanup();
    return 0;
}


