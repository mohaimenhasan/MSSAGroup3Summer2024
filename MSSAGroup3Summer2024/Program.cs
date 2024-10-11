using MSSAGroup3Summer2024;

namespace MSSAGroupThree
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Stack, Queue, and LinkedList implementation
            var fruitArray = new string[] { "apple", "banana", "cherry", "date", "elderberry" };
            int n = 2; // Remove first 2 elements
            int k = 2; // Return the 2nd element from the remaining

            foreach (var fruits in fruitArray)
            {
                Console.WriteLine(fruits);
            }

            var reversedFruitStack = fruitArray.ReverseUsingStack();
            Console.WriteLine("Reversed Array: " + string.Join(", ", reversedFruitStack));

            var remainingFruits = fruitArray.RemoveUsingQueue(n);
            Console.WriteLine("Remaining Array after removing first " + n + " elements: " + string.Join(", ", remainingFruits));

            var kthElement = fruitArray.GetKthElementUsingLinkedList(k);
            Console.WriteLine("The " + k + "-th element in the remaining array is: " + kthElement);
        }
    }
}
