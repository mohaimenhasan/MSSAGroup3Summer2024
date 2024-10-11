using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSAGroup3Summer2024
{
    public static class StackQueueLinkedList
    {
        //Reversed Array: elderberry, date, cherry, date, elderberry
        //    Remaining Array after removing first 2 elements: cherry, date, elderberry
        //    The 2-th element in the remaining array is: cherry


        //Grant
        // Output: ["elderberry", "date", "cherry", "banana", "apple"] 
        public static string[] ReverseUsingStack(this string[] fruitArray)
        {
            // what if fruitArray is empty?
            if (fruitArray.Length == 0)
            {
                return fruitArray;
            }
            //LIFO
            Stack<string> stack = new Stack<string>();

            //Push elements to stack
            foreach (string s in fruitArray)
            {
                stack.Push(s);
            }

            int pointer = 0;
            //Pop elements to reverse the array
            while (stack.Count > 0)
            {
               fruitArray[pointer++] = stack.Pop();
            }

            return fruitArray;

            // throw new NotImplementedException();
        }

        //Connor
        // Remove the first 2 elements (n) using a queue
        // Output: ["cherry", "banana", "apple"] 
        public static string[] RemoveUsingQueue(this string[] fruitArray, int n)
        {
            // what if fruitArray is empty? what if n is 0? what if n is greater than the length of fruitArray?
            try
            {
                if (fruitArray == null || n == 0)
                {
                    return fruitArray;
                }
                if(n > fruitArray.Length)
                {
                    return Array.Empty<string>();
                }
                //FIFO
                Queue<string> queue = new Queue<string>();
                //Enqueue array
                foreach (string s in fruitArray)
                {
                    queue.Enqueue(s);
                }
                //Dequeue N elements
                for (int i = 0; i < n; i++)
                {
                    //queue.Count
                    queue.Dequeue();
                }
                return queue.ToArray();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return fruitArray;
            }
            //throw new NotImplementedException();
        }

        //Michael
        // Use a linked list to store the remaining elements and return the 2nd element (k)
        // Output: "date"
        public static string GetKthElementUsingLinkedList(this string[] fruitArray, int k)
        {
            // what if fruitArray is empty? what if n is 0? what if n is greater than the length of fruitArray?
            try
            {            
                if (k > fruitArray.Length - 1 || fruitArray is null)
                    return fruitArray == null? "Input is null" : $"Array does not contain an element at {k}.";
                LinkedList<string> linkedList = new();

                // go through the fruitArray and add them to the linked list
                for (int i = 0; i < fruitArray.Length; i++)
                {
                    if (i == 0)
                        linkedList.AddFirst(fruitArray[0]);
                    else 
                        linkedList.AddLast(fruitArray[i]);
                }
                
                // now the linked list has all the elements
                return (linkedList.ElementAt(k - 1)); // maybe this should be k (good catch)
            }
            catch(Exception ex)
            {
                return "This function is currently broken please come back another time :/";
            }
        }

        // Given an array of fruits and an integer k, write a function to rotate the array to the right by k steps. 
        // Convert the array to a linked list and then perform the rotation. Return the rotated array as a string array.
        // string[] fruitArray = { "apple", "banana", "cherry", "date", "elderberry" };
        // RotateFruitArrayUsingLinkedList(fruitArray, 2); // Output: {"date", "elderberry", "apple", "banana", "cherry"}
        public static string[] RotateFruitArrayUsingLinkedList(this string[] fruitArray, int k)
        {
            throw new NotImplementedException();
        }
    }
}
