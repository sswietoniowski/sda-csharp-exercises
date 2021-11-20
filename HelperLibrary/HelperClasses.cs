using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class A
    {
        protected internal int field1;
        private protected int field2;
    }

    public class E : A
    {
        void DoSomethingElse()
        {
            Console.WriteLine(this.field1);
            Console.WriteLine(this.field2);
        }
    }

    internal class B
    {

    }

    class C
    {
        private A a;
        private B b;

        public void DoSomething()
        {
            D d = new D();
            A a = new A();
            Console.WriteLine(a.field1);
        }

        private class D
        {

        }
    }
}
