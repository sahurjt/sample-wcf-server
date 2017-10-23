using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel; // this needs to import for WCF 


namespace SImple_Wcf_Example
{
    // this is a interface which represent the service that can be used by client 
    [ServiceContract] // this attribute represent a WCF service
    public interface ICalculationService
    {
        // contains list of service operations

        [OperationContract] // this attribute represent a WCF method 
        int Sum(int x, int y);

        [OperationContract]
        int Diff(int x, int y);

        [OperationContract]
        int Mult(int x, int y);

        [OperationContract]
        string FullName(Person person); // return fullname of this user

        [OperationContract]
        int Count();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Person
    {

        [DataMember]
        public string First
        {
            get;set;
        }

        [DataMember]
        public string Last {
            get;set;
        }

    }
}
