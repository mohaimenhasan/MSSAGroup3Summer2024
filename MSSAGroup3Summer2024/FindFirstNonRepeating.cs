namespace MSSAGroup3Summer2024;

public static class FindFirstNonRepeating
{
    public static void Test_FindFirstNonRepeating(bool optimized = false)
    {
        List<int> testCase1 = new List<int> { 0, 1, 1, 2, 2, 3, 3, 4, 4 };
        List<int> testCase2 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> testCase3 = new List<int> { 1, 1, 1, 1, 1 };
        List<int> testCase4 = new List<int> { };
        List<int> testCase5 = new List<int> { 1 };
        List<int> testCase6 = new List<int> { 5, 6, 7, 2, 1, 3, 5, 6, 7 };

        if (optimized)
        {
            Console.WriteLine("xxxxxxxxxxxxxxxxxx Optimized Solution xxxxxxxxxxxxxxxxxx");
        }
        else
        {
            Console.WriteLine("xxxxxxxxxxxxxxxxxx Non-Optimized Solution xxxxxxxxxxxxxxxxxx");
        }

        Console.WriteLine("Test Case 1: " + (Solution(testCase1, optimized) == 0 ? "Passed" : "Failed"));
        Console.WriteLine("Test Case 2: " + (Solution(testCase2, optimized) == 1 ? "Passed" : "Failed"));
        Console.WriteLine("Test Case 3: " + (Solution(testCase3, optimized) == -1 ? "Passed" : "Failed"));
        Console.WriteLine("Test Case 4: " + (Solution(testCase4, optimized) == -1 ? "Passed" : "Failed"));
        Console.WriteLine("Test Case 5: " + (Solution(testCase5, optimized) == 1 ? "Passed" : "Failed"));
        Console.WriteLine("Test Case 6: " + (Solution(testCase6, optimized) == 2 ? "Passed" : "Failed"));
    }

    public static int Solution(List<int> listOfNumbers, bool optimized = false)
    {
        if (optimized)
        {
            return FindEasier(listOfNumbers);
        }

        return FindNumber(listOfNumbers);
    }

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

    public static int FindNumber(List<int> listOfNumbers)
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
}
