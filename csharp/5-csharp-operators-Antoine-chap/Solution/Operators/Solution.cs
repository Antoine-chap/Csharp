using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Solution
    {
        public static string IsAdult(int age)
        {
            int majeur = 18;
    /*        if (age >= majeur){
                reponse = "You are an adult";
            } else {
                reponse = "You are an child";
            }*/          
           string reponse = age >= majeur ? "You are an adult" : "You are a child";
            return reponse;
        }
        public static string EvenOrOdd(int number)
        {
          
            string result = number % 2 == 0 ? "Even" : "Odd";
            return result;
        }
        public static int Add(int number1,int number2)
        {
            int result1 = number1 + number2;
            return result1;
            }
        public static int Max(int number1,int number2)
        {
            int result1 = number1 >= number2 ? number1 : number2;
            return result1;
            }
    }
}
