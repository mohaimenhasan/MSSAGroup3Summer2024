using MSSAGroup3Summer2024;

namespace MSSAGroupThree
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Sorting, Counting, and returning duplicates of a string array
            var stringArray = new string[] { "ccdd", "aa", "efgh", "aaba", "bca", "aba", "abc", "aa", "aaba" };

            foreach (var letters in stringArray)
            {
                Console.WriteLine(letters);
            }

        }
    }
}
