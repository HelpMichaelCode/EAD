using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoNote note = new ToDoNote("Test1", new DateTime(2014, 10, 10, 20, 22, 16), Priority.High);
            note.InputFileName("MyXml.xml");

            note.ReadContentFromXMLFile("MyXml.xml");

            //List<ToDoNote> myTodoList = new List<ToDoNote>
            //{
            //    new ToDoNote("Test1", DateTime.Now, Priority.High),
            //    new ToDoNote("Test2", DateTime.Now, Priority.Low),
            //    new ToDoNote("Test3", DateTime.Now, Priority.Normal),
            //    new ToDoNote("Test4", DateTime.Now, Priority.High)
            //};

            //ToDoList list = new ToDoList("Mark");
            //foreach (var item in myTodoList)
            //{
            //    list.Add(item);
            //}
            //Console.WriteLine(list[1]);
            // Console.WriteLine(list);
    }
    }
}
