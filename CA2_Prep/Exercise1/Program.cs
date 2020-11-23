using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount account = new CurrentAccount(50.00, "1234");
            account.MakeDeposit(100.00);
            account.MakeWithdraw(50.00);

            Console.WriteLine(account);
        }
    }
}
