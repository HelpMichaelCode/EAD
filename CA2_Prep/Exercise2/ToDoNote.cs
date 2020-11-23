using System;
using System.Xml;

namespace Exercise2 
{
    public enum Priority
    {
        High, Normal, Low
    }
    public class ToDoNote : SerialisedXML
    {
        private string subject;

        public string Subject
        {
            get 
            {
                return subject;
            }
            set 
            { 
                subject = value; 
            }
        }

        private DateTime date;

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        private Priority priority;

        public Priority NotePriority
        {
            get
            {
                return priority;
            }
            set
            {
                priority = value;
            }
        }

        public ToDoNote(string setSubject, DateTime setDateTime, Priority setPriority)
        {
            Subject = setSubject;
            Date = setDateTime;
            NotePriority = setPriority;
        }

        public void InputFileName(string fileName)
        {
            XmlTextWriter writer = new XmlTextWriter(fileName, null);
            writer.WriteStartDocument();
            writer.WriteStartElement("To-Do-Note");
            writer.WriteElementString("Subject", Subject);
            writer.WriteElementString("Due-date", Date.ToString());
            writer.WriteElementString("Priority", NotePriority.ToString("d"));
            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();
        }

        public void ReadContentFromXMLFile(string fileName)
        {
            string result = "";
            XmlTextReader reader = new XmlTextReader(fileName);

            while (reader.Read())
            {
                result += $"{reader.ReadString()}";
            }
            Console.WriteLine(result);
        }
        public override string ToString()
        {
            return $"Subject: {Subject}\n" +
                   $"Datetime: {Date.Date}\n" +
                   $"Priority: {NotePriority}\n" +
                   $"----------------------";
        }
    }
}
