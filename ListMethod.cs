using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
     class ListMethod: CallingFunctions
    {

      
        int a = 0;
        public void showListMethods()
        {
            
                while (true)
                {
                    Console.WriteLine("Enter the option to be choosed:\n1. Display fruit \n2. Add Fruit \n3. Update Fruit \n4. Delete Fruit \n5. Exit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (option)
                    {
                        case 1:
                            display();
                            break;
                        case 2:
                            add();
                            break;
                        case 3:
                            update();
                            break;
                        case 4:
                            delete();
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("You haven't selected the given option");
                            break;
                    }
                }

            }


            //while (a >= 0)
            //{
            //    List<string> fruit = new List<string>() { "apple", "grapes", "banana" };
            //    Console.WriteLine("Menue");
            //    Console.WriteLine("1. Display fruit");
            //    Console.WriteLine("2. Add Fruit");
            //    Console.WriteLine("3. Update fruit");
            //    Console.WriteLine("4. Delete fruit");
            //    Console.WriteLine("5. Exit");
            //    Console.WriteLine("Select one option: ");
            //    int fruits = Convert.ToInt32(Console.ReadLine());

            //    if (fruits == 1)
            //    {
            //        Console.WriteLine("Fruits :");
            //        for (int i = 0; i < fruit.Count; i++)
            //        {
            //            Console.WriteLine(fruit[i]);
            //        }
            //    }
            //    else if (fruits == 2)
            //    {
            //        Console.WriteLine("Enter the fruit you want to add :");
            //        string addfruit = Console.ReadLine();
            //        addfruit=addfruit.ToLower();
            //        fruit.Add(addfruit);

            //        Console.WriteLine("The updated list is :");
            //        for (int i = 0; i < fruit.Count; i++)
            //        {
            //            Console.WriteLine(fruit[i]);
            //        }
            //    }
            //    else if (fruits == 3)
            //    {
            //        Console.WriteLine();
            //        Console.Write("Enter the fruit which you want to update: ");
            //        string fruititem1 = Console.ReadLine();
            //        fruititem1 = fruititem1.ToLower();
            //        Console.WriteLine();


            //        if (fruit.Contains(fruititem1))
            //        {
            //            int index = fruit.IndexOf(fruititem1);
            //            Console.WriteLine($"Yes the fruit {fruititem1} is there");
            //            Console.WriteLine();
            //            Console.Write($"Enter the fruit to replace with {fruititem1}:");
            //            string fruititem2 = Console.ReadLine();
            //            fruititem2 = fruititem2.ToLower();
            //            Console.WriteLine();

            //            if (fruit.Contains(fruititem2))
            //            {
            //                Console.WriteLine($"The fruit {fruititem2} is already there");
            //                Console.WriteLine();
            //            }

            //            else
            //            {
            //                fruit.Remove(fruititem1);
            //                fruit.Insert(index, fruititem2);
            //                Console.WriteLine($"The fruit {fruititem1} is replaced with {fruititem2} successfully");
            //            }

            //        }
            //        else
            //        {
            //            Console.WriteLine($"Sorry the entered fruit {fruititem1} is not in the list");
            //            Console.WriteLine();


            //            Console.WriteLine("Enter the fruit you want to Update :");
            //            string removefruit = Console.ReadLine();

            //        }
            //        Console.WriteLine("Fruits :");
            //        for (int i = 0; i < fruit.Count; i++)
            //        {
            //            Console.WriteLine(fruit[i]);
            //        }
            //    }         
            //    else if (fruits == 4)
            //    {
            //        Console.WriteLine("Enter the fruit you want to delete :");
            //        string deletefruit = Console.ReadLine();
            //        deletefruit = deletefruit.ToLower();
            //        fruit.Remove(deletefruit);
            //        Console.WriteLine("The updated list is :");
            //        for (int i = 0; i < fruit.Count; i++)
            //        {
            //            Console.WriteLine(fruit[i]);
            //        }
            //    }
            //    else if (fruits == 5)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter the number from given options only");
            //    }
            //        a++;
            //    }


            //List<int> numbers = new List<int>() { 2, 40, 10, 15, 100, 74 };
            //List<int> newnumbers = new List<int>();
            //numbers.Add(11);
            //numbers.Insert(2, 55);
            //numbers.InsertRange(3, newnumbers);

            //numbers.Sort();
            //numbers.Reverse();
            //numbers.Remove(40);
            //numbers.RemoveAt(2);
            //for (int i=0; i<numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

        }
    }
    
