namespace MSSAGroup3Summer2024
{
    public static class MovingZerosMethod
    {
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
                nums[counter] = 0;
            }
        }
    }
}
