namespace MSSAGroup3Summer2024
{
    public static class MovingZeros
    {
        public static void Test_MovingZeros(string name)
        {
            int[] arrayOne = new int[] { 0, 0, 0, 0, 1, 2, 3, 4 };
            int[] arrayOneFinal = new int[] { 1, 2, 3, 4, 0, 0, 0, 0 };

            int[] arrayTwo = new int[] { 1, 2, 3, 4, 0, 0, 0 };
            int[] arrayTwoFinal = new int[] { 1, 2, 3, 4, 0, 0, 0 };

            int[] arrayThree = new int[0];
            int[] arrayThreeFinal = new int[0];

            int[] arrayFour = new int[] { 0, 0, 0, 0, 0 };
            int[] arrayFourFinal = new int[] { 0, 0, 0, 0, 0 };

            int[] arrayFive = new int[] { 1, 2, 3, 4 };
            int[] arrayFiveFinal = new int[] { 1, 2, 3, 4 };


            Solution(name, arrayOne);
            Solution(name, arrayTwo);
            Solution(name, arrayThree);
            Solution(name, arrayFour);
            Solution(name, arrayFive);

            Console.WriteLine($"XXXXXXXXXXXXXXXXXXXXXXXXXXXX {name} XXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("Test Case 1: " + (arrayOne.SequenceEqual(arrayOneFinal) == true ? "True" : "False"));
            Console.WriteLine("Test Case 2: " + (arrayTwo.SequenceEqual(arrayTwoFinal) == true ? "True" : "False"));
            Console.WriteLine("Test Case 3: " + (arrayThree.SequenceEqual(arrayThreeFinal) == true ? "True" : "False"));
            Console.WriteLine("Test Case 4: " + (arrayFour.SequenceEqual(arrayFourFinal) == true ? "True" : "False"));
            Console.WriteLine("Test Case 5: " + (arrayFive.SequenceEqual(arrayFiveFinal) == true ? "True" : "False"));
        }

        public static void Solution(string name, int[] array)
        {
            switch (name)
            {
                case "MoveZero":
                    MoveZero(array);
                    break;
                case "MoveZeroMikesAttempt":
                    MoveZeroMikesAttempt(array);
                    break;
            }
        }
        //Given an integer array nums, move all 0s to the end of it while maintaining the relative order of the non-zero elements.

        // all ints any real number
        // inplace sorting
        // linear time complexity
        // can be empty

        // eample:

        // input:
        // [0,0,0,1,2,3,4]
        // [1,2,3,4,0,0,0]


        /*
         *  [0,1,0,3,4]
         *  [4,3,1,0,0]
         *  
         *  int j = nums.Length -1
         *  for(int i = 0; i < nums.Length; i++)
         *  
         *  if (nums[i] != 0)
         *     
         *     int tempVar = nums[i]
         *     nums[i] = nums [j]
         *     nums[j] = tempVar
         *     
         *     j--
         *  
         */


        public static void MoveZero(int[] nums)
        {

            int[] tempNums = nums;
            int counter = 0;

            for (int i = 0; i < tempNums.Length; i++)
            {
                if (tempNums[i] != 0)
                {
                    nums[counter] = tempNums[i];
                    counter++;
                }
            }

            for (int i = counter; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        public static void MoveZeroMikesAttempt(int[] nums)
        {
            int lastDigit = nums.Length - 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] == 0)
                {
                    while (i < lastDigit)
                    {
                        int temp = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i] = temp;
                        i++;

                    }

                    lastDigit--;
                }
            }
        }
    }
}
