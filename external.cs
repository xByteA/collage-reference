using System;
using BankSystem;
namespace PaymentService
{
    public class PaymentProcessor : Account
    {
        public PaymentProcessor(string accNum) : base(accNum) { }

        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing payment from Account: {accountNumber}");
            // can't modified 'balance' because it is internal attribute
            Console.WriteLine($"Payment of {amount} sent to BankSystem for processing.");
        }
    }
//  this is testing class for show diff between internal and protected in external assembly
    public class Client
    {
        public void TryPayment(Account acc, decimal amount)
        {
            // can't access any attribute from Account class
            // acc.balance -= amount;
            // Console.WriteLine(acc.accountNumber);

            Console.WriteLine("Client can only request payment. Cannot access any attributes.");
        }
    }
}