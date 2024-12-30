using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class MathMethod
    {
        int num1 = 2;
        int num2 = 8;
        double num3 =10.5;
        int num4 = -11;
        int n1;
        int n2;
        int minValue;
        int maxValue;
        public void showMathMethod()
        {
            int[] numbers = {10,200,6,4,51 };
            int[] newnumbers = new int[5];
            Console.WriteLine("Index is : " + Array.IndexOf(numbers, 6));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Binarysearch is : " + Array.BinarySearch(numbers, 6));
            Console.WriteLine("-------------------------------------");
            numbers.CopyTo(newnumbers, 0);
            Array.Resize(ref newnumbers, 7);
            newnumbers[5] = 15;
            newnumbers[6] = 13;
            Array.Clear(newnumbers, 2,2);

            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            Console.WriteLine("-------------------------------------");
            foreach (int num in newnumbers)
                Console.WriteLine(num);

            //Console.WriteLine($"{num1} and {num2} -> Min: {Math.Min(num1,num2)}");
            //Console.WriteLine($"{num1} and {num2} -> Max: {Math.Max(num1,num2)}");
            //Console.WriteLine($"{num3} -> Floor: {Math.Floor(num3)}");
            //Console.WriteLine($"{num3} -> Ceil: {Math.Ceiling(num3)}");
            //Console.WriteLine($"{num3} -> Round: {Math.Round(num3)}");
            //Console.WriteLine($"{num4} -> Abs: {Math.Abs(num4)}");
            //Console.WriteLine($"{num2} and {num1} -> Power: {Math.Pow(num2,num1)}");
            //Console.WriteLine($"{num2} -> Sqrt: {Math.Sqrt(num2)}");

            //int[] numbers = { 4, 2, 9, 6, 9, 21, 8, 3, 10, 4};
            //int len=numbers.Length;
            //minValue = numbers[0];
            //maxValue = numbers[0];
            //for (int i = 0; i < len; i++)
            //{
            //    //n2 = numbers[i];
            //    minValue=Math.Min(minValue, numbers[i]);
            //    //if (n1 >= n2)
            //    //{
            //    //    n1 = n2;
            //    //}
            //}
            //Console.WriteLine("Smallest Number in the array is :" + minValue);

            //for (int i = 0; i < len; i++)
            //{
            //    // n2 = numbers[i];
            //    maxValue = Math.Max(maxValue, numbers[i]);
            //    //if (n1 <= n2)
            //    //{
            //    //    n1 = n2;
            //    //}
            //}
            //Console.WriteLine("Largest Number in the array is :" + maxValue);

            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    if (numbers[i] >= numbers[i + 1])
            //    {
            //        int temp = numbers[i];
            //        numbers[i] = numbers[i + 1];
            //        numbers[i + 1] = temp;
            //    }

            //}
            //Console.WriteLine("The minimum value: " + numbers[0]);

        }
    }
}
