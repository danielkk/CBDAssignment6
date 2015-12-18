using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace CBD
{
    class Account
    {
        public double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account(double amount)
        {
            this.balance = amount;
        }

        public void Deposit(double amount)
        {
            Contract.Requires(amount > 0, "Amount under 0!");
            Contract.Ensures(
                    Contract.OldValue<double>(balance)+amount == balance
            );
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            Contract.Requires(amount > 0, "Amount under 0!");
            Contract.Requires(amount <= balance, "Withdraw amount larger than balance!");
            Contract.Ensures(
                   Contract.OldValue<double>(balance) > balance 
            );
            Contract.EnsuresOnThrow<ArgumentException>(
                Contract.OldValue<double>(balance) == balance
            );
            if (amount > balance)
            {
                throw new ArgumentException("The amount is too damn high!!!");
            }
            balance -= amount;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(balance >= 0.0, "Invariant: balance under 0!");
        }

    }
}
