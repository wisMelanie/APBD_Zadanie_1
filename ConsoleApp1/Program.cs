using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Modyfikacja 1
            Console.WriteLine("Modyfikacja 1");
            // Modyfikacja 2
            int a = 2;
            Console.WriteLine("Modyfikacja " + a);
            // Modyfikacja 3
            string b = "3";
            Console.WriteLine("Modyfikacja " + b);

            int[] arr = { 1, 2, 3 };
            double average = CalcAverage(arr);
            Console.WriteLine(average);

        }

        static double CalcAverage(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            double average = sum / arr.Length;
            return average;
        }
    }
}
