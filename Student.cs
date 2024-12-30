using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student : IPerson,IAddress,IContact
    {
        public int rollno { get; set; }
        //public string sname { get; set; }
        public string pname { get; set; }

        public char gender { get; set; }

        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }

        public int mobile { get; set; }

        public string email { get; set; }


        //string IPerson.pname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //char IPerson.gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static int id = 0;

        public static int incrementId()
        {
            return id += 1;
        }

        //public void displayDetails(int rollno = 0, string sname = "", char gender = ' ')
        //{
        //    if (rollno > 0)
        //    {
        //        Console.WriteLine("Rollno :" + rollno);
        //    }
        //    if (sname != "")
        //    {
        //        Console.WriteLine("Name of Student :" + sname);
        //    }
        //    if (gender != ' ')
        //    {
        //        Console.WriteLine("Gender :" + gender);
        //    }

        //}

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

