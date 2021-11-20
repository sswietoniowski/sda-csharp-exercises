﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Employee : Person
    {
        public decimal Salary { get; set; }

        public Employee() : this("", "", 1900, 0)
        {
            Console.WriteLine("Called Employee constructor without parameters.");
        }

        public Employee(string firstName, string lastName, int yearOfBirth, decimal salary) :
            base(firstName, lastName, yearOfBirth)
        {
            Console.WriteLine("Called Employee constructor with parameters.");

            Salary = salary;
        }

        public override void WhoAmI()
        {
            base.WhoAmI();
            Console.WriteLine($"Salary = {Salary}");
        }

        public override string ToString()
        {
            return $"{{ firstName: \"{FirstName}\", lastName: \"{LastName}\", yearOfBirth: {YearOfBirth}, salary: {GetSalary()} }}"; // { firstName: "Jan", lastName: "Kowalski" }
        }

        public virtual decimal GetSalary()
        {
            return Salary;
        }
    }
}
