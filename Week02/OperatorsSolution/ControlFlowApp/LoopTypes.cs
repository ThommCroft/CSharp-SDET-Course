using System;

namespace ControlFlowApp
{
    public static class LoopTypes
    {
        /// <summary>
        /// Finish each loop bellow so it returns the Highest Number from the List. (Done)
        /// 
        /// Look into Edge Cases.
        /// 
        /// Refactor each method.
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>

        public static int HighestForEachLoop(List<int> nums)
        {
            if (nums.Count < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            int highest = nums[0]; // Needs changing.

            foreach (int num in nums)
            {
                if (num > highest)
                {
                    highest = num;
                }
            }

            return highest;
        }

        public static int HighestForLoop(List<int> nums)
        {
            if (nums.Count < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            int highest = nums[0];

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
            }

            return highest;
        }

        public static int HighestWhileLoop(List<int> nums)
        {
            if (nums.Count < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            int highest = nums[0];

            int counter = 0;

            while (counter < nums.Count)
            {
                if (nums[counter] > highest)
                {
                    highest = nums[counter];
                }

                counter++;
            }

            return highest;
        }

        public static int HighestDoWhileLoop(List<int> nums)
        {
            if (nums.Count < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            int highest = nums[0];

            int counter = 0;

            do
            {
                if (nums[counter] > highest)
                {
                    highest = nums[counter];
                }

                counter++;
            }
            while (counter < nums.Count);

            return highest;
        }
    }
}
