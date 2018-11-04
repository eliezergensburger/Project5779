using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEvent
{
    //public delegate void TransactionHandler(object sender, TransactionEventArgs e); // Delegate Definition
    class Account
    {
        public event EventHandler<TransactionEventArgs> TransactionMade = null; // Event Definition

        public int BalanceAmount;

        public Account(int amount)
        {
            this.BalanceAmount = amount;
        }

        public void Debit(int debitAmount)
        {
            if (debitAmount < BalanceAmount)
            {
                BalanceAmount = BalanceAmount - debitAmount;
                TransactionEventArgs e = new TransactionEventArgs(debitAmount, "Debited");
                OnTransactionMade(e); // Debit transaction made
            }
        }

        public void Credit(int creditAmount)
        {
            BalanceAmount = BalanceAmount + creditAmount;
            TransactionEventArgs e = new TransactionEventArgs(creditAmount, "Credited");
            OnTransactionMade(e); // Credit transaction made

        }

        protected virtual void OnTransactionMade(TransactionEventArgs e)
        {
            if (TransactionMade != null)
            {
                TransactionMade(this, e); // Raise the event 
            }
        }
    }
}
