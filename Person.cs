﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Person
    {
        private string firstName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName { get; set; }

        public int YearOfBirth { get; set; }

        public Person(string firstName = "", string lastName = "", int yearOfBirth = 1900)
        {
            Console.WriteLine("Called Person constructor with parameters.");

            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }

        public virtual void WhoAmI()
        {
            Console.WriteLine($"My name is {LastName}. {FirstName} {LastName}");
        }

        public override string ToString()
        {
            return $"{{ firstName: \"{FirstName}\", lastName: \"{LastName}\", yearOfBirth: {YearOfBirth} }}"; // { firstName: "Jan", lastName: "Kowalski" }
        }

        public bool IsAdult() => DateTime.Today.Year - YearOfBirth >= 18;
        //{
        //    return DateTime.Today.Year - YearOfBirth >= 18;
        //}
    }
}
