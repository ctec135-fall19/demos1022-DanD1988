using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Child : Parent
    {
        public override void someMethod()
        {
            Console.WriteLine("Child's SomeMethod");
        }

        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("Child.Method2");
        }
    }
}
