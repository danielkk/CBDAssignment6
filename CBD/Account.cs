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
            double oldBalance = balance;
            balance += amount;
            Contract.Assert(oldBalance < balance);
        }

        public void Withdraw(double amount)
        {
            Contract.Requires(amount > 0, "Amount under 0!");
            Contract.Requires(amount <= balance, "Withdraw amount larger than balance!");
            balance -= amount;
            Contract.Assert(balance >= 0, "Balance under 0!!");
        }

        [ContractInvariantMethod]
        private void Invariant()
        {
            Contract.Invariant(balance >= 0, "Invariant: balance under 0!");
        }

    }
}
