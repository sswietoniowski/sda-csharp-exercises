using System;
using System.Collections.Generic;
using HelperLibrary;

namespace sda_csharp_exercises
{
    class F : A
    {
        void DoSomethingElse()
        {
            Console.WriteLine(this.field1);
            //Console.WriteLine(this.field2);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Jan", "Kowalski", 1981, 5000);
            PrintHello(employee);
            //employee.LastName = "Nowak";
            //PrintHello(employee);
            Employee employee2 = new Employee
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                YearOfBirth = 1981,
                Salary = 5000
            };
            //employee2.FirstName = "Adam";
            A a = new A();
            //B b = new B();
            // protected internal
            // private protected
        }

        private static void PrintHello(Person person)
        {
            person.WhoAmI();
        }
    }
}
