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

            account.deposit(200.00);

            account.withdraw(1000.00);

            account.withdraw(200.00);
        }
    }
}
