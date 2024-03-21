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

            int[] numbers = { 1, 2, 3 };
            int max = FindMax(numbers);
            Console.WriteLine("Max: " + max);
        }
        static int FindMax(int[] array)
        {
            int max = array[0];

            for (int i = 0; i < array.Length; i++){
                if (array[i] > max){
                    max = array[i];
                }
            }
            return max;
        }


    }
}
