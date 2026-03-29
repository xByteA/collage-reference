using System;

// name it internal assemply
namespace BankSystem
{
    public class Account
    {
        internal decimal balance = 10000;

        protected string accountNumber;

        public Account(string accNum)
        {
            accountNumber = accNum;
        }

        internal void UpdateBalance(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Balance updated: {balance}");
        }

        protected decimal CalculateFee(decimal amount)
        {
            return amount *(2/100);
        }
    }

    public class SavingAccount : Account
    {
        public SavingAccount(string accNum) : base(accNum) { }

        public void ShowAccount()
        {
            Console.WriteLine($"Account Number: {accountNumber}"); 
            Console.WriteLine($"Balance: {balance}"); 
        }

        public void DeductFee(decimal amount)
        {
            decimal fee = CalculateFee(amount);
            UpdateBalance(-fee);
            Console.WriteLine($"Fee deducted: {fee}");
        }
    }
    // show diff between internal and protected in internal assembly
    public class BankEmployee
    {
        public void AdjustBalance(Account acc, decimal amount)
        {
            acc.UpdateBalance(amount);
            Console.WriteLine($"Adjust updated: {balance}");

            // can't access CalculateFee method because BankEmployee class not a sub class from Account class 
            // acc.CalculateFee(amount);
            // Console.WriteLine(acc.accountNumber);
        }
    }
}