using System;
using System.Collections.Generic;

namespace Lab7CollectionsAndGenerics
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student> 
            { 
               new Student("X00146", "Michael", "Male"),
               new Student("X00147", "Peter", "Male"),
               new Student("X00148", "Nial", "Male"),
               new Student("X00149", "Harry", "Male"),
            };

            StudentClass classroom = new StudentClass("CRN-125", "Mr.Higgins");
            Console.WriteLine(classroom);

            foreach (var item in studentList)
            {
                Console.WriteLine(item);
                classroom.AddStudent(item);
                Console.WriteLine("--------------");
            }
        }
    }
}
