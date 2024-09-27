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

            var sortedStrings = stringArray.SortString();

            foreach (var sort in sortedStrings)
            {
                Console.WriteLine($"sorted array {sort}");
            }

            var duplicateCount = stringArray.GetDuplicateCount();

            Console.WriteLine($"count of duplicates = {duplicateCount}");

            var stringDuplicates = stringArray.ReturnDuplicates();

            foreach (var duplicate in stringDuplicates)
            {
                Console.WriteLine($"duplicate strings {duplicate}");
            }
        }
    }
}
