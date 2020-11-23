using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            RadioPlayerApp radioApp = new RadioPlayerApp("Michael's Radio Player");
            // radioApp.Like("Newstalk");
            foreach (var item in radioApp[RadioContent.Music])
            {
                Console.WriteLine(item);
                Console.WriteLine("--------------");
            }
        }
    }
}
