using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class DateTimeMethod
    {
        
        int Index;
        public void showDateTimeMethod()
        {
            //string[] fruits = { "Apple", "Banana", "Orange", "Papaya"};
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Enter the fruit you want to search :");
            //string fruitname=Console.ReadLine();
            //for(int i = 0; i < fruits.Length; i++)
            //{
            //    if (fruitname == fruits[i])
            //    {
            //        Index = i;
            //        break;
            //    }                                   
            //}
            //int r = Index;
            //Console.WriteLine($"{fruitname} is present in the array", fruitname);
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine($"Enter the fruit need to be replaced with {fruitname}");
            //string rfruit=Console.ReadLine();
            //fruits[r] = rfruit;
            //foreach (string c in fruits) Console.WriteLine(c);

            int count=0;

            Console.WriteLine("Enter a sentence :");
            string sent = Console.ReadLine();
            string[] nameArr = sent.Split(" ");
            Console.WriteLine("No. of words in the sentence is :" + nameArr.Length);

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Character occurance to find:" );
            char occ = Convert.ToChar(Console.ReadLine());
            char[] occurance=sent.ToCharArray();
            //foreach (char j in occurance) Console.WriteLine(j);
            for (int i = 0; i < occurance.Length; i++)
            {
                if (occurance[i].Equals(occ))
                    {
                    count++ ;
                }
            }
            Console.WriteLine($"No. of times {occ} occured in {sent} is :{count}");
            //DateTime d;
            //d=DateTime.Now;
            //string d1 = d.ToString("dd/MM/yyy",CultureInfo.InvariantCulture);
            //Console.WriteLine(d1);
            //Console.WriteLine(d);
            //Console.WriteLine($"Day -> {d.Day}");
            //Console.WriteLine($"Month -> {d.Month}");
            //Console.WriteLine($"Year -> {d.Year}");

            //Console.WriteLine($"Hour -> {d.Hour}");
            //Console.WriteLine($"Minute -> {d.Minute}");
            //Console.WriteLine($"Second -> {d.Second}");
            //Console.WriteLine($"MilliSecond -> {d.Millisecond}");

            //Console.WriteLine($"ShortTime -> {d.ToShortTimeString()}");
            //Console.WriteLine($"LongTime -> {d.ToLongTimeString()}");
            //Console.WriteLine($"ShortDate -> {d.ToShortDateString()}");
            //Console.WriteLine($"LongDate -> {d.ToLongDateString()}");

            //Console.WriteLine($"Day of the week: {d.DayOfWeek.ToString()}");
            //Console.WriteLine($"Day of the week: {d.DayOfYear}");
        }

    }
}
