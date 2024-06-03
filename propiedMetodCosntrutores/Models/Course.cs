using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propiedMetodCosntrutores.Models
{
    public class Course
    {
        public string? NameCourse { get; set; }
        public List<Person>? AllStudent { get; set; }
        public void AddStudent(Person person)
        {
            if (AllStudent == null) AllStudent = [];
            AllStudent.Add(person);
        }
        public void RemoveStudent(Person person)
        {
            if (AllStudent == null || AllStudent?.Count == 0) return;
            AllStudent!.Remove(person);
        }
        public int CountStudent()
        {
            return AllStudent?.Count ?? 0;
        }
        public void ShowStudent()
        {
            if (AllStudent == null) return;
            for (int i = 0; i < AllStudent!.Count; i++)
            {
                Console.WriteLine(AllStudent[i].Name);
            }
        }
    }
}