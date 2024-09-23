using System.Net.Sockets;

namespace MsgClient;
internal class ClientRuntime{
  public ClientRuntime(ConnectionInformation information){
    tcpClient = new TcpClient(information.Address, information.Port);
    IsRunning = tcpClient.Connected;
  }

  internal TcpClient tcpClient{get;private set;}
  internal NetworkStream Stream => tcpClient.GetStream();
  public bool IsRunning {get;private set;}
  uint id; // <- used by the background runner.
}