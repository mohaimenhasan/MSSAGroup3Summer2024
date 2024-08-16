// break the question -

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
            var firstNonRepeatingNumber = keyValuePairs.FirstOrDefault(kvp => kvp.Value.Count == 1);
            return -1;
        }

        static void Main(string[] args)
        {
            List<int> integers = new List<int>() { };

            // TODO: add test numbers to integers
            FindFirstNonRepeating(integers);
        }
    }
}
