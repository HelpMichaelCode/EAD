using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise2;
using System;
using System.Xml;

namespace Exercise2.Tests
{
    [TestClass()]
    public class ToDoListTests
    {
        [TestMethod()]
        public void TestThatATodoNotesItemAreAdded()
        {
            // Arrange
            ToDoNote expectedMyTodo1 = new ToDoNote("Test1", DateTime.Now, Priority.High);
            ToDoNote expectedMyTodo2 = new ToDoNote("Test2", DateTime.Now, Priority.Normal);

            ToDoList expectedListOfTodos;

            // Act
            expectedListOfTodos = new ToDoList("Michael");

            expectedListOfTodos.Add(expectedMyTodo1);
            expectedListOfTodos.Add(expectedMyTodo2);

            // Assert
            Assert.IsTrue(expectedListOfTodos.myTodo.Contains(expectedMyTodo1));
            Assert.IsTrue(expectedListOfTodos.myTodo.Contains(expectedMyTodo2));
        }

        [TestMethod()]
        public void IndexerShouldReturnSpecificToDoNoteItem()
        {
            // Arrange
            ToDoNote expectedToDoReturned;
            ToDoList list;

            // Act
            expectedToDoReturned = new ToDoNote("HelloWorld", DateTime.Now, Priority.High);
            list = new ToDoList("Michael");
            list.Add(expectedToDoReturned);

            // Arrange
            Assert.AreSame(list[0], expectedToDoReturned);
        }

        [TestMethod()]
        public void InputFileNameTest()
        {
            // Arrange
            ToDoNote note;
            string expectedContent = "";
            string actualContent = "";
            XmlTextReader reader;

            // Act
            reader = new XmlTextReader("UnitTestXML.xml");
            expectedContent = "Utopia10/10/2014 20:22:160";
            note = new ToDoNote("Utopia", new DateTime(2014, 10, 10, 20, 22, 16), Priority.High);
            note.InputFileName("UnitTestXML.xml");

            while (reader.Read())
            {
                actualContent += $"{reader.ReadString()}";
            }

            // Assert
            Assert.AreEqual(expectedContent, actualContent);
        }
    }
}