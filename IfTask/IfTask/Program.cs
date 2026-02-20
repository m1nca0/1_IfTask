//#9 Составить программу нахождения произведения двух наименьших из трех различных чисел.
using System;

namespace IfTask
{
    public class Logic
    {
        public static int Lowest(int firstInt, int secondInt, int thirdInt)
        {
            int[] numbers = new int[] { firstInt, secondInt, thirdInt };
            Array.Sort(numbers);
            return numbers[0] * numbers[1];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int firstInt = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int secondInt = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            int thirdInt = int.Parse(Console.ReadLine());

            var lowestMultiplication = Logic.Lowest(firstInt, secondInt, thirdInt);
            Console.WriteLine("Ответ: " + lowestMultiplication);
        }
    }
}