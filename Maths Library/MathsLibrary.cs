using System;
using System.Security.Cryptography;
using System.Text;
using Math = System.Math;

namespace Maths_Library
{
    public static class MathsLibrary
    {
        public const double PI = 3.141592653589793238;

        public static double Addition(double x, double y)
        {
            return x + y;
        }

        public static double Subtraction(double x, double y)
        {
            return x - y;
        }
        
        public static double Division(double x, double y)
        {
            return x / y;
        }

        public static double Multiplication(double x, double y)
        {
            return x * y;
        }

        public static double Percentage(double x, double y)
        {
            return (x * y) / 100;
        }

        public static double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }

        public static double Floor(double x)
        {
            return Math.Floor(x);
        }

        public static double Ceiling(double x)
        {
            return Math.Ceiling(x);
        }

        public static double Circumference(double x)
        {
            return Math.Pow((PI * x), 2);
        }

        public static double CalculateAreaOfASquare(double length, double width)
        {
            return length * width;
        }

        public static double CalculateAreaOfATriangle(double baseLength, double height)
        {
            return (baseLength * height) / 2;
        }

        public static bool IsEven(double x)
        {
            return (x % 2 == 0);
        }

        public static bool IsOdd(double x)
        {
            return (x % 2 == 1);
        }

        public static double[] FibonacciSequence(double startingNumber, int length)
        {
            /// <summary>
            /// Returns the next values in a fibonnaci sequence for a specified length given a starting index.
            /// </summary>

            double[] result = new double[length];
            result[1] = result[0] + result[0];
            
            for (int i = 0; i < length; i++)
            {
                if (i > 1)
                    result[i] = (result[i - 2] + result[i - 1]);
            }
            return result;
        }

        public static int GenerateRandom(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }

        public static DayOfWeek CalculateDayOfWeek(DateTime startingDate, int daysToAdd)
        {
            /// <summary>
            /// Adds the amount of days specified to a date of choice and returns the day of the week representation.
            /// </summary>

            return startingDate.AddDays(daysToAdd).DayOfWeek;
        }

        public static string ConvertToMD5(string inputString)
        {
            /// <summary>
            /// Converts an input string in its MD5 hash equivalent and returns it.
            /// </summary>

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(inputString);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}