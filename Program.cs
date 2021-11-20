using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
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
        }

        static void PrintHello(Person person)
        {
            person.WhoAmI();
        }
    }
}
