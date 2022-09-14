using System;
using MegaPrimes;

public class Program
{
    public static void Main()
    {
        int maxNumber = default(int);
        MegaPrimeNumbers megaPrimeNumbers = new MegaPrimeNumbers();
        Console.WriteLine("Please enter maximum number:");        
        try
        {
            while (true)
            {
                string? rawData = Console.ReadLine();
                if (rawData.ToLower().Trim() == "exit")
                {
                    break;
                }
                else if (!int.TryParse(rawData, out maxNumber))
                {
                    Console.WriteLine("Please enter valid number");
                }
                else
                {
                    if (maxNumber > 0)
                    {
                        megaPrimeNumbers.printMegaPrimeNumbers(maxNumber);
                    }
                    else
                    {
                        Console.WriteLine("Please enter number greater than Zero");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occured :{ex.Message} \n Details: {ex.InnerException}");
        }

    }
}