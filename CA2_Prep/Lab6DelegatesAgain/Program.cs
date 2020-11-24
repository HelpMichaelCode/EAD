using System;

namespace Lab6DelegatesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Cipher obj = new Cipher();
            MyCipherDelegate del;
            del = obj.ShiftedUpText;

            Console.WriteLine(obj.ReverseShiftedUpTexted(del("Text")));
        }
    }
}
