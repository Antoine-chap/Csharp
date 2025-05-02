using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    public class Solution
    {
        public static int SumOfNumbers()
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Donne un nombre entier et positif.");
            }
            else
            {
                int result = 1;
                while (number >= 1)
                {
                    result = result * number;
                    number--;
                }
                return result;
            }
        }
        public static void multiplication()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }
        public static void goodNumber()
        {
            bool flag = false;
            do
            {
                Console.WriteLine("Please, enter a number between 1 and 10");
                string? number = Console.ReadLine();
                flag = int.TryParse(number, out int numberInsert) && numberInsert >= 1 && numberInsert <= 10;
            } while (!flag);
        }
        public static int small()
        {
            int number = 1;
            int min = int.MaxValue;
            while (number != 0)
            {
                Console.WriteLine("Rentre un nombre.");
                try
                {
                    number = int.Parse(Console.ReadLine());
                    min = number < min && number != 0 ? number : min;
                }
                catch (Exception)
                {
                    Console.WriteLine("Rentre que des nombres.");
                
}
            }
            return min;
        }

    }


}
