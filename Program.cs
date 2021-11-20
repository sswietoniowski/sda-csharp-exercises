using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Joanna", "Kowalska", 1982);
            //person.WhoAmI();
            //Person person2 = new Employee("Adam", "Nowak", 2000, 6000);
            //person2.WhoAmI();
            //Employee employee = new Employee("Jan", "Kowalski", 1981, 5000);
            //employee.WhoAmI();
            List<Person> people = new List<Person>();
            people.Add(new Person("Jan", "Kowalski", 1981));
            people.Add(new Employee("Adam", "Nowak", 2000, 5000));

            foreach (var p in people)
            {
                Console.WriteLine(p);
            }
        }
    }
}
