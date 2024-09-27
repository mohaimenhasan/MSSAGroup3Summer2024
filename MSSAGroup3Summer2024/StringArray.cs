using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSAGroup3Summer2024
{
    public static class StringArray
    {

        // Connor
        //Implement sorting logic here
        public static string[] SortString(this string[] sa)
        {
            //Return if the string is one or less
            if(sa.Length <= 1)
            {
                return sa;
            }
            //var order = sa.OrderBy(x => x);
            string temp;
            for (int i = 0; i < sa.Length - 1; i++)
            {
                for (int j = i + 1; j < sa.Length; j++)
                {
                    if (sa[j].CompareTo(sa[i]) > 0) 
                    {
                        temp = sa[j];
                        sa[j] = sa[i];
                        sa[i] = temp;
                    }
                }
            }
            return sa;
        }

        // 
        // Mike
        //Implement duplicate counter here
        public static int GetDuplicateCount(this string[] sa)
        {
            Dictionary<string, int> uniqueCount = new();
            int duplicateCount = 0;

            foreach(string item in sa)
            {
                /*if (uniqueCount.ContainsKey(item) && uniqueCount[item] == 1)
                {
                    duplicateCount += 1;
                    uniqueCount[item] += 1;
                }*/
                if (uniqueCount.ContainsKey(item))
                {
                    uniqueCount[item] += 1;
                    duplicateCount += 1;
                }
                else
                    uniqueCount.Add(item, 1);
            }

            // group 1 = ["banana", "banana"]
            // Group 2 = ["apple", "apple"]
            // group 3 = ["orange"]

            var duplicateCountUsingLinq = sa.GroupBy(identical => identical)
                .Where(duplicate => duplicate.Count() > 1)
                .Sum(totalDuplicate => totalDuplicate.Count());

            return duplicateCountUsingLinq;

        }

        // Grant
        // Implement duplicate return logic here
        public static IEnumerable<string> ReturnDuplicates(this string[] sa)
        {
        

            IEnumerable<string> duplicates = from x in sa
                                     group x by x into g
                                     where g.Count() > 1
                                     select g.Key;

            var duplicateCountUsingLinq = sa.GroupBy(identical => identical)
                .Where(duplicate => duplicate.Count() > 1)
                .Select(duplicateString => duplicateString.Key);




            return duplicateCountUsingLinq;
        }
    }
}
