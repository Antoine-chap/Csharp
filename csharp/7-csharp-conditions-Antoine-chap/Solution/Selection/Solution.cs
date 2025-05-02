using System;

namespace Selection
{
    public class Solution
    {
        public static string CanEnterInTheCasino()
        {
            try
            {
                Console.WriteLine("Hello, what is your age?");
                int age = int.Parse(Console.ReadLine());
                const int majeur = 18;
                if (age >= majeur)
                {
                    return "You can enter! Be welcome!";
                }
                else
                {
                    return "Sorry, you can't enter! Be patient!";
                }
            }
            catch (FormatException e)
            {
                return $"Exception: {e.Message}";
            }
            catch (Exception e)
            {
                return $"Something went wrong: {e}";
            }
        }

        public static int GetValidatedAge(string input)
        {
            if (!int.TryParse(input, out int age) || age > 100)
            {
                throw new FormatException("Invalid Age");
            }
            return age;
        }
        public static string SignOfNumber(int number)
        {
            if (number == 0)
            {
                return "The number is zero.";
            }
            else if (number > 0)
            {
                return "The number is positive.";
            }
            else
            {
                return "The number is negative.";
            }
        }
        public static double DiscountPriceCalculator(int typeReduction, double prixInitial)
        {
            if (prixInitial < 0)
            {
                throw new ArgumentException("Le prix initial ne peut pas être négatif.", nameof(prixInitial));
            }

            if (typeReduction < 1 || typeReduction > 3)
            {
                throw new ArgumentException("Invalid choice. Please enter a number between 1 and 3.");
            }

            double tauxMember = 0.05;
            double tauxStudent = 0.10;
            double tauxSolde = 0.20;
            double prixFinal;
            if (typeReduction == 2)
            {
                prixFinal = prixInitial * (1 - tauxMember);
                return prixFinal;
            }
            else if (typeReduction == 1)
            {
                prixFinal = prixInitial * (1 - tauxStudent);
                return prixFinal;
            }
            else
            {
                prixFinal = prixInitial * (1 - tauxSolde);
                return prixFinal;
            }

        }
        public static string TriangleClassification(int aSize, int bSize, int cSize)
        {
            if (aSize == bSize && bSize == cSize){
                return "The triangle is equilateral.";
            } else if (aSize == bSize || bSize == cSize || aSize == cSize){
                return "The triangle is isosceles.";
            }else {
                return "The triangle is scalene.";
            }
        }
    }
}