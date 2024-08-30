﻿// break the question -

// given the question, what is the purpose of the question

//

// 

// Given an array of integers, write a method that returns the first

// non-repeating element in the array.


// what questions do we want to ask?

// what is non-repeating? - an integer that only appears once in the array

// [5, 6, 7, 2, 1, 3, 5, 6, 7] ==> 2

// 

// what is the input? - an array of integers
// what if the array is empty => return -1 
// what if all of the numbers repeat  => return -1
// is there a time complexity restraint
// all numbers in the array are positive

using System.Linq;

namespace MSSAGroupThree
{
    public class Program
    {
        public static int FindEasier(List<int> listOfNumbers)
        {
            if (listOfNumbers.Count == 0)
            {
                return -1;
            }

            HashSet<int> duplicatedNumbers = new();
            int minIndex = -1;

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (duplicatedNumbers.Contains(listOfNumbers[i]))
                {
                    continue;
                }
                if (listOfNumbers.IndexOf(listOfNumbers[i], i + 1) != -1)
                {
                    duplicatedNumbers.Add(listOfNumbers[i]);
                    continue;
                }
                if (minIndex == -1 || listOfNumbers[i] < listOfNumbers[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }


        public static int FindFirstNonRepeating(List<int> listOfNumbers)
        {
            if (listOfNumbers.Count == 0)
            {
                return -1;
            }

            // Michael, Sebastian - Dictionary<int, (int Count, int Index)> keyValuePairs = new Dictionary<int, (int, int)>();
            // Florabel, Grant, Owen - List
            Dictionary<int, (int Count, int Index)> keyValuePairs = new Dictionary<int, (int, int)>();
            foreach (var number in listOfNumbers)
            {
                // have a way to check if it's already seen
                // dictionary
                if (keyValuePairs.ContainsKey(number))
                {
                    var (count, index) = keyValuePairs[number];
                    keyValuePairs[number] = (count + 1, index);
                }
                else
                {
                    keyValuePairs.Add(number, (1, listOfNumbers.IndexOf(number)));
                }
            }

            // search for the first item that has the count of 1
            // if it doesn't exist, return -1
            // if it does exist, return the index

            /*
             *  Updated the return and seach. Using FirstOrDefalut is not a good option.
             *  With FirstOrDefalut the list will return 0 if it does not exit, but 0 is larger than -1 and therefore is a a valid option.
             *  with a try catch block using Fist, if it does not exits the catch will return -1 letting the user know it does not exist.
             */
            try
            {
                return keyValuePairs.First(kvp => kvp.Value.Count == 1).Key;
            }
            catch
            {
                return -1;
            }
        }


        static void Main(string[] args)
        {
            List<int> integers = new List<int>() { };

            //integers.Add(0);
            integers.Add(0);
            integers.Add(1);
            integers.Add(1);
            integers.Add(2);
            integers.Add(2);
            integers.Add(3);
            integers.Add(3);
            integers.Add(4);
            integers.Add(4);

            int val = FindFirstNonRepeating(integers);

            if (val == -1)
                Console.WriteLine($"There are no repating numbers in list.");
            else
                Console.WriteLine($"{val} is the first repeating number in the list.");

            Console.Read();
        }
    }
}
