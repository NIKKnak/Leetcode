namespace leetcode1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3 };
            int target = 4;

            TwoSum(myArray, target);
        }


        public static int[] TwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (global::System.Int32 j = 1; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }

}
