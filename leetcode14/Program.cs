namespace leetcode14
{
    internal class Program
    {
        static void Main(string[] args)
        {




        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";

            int minLength = int.MaxValue;
            foreach (string str in strs)
            {
                minLength = Math.Min(minLength, str.Length);
            }

            for (int i = 0; i < minLength; i++)
            {
                char currentChar = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != currentChar)
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }

            return strs[0].Substring(0, minLength);
        }






    }
}
