using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab7CollectionsAndGenerics
{
    public class StudentClass
    {
        public string CRN { get; set; }
        public string LectureName { get; set; }

        List<Student> studentList;

        public StudentClass(string setCRN, string setLectureName)
        {
            CRN = setCRN;
            LectureName = setLectureName;
            studentList = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            studentList.Add(student);

            var duplicateID = from students in studentList group students by students.ID into g where g.Count() > 1 select g.Key;

            if (duplicateID.Contains(student.ID))
            {
                throw new ArgumentException("Duplicate ID's found");
            }
        }

        public Student this[int index]
        {
            get
            {
                // This grabs a specific student from the list of students in the class
                return studentList[index];
            }
        }

        public Student this[string idSearch]
        {
            get
            {
                Student student = new Student();
                foreach (var item in studentList)
                {
                    if(idSearch == item.ID)
                    {
                        student = item;
                    }
                    // I'll come back to this
                    //else
                    //{

                    //}
                }
                return student;
            }
        }

        public override string ToString()
        {
            return $"Student CRN: {CRN} - Lecture Name: {LectureName}";
        }
    }
}
