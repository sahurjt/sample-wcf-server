using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Simple_WCF_Client_Var;

namespace SImple_Wcf_Example
{

    public class Service1 : ICalculationService
    {
       /// private static int count = 0; // this will not work in storing global var, insted use globalvariable class
        public int Diff(int x, int y)
        {
            return x > y ? x - y : y - x;
        }

        public string FullName(Person person)
        {
            return person.First +" "+ person.Last;
        }

        public int Mult(int x, int y)
        {
            return x * y;
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Count() {
            var cur = GlobalVariable.IntValue;
            // update count
            GlobalVariable.SetIntValue(cur + 1);
            return cur;
        }
    }
}
