using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple_WCF_Client_Var
{
    //a class to store global integer values 
    // static class helps to maintain only one instance for this application

    public static class GlobalVariable
    {
        public static int IntValue { get; private set; }
        static GlobalVariable()
        {
            IntValue = 0;
        }

        public static void SetIntValue(int value)
        {
            IntValue = value;
        }
    }
}
