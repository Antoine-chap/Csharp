using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Solution
    {
        public static void array1()
        {

            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 11);
                //Console.WriteLine(array[i]);
            }
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }

        }

        public static int Sum(int[] numbers)
        {
            // Random random = new Random();
            // int[] array = new int[10];
            // for (int i = 0; i < array.Length; i++)
            // {
            //     array[i] = random.Next(1, 11);
            // }
            int somme = numbers.Sum();
            return somme;
        }

        public static double Average(int[] numbers)
        {
            // Random random = new Random();
            // int[] array = new int[10];
            // for (int i = 0; i < array.Length; i++)
            // {
            //     array[i] = random.Next(1, 11);
            // }
            double moyenne = numbers.Average();
            return moyenne;

        }
        public static void MaxAndMin(int[] numbers, out int max, out int min)
        {
            max = numbers.Max();
            min = numbers.Min();
        }

        public static int[] SortAndArray(int[] array)
        {

            Array.Sort(array);
            for (int i = 0; i < array.Length; i++){
                Console.WriteLine(array[i]);
            }
            return array;
        }

        public static string Palindrome(int[] array1){
            for (int i = 0; i < array1.Length /*/2*/ ; i++){
                if (array1[i] == array1[array1.Length -1 -i]){
                    continue;
                } else {
                    return "The array is not a palindrome";
                }
            }
            return "The array is a palindrome";
        }
    }
}
