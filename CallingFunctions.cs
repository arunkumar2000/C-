using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
public class CallingFunctions
    {
        List<string> fruit = new List<string>() { "apple", "grapes", "banana" };
        public void display()
        {
            Console.WriteLine("Fruits :");
            for (int i = 0; i < fruit.Count; i++)
            {
                Console.WriteLine(fruit[i]);
            }
        }
        public void add()
        {
            Console.WriteLine("Enter the fruit you want to add :");
            string addfruit = Console.ReadLine();
            addfruit = addfruit.ToLower();
            fruit.Add(addfruit);

            Console.WriteLine("The updated list is :");
            for (int i = 0; i < fruit.Count; i++)
            {
                Console.WriteLine(fruit[i]);
            }
        }
        public void update()
        {
            Console.WriteLine();
            Console.Write("Enter the fruit which you want to update: ");
            string fruititem1 = Console.ReadLine();
            fruititem1 = fruititem1.ToLower();
            Console.WriteLine();


            if (fruit.Contains(fruititem1))
            {
                int index = fruit.IndexOf(fruititem1);
                Console.WriteLine($"Yes the fruit {fruititem1} is there");
                Console.WriteLine();
                Console.Write($"Enter the fruit to replace with {fruititem1}:");
                string fruititem2 = Console.ReadLine();
                fruititem2 = fruititem2.ToLower();
                Console.WriteLine();

                if (fruit.Contains(fruititem2))
                {
                    Console.WriteLine($"The fruit {fruititem2} is already there");
                    Console.WriteLine();
                }

                else
                {
                    fruit.Remove(fruititem1);
                    fruit.Insert(index, fruititem2);
                    Console.WriteLine($"The fruit {fruititem1} is replaced with {fruititem2} successfully");
                }

            }
            else
            {
                Console.WriteLine($"Sorry the entered fruit {fruititem1} is not in the list");
                Console.WriteLine();


                Console.WriteLine("Enter the fruit you want to Update :");
                string removefruit = Console.ReadLine();

            }
            Console.WriteLine("Fruits :");
            for (int i = 0; i < fruit.Count; i++)
            {
                Console.WriteLine(fruit[i]);
            }
        }
        public void delete()
        {
            Console.WriteLine("Enter the fruit you want to delete :");
            string deletefruit = Console.ReadLine();
            deletefruit = deletefruit.ToLower();
            fruit.Remove(deletefruit);
            Console.WriteLine("The updated list is :");
            for (int i = 0; i < fruit.Count; i++)
            {
                Console.WriteLine(fruit[i]);
            }
        }
    }
}
