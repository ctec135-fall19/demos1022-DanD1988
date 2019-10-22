using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3
{
    class MyClass
    {
        private string str;
        private string str2;
        // strings are already a class aka object
        // can create another class

        // consructor 
         public MyClass(string inStr)
        {
            //Composition
            // MyClass own str. str does'nt exist outside of MyClass
            str = "some string";

            // another class part of MyClass

            // Aggragation 
            // str2 refers to object outside of MyClass
            str2 = inStr;

        }

        public void printState()
        {
            Console.WriteLine("str: {0}", str);
            Console.WriteLine("str2: {0}", str2);
        }

        

        



    }
}
