﻿using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Arrays
            //TODO: Create an integer Array of size 50
            var numbers = new int[50];
            Populater(numbers);
            

            //TODO: Print the first number of the array
            Console.WriteLine(numbers[0]);

            //TODO: Print the last number of the array
            Console.WriteLine(numbers[49]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            
            Array.Reverse(numbers);
            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(numbers);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");
            

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Array.Sort(numbers);
            
            Console.WriteLine("Sorted numbers:");
            
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            
            var numbersList = new List<int>();

            //TODO: Print the capacity of the list to the console

            Console.WriteLine(numbersList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            
            Populater(numbersList);

            //TODO: Print the new capacity

            Console.WriteLine(numbersList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                NumberChecker(numbersList, number);
            }
            else
            {
                Console.WriteLine("You did not enter a valid number");
            }
                
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            
            NumberPrinter(numbersList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numbersList);
            NumberPrinter(numbersList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            numbersList.Sort();
            NumberPrinter(numbersList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] listToArray = numbersList.ToArray();

            //TODO: Clear the list
            
            numbersList.Clear();


            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(x => x % 2 != 0);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes, the list contains {searchNumber}.");
            }
            else
            {
                Console.WriteLine($"No, the list doesn't contain {searchNumber}.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random random = new Random();

            for (int i = 0; i < numberList.Count; i++)
            {
                numberList[i] = random.Next(51);
            }

        }

        private static void Populater(int[] numbers)
        {
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 50);
            }

        }        

        private static void ReverseArray(int[] array)
        {   
            Array.Reverse(array);
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
