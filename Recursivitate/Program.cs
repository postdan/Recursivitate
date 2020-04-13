using System;

namespace Recursivitate
{
    public static class FunctiiRecursive
    {
        public static int FindMin(int[] vector, int n)
        {
            if (n == 1)
            {
                return vector[0]; ;
            }
            return Math.Min(vector[n - 1], FindMin(vector, n - 1));
        }

        public static int FindMax(int[] vector, int n)
        {
            if (n == 1)
            {
                return vector[0]; ;
            }
            return Math.Max(vector[n - 1], FindMax(vector, n - 1));
        }

        public static ulong Fibonacci(int n)
        {
        
        if (n <= 1)
            {
                return Convert.ToUInt64(n);
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        
        public static int ReadNumber()
        {
            bool isNumber = false;
            Console.Write("Introduceti numarul:");
            string nrText = "";
            while ((string.IsNullOrWhiteSpace(nrText)) | (isNumber == false))
            {
                nrText = Console.ReadLine();
                isNumber = int.TryParse(nrText, out int nr);
                if (isNumber)
                {
                return nr;
                }
            }
            return 0;
        }
    }

    public static class Program
    {
        static void Main(string[] args)
        {
            int []Vector = { 11, 4, 45, 66, 7, 10, 22 };
            int n = Vector.Length;
            Console.WriteLine($"Valoare minima este:{FunctiiRecursive.FindMin(Vector, n)}");
            Console.WriteLine($"Valoare maxima este:{FunctiiRecursive.FindMax(Vector, n)}");
            int m = FunctiiRecursive.ReadNumber();
            Console.WriteLine($"Sirul lui Fibonaci pentru n={m} este: {FunctiiRecursive.Fibonacci(m)}");

        }
    }
}
