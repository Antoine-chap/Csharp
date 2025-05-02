using System;

namespace Variables
{
    public class Solution
    {
        public static string SayHello(string name)
        {
            return $"Hello {name}";
        }
        public static float AgeToFloat(int age)
        {
            return age / 2f;
        }
        public static decimal CelciusToFarenheit(decimal celcius)
        {
            return celcius * 1.8m + 32;
        }

        public static double KilometersToMiles(int kilometers)
        {
            return Math.Round(kilometers / 1.6,1);
        }
        public static int Random10()
        {
        Random random = new Random();
        int RandomNumber = random.Next(1, 10);
        return RandomNumber;
        }
    }
}


