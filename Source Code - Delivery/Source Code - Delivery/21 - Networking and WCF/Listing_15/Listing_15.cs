using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

class UdpReceiver {
    
    public void Start() {
        Task.Factory.StartNew(() => ReceiveAndPrintMessages());
    }

    private void ReceiveAndPrintMessages() {

        // create the UdpClient object
        UdpClient myUdpClient = new UdpClient(15000);

        // create the end point
        IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);        

        while (true) {
            Console.WriteLine("Receiver: Waiting for a message");
            // wait to receive data
            byte[] data = myUdpClient.Receive(ref endPoint);
            // convert the byte data to a string
            string message = Encoding.Default.GetString(data);
            // print out the details of the received message
            Console.WriteLine("Receiver: Message from {0} on port {1}", endPoint.Address, endPoint.Port);
            Console.WriteLine("Receiver: Message is: {0}", message);
        }
    }
}

class UdpSender {

    public void SendMessages() {

        // create the UdpClient object
        UdpClient myUdpClient = new UdpClient();

        // specify where we want to send our messages
        myUdpClient.Connect(IPAddress.Loopback, 15000);

        // enter a loop to send messages
        for (int i = 0; i < 5; i++) {
            // create the string we will send
            string messageString = string.Format("{0} x {0} = {1}", i, i * i);
            // write out a message to the console
            Console.WriteLine("Sender: sending message: {0}", messageString);
            // convert the string to bytes
            byte[] dataArray = Encoding.Default.GetBytes(messageString);
            // send the bytes
            myUdpClient.Send(dataArray, dataArray.Length);
        }

        // close the UdpClient object
        myUdpClient.Close();
    }

}

class UdpTest {

    static void Main(string[] args) {

        // create the UdpReceiver object and start listening
        new UdpReceiver().Start();

        // create the UdpSender and send the messages
        new UdpSender().SendMessages();
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
