using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {

        //public int factorial(int num)
        //{
        //    int result;
        //    if (num == 1)
        //        result = 1;
        //    else
                
        //    result = factorial(num - 1) * num;
            
        //    return result;

        //}


        static void Main(string[] args)
        {
           //Program a = new Program();

           //Console.WriteLine("Factorial of 6 is: {0}", a.factorial(6));
           //Console.WriteLine("Factorial of 7 is: {0}", a.factorial(7));
           //Console.WriteLine("Factorial of 10 is: {0}", a.factorial(10));

            Console.WriteLine("Enter an integer to get its factorial.");
            int n =10;
            
            int factorial = 1;


            for (int i = 1; i <= n; i++ )
            {
                int fact = factorial *= i;

                Console.WriteLine("Factorial of {0} is {1} : ", i, fact);

                
            }

            Console.ReadLine();
        }

    }
}
