namespace leetcode27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3,3,4,5,5,3 };
            int value = 3;

            Console.WriteLine(RemoveElement(ints, value));
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int result = 0;
            foreach (var item in nums)
            {
                if (item != val)
                {
                    nums[result] = item;
                    result++;
                }
            }

            return result;
        }







    }
}
