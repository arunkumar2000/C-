using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class ArrayFunctions
    {
        int a = 0;
        
        public void showArrayFunctions()
        {
            //int[] numbers = { 10, 200, 6, 4, 51 };
            //int[] newnumbers = new int[5];
            //Console.WriteLine("Index is : " + Array.IndexOf(numbers, 6));
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Binarysearch is : " + Array.BinarySearch(numbers, 6));
            //Console.WriteLine("-------------------------------------");
            //numbers.CopyTo(newnumbers, 0);
            //Array.Resize(ref newnumbers, 7);
            //newnumbers[5] = 15;
            //newnumbers[6] = 13;
            //Array.Clear(newnumbers, 2, 2);

            ////Array.Sort(numbers);
            ////Array.Reverse(numbers);
            //Console.WriteLine("-------------------------------------");
            //foreach (int num in newnumbers)
            //    Console.WriteLine(num);

            //int[] ar = { 2, 5, 3, 8, 4, 9, 5 };
            //Console.Write("Enter the element you want to search : ");
            //int numtofind = Convert.ToInt32(Console.ReadLine());
            //if (Array.IndexOf(ar, numtofind) != -1) 
            //{
            //    Console.WriteLine($"{numtofind} is present in the array ar");
            //}
            //else
            //{
            //    Console.WriteLine($"{numtofind} is not present in the array");
            //}

            string[] fruits = { "Apple", "Banana", "Guva", "Strawberry" };

            while ( a>=0)
            {
                
                Console.WriteLine("----------------Operations------------ ");
                Console.WriteLine("Choose the option :");
                Console.WriteLine("1. Display all the fruits.");
                Console.WriteLine("2. Find fruit.");
                Console.WriteLine("Press 3 to Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    for (int i = 0; i < fruits.Length; i++)
                    {
                        Console.WriteLine("Fruits :");
                        Console.WriteLine(fruits[i]);
                    }


                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter the fruit you want to search :");
                    string fruittofind = Console.ReadLine();

                    //fruittofind.ToLower();


                    fruittofind = char.ToUpper(fruittofind[0]) + fruittofind.Substring(1).ToLower();


                    if (Array.IndexOf(fruits, fruittofind) != -1)
                    {
                        Console.WriteLine($"{fruittofind} is present in the array fruits");
                    }
                    else
                    {
                        Console.WriteLine($"{fruittofind} is not present in the array fruits");
                    }
                }
                else if (option == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the number from given options only");
                }
                a++;
            }
            

            //Console.WriteLine("Enter the fruit you want to search :");
            //string fruittofind = Console.ReadLine();

            ////fruittofind.ToLower();


            //fruittofind = char.ToUpper(fruittofind[0]) + fruittofind.Substring(1).ToLower();


            //if (Array.IndexOf(fruits, fruittofind) != -1)
            //{
            //    Console.WriteLine($"{fruittofind} is present in the array fruits");
            //}
            //else
            //{
            //    Console.WriteLine($"{fruittofind} is not present in the array fruits");
            //}
        }
    }
}
