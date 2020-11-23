using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class CurrentAccount : BankAccount
    {
        public List<AccountTransaction> transactions;
        private double overDraftLimit;
        public double OverDraftLimit 
        {
            get 
            {
                return overDraftLimit;
            }
        }

        public CurrentAccount(double setOverDraftLimit, string setAccountNumber) : base(setAccountNumber)
        {
            overDraftLimit = setOverDraftLimit;
            transactions = new List<AccountTransaction>();
            Balance = 0.0;
        }

        public override void MakeDeposit(double amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Invalid amount!");
            }
            Balance += amount;
            transactions.Add(new AccountTransaction(TransactionType.Deposit, amount));
        }

        public override void MakeWithdraw(double amount)
        {
            if(amount > Balance) // Checks if the amount is greater than the balance
            {
                Balance += OverDraftLimit; // If it is, apply the overdraft 
                if(amount > Balance) // If the amount is still greater than the balance after applying the overdrafft, throw an error
                {
                    throw new ArgumentException("Insufficient Amount!");
                }
            }
            Balance -= amount;
            transactions.Add(new AccountTransaction(TransactionType.Withdrawal, amount));
        }

        public override string ToString()
        {
            string historyOfTransactions = "";
            foreach (var item in transactions)
            {
                historyOfTransactions += $"{item}\n";
            }
            return $"Account Number: {AccountNumber}\n" +
                   $"Balance: {Balance}\n" +
                   $"Transaction History: {historyOfTransactions}"; 
        }
    }
}
