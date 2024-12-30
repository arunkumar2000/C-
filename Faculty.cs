using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Faculty:IPerson,IAddress,IContact
    {
        public int rollno { get; set; }
        public string pname { get; set; }
        public char gender { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }
        public int mobile { get; set; }
        public string email { get; set; }

        public static int id = 0;

        public static int incrementId()
        {
            return id += 1;
        }
        public void showDetails()
        {
            if (rollno > 0)
            {
                Console.WriteLine("Rollno :" + rollno);
            }
            if (pname != "")
            {
                Console.WriteLine("Name of Student :" + pname);
            }
            if (gender != ' ')
            {
                Console.WriteLine("Gender :" + gender);
            }
        }
        public string getAddress()
        {
            return $"Address is : City:{city}, State:{state}, Zipcode:{zipcode} ";
        }

        public string showContact()
        {
            return $"Contact is Mobile:{mobile}, Email:{email}";
        }
    }
}
