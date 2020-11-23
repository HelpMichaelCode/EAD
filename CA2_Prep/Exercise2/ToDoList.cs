using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class ToDoList
    {
        private string owner;
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public List<ToDoNote> myTodo;

        public ToDoList(string setOwner)
        {
            Owner = setOwner;
            myTodo = new List<ToDoNote>();
        }

        public void Add(ToDoNote item)
        {
            myTodo.Add(item);
        }
        
        public ToDoNote this[int index]
        {
            get
            {
                return myTodo[index];
            }
        }

        public override string ToString()
        {
            string toDoList = "";
            foreach (var item in myTodo)
            {
                toDoList += $"{item}\n";
            }
            return $"Owner: {Owner}\n" +
                   $"{toDoList}";
        }
    }
}
