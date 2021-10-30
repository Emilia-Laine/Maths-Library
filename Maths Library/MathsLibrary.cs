using System;

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

        public static double CubeRoot(double x)
        {
            return Math.Cbrt(x);
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
            for (int i = 0; i < length; i++)
            {
                result[i] = (result[i] - 1) + (result[i] - 2);
            }
            return result;
        }

        public static int GenerateRandom(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
    }
}