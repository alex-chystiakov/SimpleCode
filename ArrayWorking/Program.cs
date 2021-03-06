using System;
using System.Linq;

namespace ArrayWorking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве:\t");
            int elementsCount = int.Parse(Console.ReadLine());
            int result = 0;

            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nВведите значение массива для индекса {i}:\t ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nВывод массива:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("\nВывод массива в обратном порядке:");
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    result += myArray[i];
                }
            }
            Console.WriteLine($"\nСумма все четных чисел равна {result}");

            int minValue = myArray.Min();
            Console.WriteLine($"Минимальное число в массиве равно {minValue}");
        }
    }
}
