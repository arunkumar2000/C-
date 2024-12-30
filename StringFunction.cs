using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class StringFunction
    {
        string fullname = " Arun kumar N ";
        string msg = "Hii Good Morning";
        string city = "PY";
        string city1="pune";
        string city2 = "Pune";

        public void showStringMethods()
        {
            Console.WriteLine("Equal method :"+city1.Equals(city2,StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Replace :" + fullname.Replace("Arun", "Tiger", StringComparison.OrdinalIgnoreCase));

            /*Console.WriteLine("Actual String :" + fullname);
            Console.WriteLine("Actual String :" + fullname.Trim());
            
            Console.WriteLine(fullname.ToUpper());
            Console.WriteLine(fullname.ToLower());

            Console.WriteLine(fullname[0]);
            Console.WriteLine(fullname.Substring(1,3));
            Console.WriteLine(fullname.Remove(2,5));
            Console.WriteLine(fullname.StartsWith("Arun"));
            Console.WriteLine(fullname.EndsWith("Kumar"));
            Console.WriteLine(fullname.Contains("N"));
            Console.WriteLine(fullname.Equals(msg));
            Console.WriteLine(fullname.IndexOf(" "));
            Console.WriteLine(fullname.LastIndexOf(" "));
            Console.WriteLine(string.Format("Good Afternooon {0}",fullname));
            char[] chrs=city.ToCharArray();
            foreach(char c in chrs) Console.WriteLine(c);
            string[] nameArr = fullname.Split(" ");
            foreach (string d in nameArr) Console.WriteLine(d);
            Console.WriteLine(string.Join(" ",nameArr));*/
            //Console.WriteLine("Enter First Name :");
            //string fname = Console.ReadLine();
            //int fl = fname.Length;
            //Console.WriteLine(fname.ToLower());

            //Console.WriteLine("Enter Last Name :");
            //string lname = Console.ReadLine();
            //int ll = fname.Length;
            //Console.WriteLine(fname.ToLower());

            //char fc=fname[0];
            //char fcc=char.ToUpper(fc);
            //string fnamec=fname.Substring(1,fl);
            //string lastname=fcc + fnamec;

            //char lc = lname[0];
            //char lcc=char.ToUpper(lc);
            //string lnamec = fname.Substring(1,ll);
            //string firstname =lcc + lnamec;
            //string fullname = firstname + lastname;
            //Console.WriteLine("Full Name is :" + fullname);

            //Console.WriteLine(fullname.ToUpper());

            //Console.WriteLine("Enter City :");
            //string city = Console.ReadLine();

            //char[] cit = city.ToCharArray();
            //string revstring = "";
            //for(int i=cit.Length-1; i>=0; i--)
            //{
            //   revstring += cit[i];
            //}
            //Console.WriteLine(revstring);
        }
    }
}

