using    System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PersonModel.Models
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public void Presenter(){
            Console.WriteLine("-------------------");
            Console.WriteLine($"Codigo: {id} \nNome: {name} \nIdade: {age} ");
            Console.WriteLine("-------------------");
        }
    }
}