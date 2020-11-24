using System;

namespace Lab6DelegatesAgain
{
    // F = function()
    // param(F())
    public delegate string MyCipherDelegate(string plainText);
    public class Cipher
    {
        public string ShiftedUpText(string plainText)
        {
            string shiftMessage = "";

            int index = plainText.Length - 1;
            int indexCounter = index;

            shiftMessage += plainText[index];
            while (indexCounter > 0)
            {
                shiftMessage += plainText[index - indexCounter];
                indexCounter--;
            }
            return shiftMessage;
        }

        public string ReverseShiftedUpTexted(string plainText)
        {
            char[] text = plainText.ToCharArray();
            Array.Reverse(text); // LOOOOOOOOOOL
            return new string(text);
        }
    }
}
