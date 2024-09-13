using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSAGroup3Summer2024
{
    internal class IsPalindromeNumber
    {
        public static bool Solution(int x)
        {
            return IsPalindrome(x);
        }

        private static bool IsPalindrome(int x)
        {
            throw new NotImplementedException();
        }

        // Write some test cases here in the following method
        public static void Test_IsPalindrome()
        {
            // Corner cases
            Console.WriteLine("Testing Palindrome");
            Console.WriteLine(IsPalindrome(0)); // Expected: true
            Console.WriteLine(IsPalindrome(1)); // Expected: true
            Console.WriteLine(IsPalindrome(-1)); // Expected: false

            // Random test cases
            Console.WriteLine(IsPalindrome(12321)); // Expected: true
            Console.WriteLine(IsPalindrome(12345)); // Expected: false

            // Negative test cases
            Console.WriteLine(IsPalindrome(-12321)); // Expected: false
            Console.WriteLine(IsPalindrome(-12345)); // Expected: false

            // Positive test cases
            Console.WriteLine(IsPalindrome(123454321)); // Expected: true
            Console.WriteLine(IsPalindrome(123456789)); // Expected: false

            // Test cases that are not palindromes
            Console.WriteLine(IsPalindrome(123456)); // Expected: false

            // Test cases that are palindromes
            Console.WriteLine(IsPalindrome(12321)); // Expected: true
            Console.WriteLine("End tests");
        }
    }
}
