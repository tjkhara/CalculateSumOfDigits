using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateSumOfDigits();
        }

        static void CalculateSumOfDigits()
        {
            int number = 0, sum = 0;
            int[] arrDigits = new int[5];
            Console.WriteLine("Please enter a 5 digit number");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = arrDigits.Length - 1; i >= 0; i--)
            {
                if (i > 0) 
                {
                    arrDigits[i] = number % 10;
                    number = number - arrDigits[i];
                    number = number / 10;
                } else if (i == 0)
                {
                    arrDigits[i] = number;
                }
                
            }

            for( int i = 0; i < 5; i++)
            {
                sum = sum + arrDigits[i];
            }

            Console.WriteLine(sum);
        }
    }
}
