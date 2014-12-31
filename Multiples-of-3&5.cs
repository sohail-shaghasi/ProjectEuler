
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Project_Problem1
{
    public class Program
    {
    //Problem Number 1 - Euler Project
    //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    //Find the sum of all the multiples of 3 or 5 below 1000.

       private static ProblemSolver ps = new ProblemSolver();
        static void Main(string[] args)
        {
            Console.WriteLine("What Problem would like to solve: (1)");
            string cmd = Console.ReadLine();                //Get the Input from User.
            int problemNumber;
            bool isInt = int.TryParse(cmd, out problemNumber);//convert from string to 32 bit integer.

            if (isInt)                                   //if user entered integer then
                ps.solveProblem(problemNumber);         //call the solveProblem Method in ProbleSolver Class.
            else
                Console.WriteLine("That is No Number");
            Console.ReadLine();    
        }
      
    }
}
