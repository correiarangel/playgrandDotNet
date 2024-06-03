using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propiedMetodCosntrutores.Models
{
    public class Person
    {
        public Person() { }
        public Person(string name, string lastName, int age)
        {
            _name = name;
            _age = age;
            _lastName = lastName;
        }
        private string? _name;
        private string? _lastName;
        private int _age;

        public string Name
        {

            get => _name?.ToUpper() ?? "";

            set
            {
                if (value == "") throw new ArgumentException("ERROR: Name Cannor be Empty");
                _name = value;
            }

        }

        public int Age
        {

            get => _age;

            set
            {
                if (value <= 0) throw new ArgumentException("ERROR: Age Cannor be Ziro or Smalle");
                _age = value;
            }

        }


        public string? LastName { get; set; }
        public string ComplitName => $"{Name} {LastName}".ToUpper();

        public void Show()
        {
            Console.WriteLine($"Name {Name} {LastName}, Idade: {Age} ");
        }

    }
}