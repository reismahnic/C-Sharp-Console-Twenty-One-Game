using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        //Making a custom exception:
        //create two constructors, one overloading the other, and have them implement the exact same implementation that exists for Exception
        public FraudException() : base() { }
        public FraudException(string message) : base(message) { }
        
    }
}
