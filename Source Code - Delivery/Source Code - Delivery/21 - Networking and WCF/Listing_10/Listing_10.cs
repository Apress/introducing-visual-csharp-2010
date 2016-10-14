using System;
using System.ServiceModel;
using System.ServiceModel.Description;

[ServiceContract]
public interface ICalculatorServer {

    [OperationContract]
    int PerformAddition(int x, int y);

    [OperationContract]
    int PerformMultiplcation(int x, int y);

    [OperationContract]
    int PerformSubtraction(int x, int y);

    [OperationContract]
    float PerformDivision(int x, int y);
}

class CalculatorImpl : ICalculatorServer {

    public int PerformAddition(int x, int y) {
        int result = x + y;
        Console.WriteLine("Addition Request: {0} + {1} = {2}",
            x, y, result);
        return result;
    }

    public int PerformMultiplcation(int x, int y) {
        int result = x * y;
        Console.WriteLine("Multiplcation Request: {0} * {1} = {2}",
            x, y, result);
        return result;
    }

    public int PerformSubtraction(int x, int y) {
        int result = x - y;
        Console.WriteLine("Subtraction Request: {0} - {1} = {2}",
            x, y, result);
        return result;
    }

    public float PerformDivision(int x, int y) {
        float result = ((float)x) / ((float)y);
        Console.WriteLine("Division Request: {0} / {1} = {2}",
            x, y, result);
        return result;
    }
}

class PublishServer {

    static void Main(string[] args) {

        // define the URI that will be used to publish the service
        Uri serviceAddress = new Uri("http://localhost:13000/WCF");

        // create the ServiceHost object
        ServiceHost myServiceHost = new ServiceHost(typeof(CalculatorImpl), serviceAddress);

        // add the end point with the HTTP binding
        myServiceHost.AddServiceEndpoint(typeof(ICalculatorServer), new WSHttpBinding(), "CalculatorServer");

        // add support for getting the meta-data via HTTP
        ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
        smb.HttpGetEnabled = true;
        myServiceHost.Description.Behaviors.Add(smb);

        // start receiving requests from clients
        myServiceHost.Open();
        Console.WriteLine("Calculator Server ready");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

