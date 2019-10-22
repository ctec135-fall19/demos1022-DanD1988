using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Parent
    {
        // 
        public void ParentMethod()
        {
            Console.WriteLine("ParentMethod");
        }

        // Demo overriding a base class method by a child
        // Implements the same method in classes of the heirarchy

        public virtual void someMethod()
        {
            Console.WriteLine("Parent's SomeMethod");
        }

        // Demo a child calling the parent's method

        public virtual void Method2()
        {
            Console.WriteLine("Parent.Method2");
        }
    }
}
