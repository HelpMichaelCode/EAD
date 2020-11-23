using System;

namespace Lab6Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Cipher text = new Cipher("Spell");
            text.ReverseMessage();
        }
    }
}
