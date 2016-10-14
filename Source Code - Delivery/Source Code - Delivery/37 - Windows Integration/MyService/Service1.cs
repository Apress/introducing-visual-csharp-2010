using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceProcess;

namespace MyService {
    public partial class MyCalculatorService : ServiceBase {

        // define the service host field
        ServiceHost myServiceHost;

        public MyCalculatorService() {
            InitializeComponent();

            // define the WCF service
            // define the URI that will be used to publish the service
            Uri serviceAddress = new Uri("http://localhost:13000/WCF");

            // create the ServiceHost object
            myServiceHost = new ServiceHost(typeof(CalculatorImpl), serviceAddress);

            // add the end point with the HTTP binding
            myServiceHost.AddServiceEndpoint(typeof(ICalculatorServer),
                new WSHttpBinding(), "CalculatorServer");

            // add support for getting the meta-data via HTTP
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            myServiceHost.Description.Behaviors.Add(smb);
        }

        protected override void OnStart(string[] args) {
            // start handling requests 
            myServiceHost.Open();
        }

        protected override void OnStop() {
            // stop handling requests
            myServiceHost.Close();
        }
    }
}
