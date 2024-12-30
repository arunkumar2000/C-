using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal interface IAddress
    {
        
        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }

        
    }
}
