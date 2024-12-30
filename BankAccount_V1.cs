using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    namespace Banking
    {
        partial class BankAccount
        {
            public int acctno = 1234;
            public string accname = "Arunkumar";
            public double cbalance = 100000;
            
            public void deposit (double dep)
            {
                cbalance += dep;
            }

            
        }
    }
}
