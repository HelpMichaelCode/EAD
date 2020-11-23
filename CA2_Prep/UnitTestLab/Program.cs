using System;
using System.Collections.Generic;

namespace UnitTestLab
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("P-999", "123", 50.00);
            account.Deposit(100.00);
            account.Withdraw(150.00);

            // TODO
            // Create unit test for methods and logic


        }
    }
}
