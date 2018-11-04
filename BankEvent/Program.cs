using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Account MyAccount = new Account(10000);
            MyAccount.TransactionMade += TestEvent.SendNotification;
            MyAccount.Credit(500);
            MyAccount.Debit(20);
            MyAccount.Credit(100);
            MyAccount.Debit(20000);
            Console.WriteLine("Your Current Balance is : " + MyAccount.BalanceAmount);
            Console.ReadLine();
        }
    }
}
