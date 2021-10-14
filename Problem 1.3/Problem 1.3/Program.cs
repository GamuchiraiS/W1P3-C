using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int humanDogAge;
            int dogAge;
            Console.WriteLine("Please enter the dog's age (in human years):");
            humanDogAge = Convert.ToInt32(Console.ReadLine());

            //Age calculation
            if (humanDogAge < 0)
            {
                Console.WriteLine("Please enter a valid number");
            }

            else if (humanDogAge <= 2)
            {
                dogAge = humanDogAge * Convert.ToInt32(10.5);
            }

            else
            {
                dogAge = 21 + (humanDogAge - 2) * 4;
                Console.WriteLine("The dog’s age in dog years is " + dogAge);
            }

            Console.ReadLine();


        }
    }
}
