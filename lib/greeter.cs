using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class greeter
    {
        public string msg = "World";

        //Parameterized Constructor
        public Class1(string name)
        {
            msg = name;
        }
        public string greetMsg()
        {
            return "Hello " + msg;
        }
    }
}
