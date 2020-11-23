using System;
using System.Collections.Generic;

namespace UnitTestLab
{
    public class BankAccount
    {
        public List<double> transactionHistory = new List<double>();
        private readonly string sortCode;
        public string SortCode {
            get
            {
                return sortCode;
            }
        }

        private readonly string accountNumber;
        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

        private double overDraftLimit;
        public double OverDraftLimit
        {
            get
            {
                return overDraftLimit;
            }
            set
            {
                overDraftLimit = value;
            }
        }

        private double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        

        // Created default constructor for unit testing purposes
        public BankAccount()
        {
                
        }
        public BankAccount(string setSortCode, string setAccNum, double setOverDraftLimit)
        {
            sortCode = setSortCode;
            accountNumber = setAccNum;
            overDraftLimit = setOverDraftLimit;
            balance = 0.0;
        }

        public BankAccount(string setSortCode, string setAccNum) : this(setSortCode, setAccNum, 0)
        {
        }

        public void Deposit(double amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Invalid amount!");
            }
            balance += amount;
            transactionHistory.Add(amount);
        }
        public void Withdraw(double amount)
        {
            // Check for negative numbers!
            if(amount > balance)
            {
               throw new ArgumentException("Insufficient Amount!");
            }
            else
            {
                balance -= amount;
                transactionHistory.Add(-amount);
            }
        }

        public override string ToString()
        {
            string transHistory = "";
            foreach (var item in transactionHistory)
            {
                transHistory += $"{item}\n";
            }
            return $"Sort Code: {SortCode}\n" +
                   $"Account Number: {AccountNumber}\n" +
                   $"Balance: {Balance}\n" +
                   $"Over draft limit: {OverDraftLimit}" +
                   $"Transaction History: \n" +
                   $"{transHistory}";
        }
       
    }
}
