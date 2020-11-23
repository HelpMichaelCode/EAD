using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestLab.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        BankAccount account = new BankAccount();

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckDepositAmountLessThanOrEqualsToZero()
        {
            // Check for negative number deposit
            // Check for only numbers and not letters

            // Arrange
            double amount;

            // Act
            amount = -3;
            account.Deposit(amount);

            // Assert
        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),"Insufficient Amount!")]
        public void CheckWithdrawMethodAboveTheBalance()
        {
            // Arrange
            double amount;

            // Act
            amount = 100.00;
            account.OverDraftLimit = 50.00;

            // Adding money to the account balance
            account.Deposit(amount);
            account.Withdraw(160.00);

            // Assert not needed as we are checking for 
            // for Argument Exception
        }

        [TestMethod()]
        public void CheckTransactionHistory()
        {
            // Arrange

            double expectedValueForWithdraw = 45.32;
            double expectedValueForDeposit = 46.99;

            // Act
            account.Deposit(expectedValueForDeposit);
            account.Withdraw(expectedValueForWithdraw);


            // Assert
            Assert.IsTrue(account.transactionHistory.Contains(-expectedValueForWithdraw));
            Assert.IsTrue(account.transactionHistory.Contains(expectedValueForDeposit));
        }
     
        // Unit test for over draft limit
    }
}