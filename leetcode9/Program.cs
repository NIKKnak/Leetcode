namespace leetcode9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));
            Console.WriteLine(IsPalindrome(-121));
            Console.WriteLine(IsPalindrome(5));
            Console.WriteLine(IsPalindrome(10));
            Console.WriteLine(IsPalindrome(0));
            Console.WriteLine(IsPalindrome(1234567899));
        }

        public static bool IsPalindrome(int x)
        {
            try
            {
                int inputValue = x;

                if (x < 0)
                {
                    return false;
                }
                else
                {
                    int temp;
                    string revers = "0";
                    while (x > 0)
                    {
                        temp = x % 10;
                        x /= 10;
                        revers += temp;
                    }

                    if (Convert.ToInt32(revers) == inputValue)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {

                return false ;
            }

        }
    }
}


