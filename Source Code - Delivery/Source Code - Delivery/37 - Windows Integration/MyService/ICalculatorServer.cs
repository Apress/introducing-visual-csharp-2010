using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace MyService {
    
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
}
