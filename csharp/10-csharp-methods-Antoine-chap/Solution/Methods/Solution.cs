using System;

namespace Methods
{
  public class Solution
  {
    public static int Sum(int a, int b)
    {

      return a + b;

    }

    public static string Whos(string a, string b, int c)
    {
      return $"Firstname : {a}\nLastname : {b}\nAge : {c}";
    }

    public static void SumAndProduct(int a, int b, out int sum, out int product)
    {
      sum = a + b;
      product = a * b;

    }

    public static (int quotient, int remainder) QuotientAndRemainder(int a, int b)
    {
      
      return (a / b, a % b);
    }

    public static int MethodWithDefaultValue(int x = 10)
    {
      return x * 2;
    }
  }
}
