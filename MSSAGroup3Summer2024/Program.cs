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

using MSSAGroup3Summer2024;

namespace MSSAGroupThree
{
    public class Program
    {
        static void Main(string[] args)
        {
            //FindFirstNonRepeating.Test_FindFirstNonRepeating(optimized: false);
            //FindFirstNonRepeating.Test_FindFirstNonRepeating(optimized: true);

            // MovingZeros.Test_MovingZeros(nameof(MovingZeros.MoveZero));
            // MovingZeros.Test_MovingZeros(nameof(MovingZeros.MoveZeroMikesAttempt));

            IsPalindromeNumber.Test_IsPalindrome();

        }
    }
}
