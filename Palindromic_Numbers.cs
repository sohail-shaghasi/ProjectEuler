using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections;


namespace Palidrome_largestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int bigPalindrome = largestPalindrome(100, 1000);
            Console.WriteLine(bigPalindrome.ToString());
        }
        public static int largestPalindrome(int smallNumber, int largeNumber)
        {
            int result = 0;

            for (int i = smallNumber; i < largeNumber; i++)
            {
                for (int k = smallNumber; k < largeNumber; k++)
                {
                    int product = i * k;
                    if (IsPalindrome(product) && product > result)
                    {
                        result = product;
                    }
                }
            }
            return result;
        }

        private static bool IsPalindrome(int product)
        {
            throw new NotImplementedException();
        }
    }
}
