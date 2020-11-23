using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public enum TransactionType
    {
        Deposit, Withdrawal
    }

    public class AccountTransaction
    {
		private TransactionType type;       // deposit/withdrawal
		private double amount;          // amount concerned

		// constructor
		public AccountTransaction(TransactionType type, double amount)
		{
			this.type = type;
			this.amount = amount;
		}

		// return human readable String
		public override string ToString()
		{
			return "\nType: " + type + " Amount: " + amount;
		}

	}
}
