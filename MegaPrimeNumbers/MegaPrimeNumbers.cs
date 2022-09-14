using System;
using System.Text;

namespace MegaPrimes
{
    public class MegaPrimeNumbers
    {
        /// <summary>
        /// To check if the number passed as parameter is prime
        /// </summary>
        /// <param name="num">number that need to be checked if it is prime</param>
        /// <returns>A boolean representing if the passed parameter is prime</returns>
        public bool checkIfPrime(int num)
        {
            bool isPrime = true;
            for (int j = 2; j < num; j++)
            {
                if (num % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        /// <summary>
        /// To check if the number passed as parameter is megaprime
        /// </summary>
        /// <param name="num">number that need to be checked if it is megaprime</param>
        /// <returns>A boolean representing if the passed parameter is megaprime</returns>
        public bool checkIfMegaPrime(int num)
        {
            bool isMegaPrime = false;
            while (num > 0)
            {
                int mod = num % 10;
                bool isPrime = checkIfPrime(mod);
                if (!isPrime || mod == 1)
                {
                    isMegaPrime = false;
                    break;
                }
                else
                {
                    isMegaPrime = true;
                }
                num /= 10;
            }
            return isMegaPrime;
        }

        /// <summary>
        /// Print all the megaprime numbers between 1 and the maxnumber passed as parameter
        /// </summary>
        /// <param name="maxNumber">maximum number untill which the megaprime numbers need to be printed</param>
        /// <returns>A list of integers with all the megaprime numbers till the max number passed as parameter</returns>
        public List<int> printMegaPrimeNumbers(int maxNumber)
        {
            List<int> megaPrimesList = new List<int>();
            Console.WriteLine($"Mega Prime Numbers from 1 to {maxNumber}");
            for (int i = 2; i <= maxNumber; i++)
            {
                bool isPrime = checkIfPrime(i);
                if (isPrime)
                {
                    bool isMegaPrime = checkIfMegaPrime(i);
                    if (isMegaPrime)
                    {
                        megaPrimesList.Add(i);
                    }
                }
            }

            Console.WriteLine(string.Join(",", megaPrimesList));
            Console.WriteLine("\n\nPlease enter next maximum number or type exit to quit the program:");
            return megaPrimesList;
        }
    }
}
