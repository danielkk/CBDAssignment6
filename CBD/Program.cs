using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace CBD
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1000.00);

            account.Deposit(1);
            account.Withdraw(1000.00);
            account.Withdraw(200.00);
        }
    }
}
