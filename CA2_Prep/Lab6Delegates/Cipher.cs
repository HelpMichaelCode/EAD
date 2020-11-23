using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6Delegates
{
    public delegate string InputMessageDelegate();
    public class Cipher
    {
        private string PlainText { get; set; }
        public Cipher(string setText)
        {
            PlainText = setText;
        }
        private String ShiftUpText()
        {
            string shiftedText = "";
            int index = PlainText.Length - 1;
            int indexCounter = index;

            shiftedText += PlainText[index];

            while(indexCounter > 0)
            {
                shiftedText += PlainText[index - indexCounter];
                indexCounter--;
            }

            return shiftedText;
        }

        public void ReverseMessage()
        {
            // Passing in the method inside the constructor expects a method with empty parameters
            // so the "del" is referencing the method ShiftUpText()
            InputMessageDelegate del = new InputMessageDelegate(ShiftUpText);
            char[] reverseString = del().ToCharArray();
            Array.Reverse(reverseString);
            Console.WriteLine($"Reversed String is: {new string(reverseString)}");
        }
    }
}
