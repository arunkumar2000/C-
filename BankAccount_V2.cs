﻿using System;
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

            public void withdrawl (double with)
            {
                cbalance -= with;
            }
        }
    }
}
