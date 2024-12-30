using StudentApp.Banking;
using System;
using System.Net.Http.Headers;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListMethod lm = new ListMethod();
            lm.showListMethods();
            //ArrayFunctions af = new ArrayFunctions();
            //af.showArrayFunctions();
            //DateTimeMethod dtm = new DateTimeMethod();
            //dtm.showDateTimeMethod();
            //StringFunction sf = new StringFunction();
            //sf.showStringMethods();

            //MathMethod mm = new MathMethod();
            //mm.showMathMethod();
            //StudentApp.Banking.BankAccount ba;
            //ba= new Banking.BankAccount();
            //Console.WriteLine("Current Balance {0}", ba.cbalance);
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Enter the amount that has to be deposited :");
            //double dep=Convert.ToDouble(Console.ReadLine());
            //ba.deposit(dep);
            //Console.WriteLine("After Depositing {0} Current Balance {1}", dep,ba.cbalance);
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Enter the amount that has to be withdrawn :");
            //double with=Convert.ToDouble(Console.ReadLine());
            //ba.withdrawl(with);
            //Console.WriteLine("After Withdrawing {0} Current Balance {1}", with,ba.cbalance);
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Enter First Name :");
            //string fname=Console.ReadLine();
            //Console.WriteLine("Enter Last Name :");
            //string lname = Console.ReadLine();
            //Console.WriteLine("Enter City :");
            //string city = Console.ReadLine();
            //Console.WriteLine(fname + lname + " is coming from " +city);
            //Console.WriteLine("Name is : " + fname + lname );
            //Console.WriteLine("City : " + city);
            //Console.WriteLine("Student Application Management System");
            //Student s1 = new Student();
            //s1.rollno = Student.incrementId();
            ////s1.sname = "Sam Praveen";
            //s1.pname = "Sam Praveen";
            //s1.gender = 'M';
            //s1.state = "PY";
            //s1.city = "PY";
            //s1.zipcode = 605008;
            //s1.mobile = 822009988;
            //s1.email = "xyz@gmail.com";
            ////Console.WriteLine("Roll No : " + s1.rollno + "\nName :" + s1.sname + "\nGender: " + s1.gender);
            ////s1.displayDetails(1, "Arun", 'M');
            //s1.showDetails();
            //Console.WriteLine(s1.getAddress());
            //Console.WriteLine(s1.showContact());
            ////Student s2 = new Student();
            ////s2.rollno = Student.incrementId();
            ////s2.sname = "Praveen Kumar";
            ////s2.gender = 'M';
            //Console.WriteLine("==============================================================================");
            //////Console.WriteLine("Roll No : " + s2.rollno + "\nName :" + s2.sname + "\nGender: " + s2.gender);
            ////s2.displayDetails(1, "Arun", 'M');
            //Console.ReadKey();

            //Console.WriteLine("Faculty Application Management System");
            //Faculty f = new Faculty();
            //f.rollno=Faculty.incrementId();
            //f.pname = "Sam Praveen";
            //f.gender = 'M';
            //f.state = "PY";
            //f.city = "PY";
            //f.zipcode = 605008;
            //f.mobile = 822009988;
            //f.email = "xyz@gmail.com";
            //f.showDetails();
            //Console.WriteLine(f.getAddress());
            //Console.WriteLine(f.showContact());
            //Console.WriteLine("==============================================================================");
            //Console.ReadKey();

        }
    }
}