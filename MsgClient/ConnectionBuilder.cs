namespace MsgClient;
public static partial class Builder{

  static ConnectionInformation connection = new ConnectionInformation();

  public static void Adress(string address)=> connection.Address = address;
  public static void Port(int port)=> connection.Port = port;

  public static int Build(){
    //Building the Connection. 
    return -1;
  }




  
}