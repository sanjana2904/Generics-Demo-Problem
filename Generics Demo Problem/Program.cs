using Generics_Demo;
using System;

namespace GenericsDemo
{
    public class Program1
    {
        static void Main()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            Console.WriteLine("----------------------------");
            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();
            Console.ReadKey();
        }
    }
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    int[] intArray = { 1, 2, 3, 4, 5 };
        //    double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
        //    char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
        //    //Program.toPrint(intArray);
        //    //Program.toPrint(doubleArray);
        //    //Program.toPrint(charArray);

        //    Program.toPrint<int>(intArray);
        //    Program.toPrint<double>(doubleArray);
        //    Program.toPrint<char>(charArray);
        //    Console.ReadKey();
        //    }

        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------------------");
        }

        //public static void toPrint(int[] inputArray)
        //{
        //    foreach (double element in inputArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //    Console.WriteLine("----------------------------------");
        //}

        //public static void toPrint(double[] inputArray)
        //{
        //    foreach (double element in inputArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //    Console.WriteLine("----------------------------------");
        //}

        //public static void toPrint(char[] inputArray)
        //{
        //    foreach (char element in inputArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //    Console.WriteLine("-------------------------------------");
        //}
    }
}