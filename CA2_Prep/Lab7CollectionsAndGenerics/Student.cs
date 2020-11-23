using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7CollectionsAndGenerics
{

    public class Student
    {
        public string ID { get; set; }
        public string  Name { get; set; }
        public string Gender { get; set; }

        public Student(string setID, string setName, string setGender)
        {
            ID = setID;
            Name = setName;
            Gender = setGender;
        }
        public Student()
        {

        }

        public override string ToString()
        {
            return $"Student ID: {ID}\n" +
                   $"Student Name: {Name}\n" +
                   $"Student Gender: {Gender}";
        }
    }
}
