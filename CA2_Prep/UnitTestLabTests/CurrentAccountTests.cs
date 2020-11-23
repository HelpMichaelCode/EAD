using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1.Tests
{
    [TestClass()]
    public class CurrentAccountTests
    {
        [TestMethod()]
        public void CheckIfMethodDeposItsMoneyIntoAccount()
        {
            // Arrange
            CurrentAccount account;

            // Act
            account = new CurrentAccount(25.00, "P-96");
            account.MakeDeposit(100.00);

            // Assert
            Assert.AreEqual(account.Balance, 100.00);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckIfArgumentAmountInMethodDepositIsLessThanZero()
        {
            // Arrange
            CurrentAccount account;

            // Act
            account = new CurrentAccount(25.00, "P-96");
            account.MakeDeposit(-90.78);

            // Assert
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckWidrawMethodForArgumentException()
        {
            // Arrange
            CurrentAccount account;


            // Act
            account = new CurrentAccount(25.00, "P-96");
            account.MakeDeposit(100.00);
            account.MakeWithdraw(200.00);

            // Assert
        }
        
        [TestMethod()]
        public void CheckBalanceAfterWithdraw()
        {
            // Arrange
            CurrentAccount account;

            // Act
            account = new CurrentAccount(25.00, "P-96");
            account.MakeDeposit(100.00);
            account.MakeWithdraw(50.00);

            // Assert
            Assert.AreEqual(account.Balance, 50.00);
        }

        //[TestMethod()]
        //public void CheckBalanceAfterOverDraft ()
        //{
        //    // Arrange
        //    CurrentAccount account;

        //    // Act
        //    account = new CurrentAccount(25.00, "P-96");
            

        //    // Assert
        //}

        [TestMethod()]
        public void CheckTransactionHistory()
        {
            // Arrange
            CurrentAccount account;
            var expectedValueForDeposit = new AccountTransaction(TransactionType.Deposit, 100.00);
            var expectedValueForWithdraw = new AccountTransaction(TransactionType.Withdrawal, 50.00);

            // Act
            account = new CurrentAccount(25.00, "P-96");
            account.transactions.Add(expectedValueForDeposit);
            account.transactions.Add(expectedValueForWithdraw);

            // Assert
            Assert.IsTrue(account.transactions.Contains(expectedValueForDeposit));
            Assert.IsTrue(account.transactions.Contains(expectedValueForWithdraw));
        }
    }
}