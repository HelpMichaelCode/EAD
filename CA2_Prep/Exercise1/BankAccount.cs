namespace Exercise1
{
    public abstract class BankAccount
    {
        private readonly string accountNumber;
        public string AccountNumber 
        {
            get
            {
                return accountNumber;
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

        public BankAccount(string setAccountNumber)
        {
            accountNumber = setAccountNumber;
            balance = 0;
        }

        public abstract void MakeDeposit(double amount);
        public abstract void MakeWithdraw(double amount);

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}\n" +
                   $"Balance: {Balance}"; 
        }
    }
}
