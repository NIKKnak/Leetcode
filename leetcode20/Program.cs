namespace leetcode20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(IsValid("(){}"));
        }

        public static bool IsValid(string s)
        {

            while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            {
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }
            return s.Length == 0;
        }






    }
}
