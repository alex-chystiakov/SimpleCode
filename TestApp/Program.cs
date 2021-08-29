using System;
using System.Linq;


namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray;
            myArray = new int[4, 5]
            {
                { 2, 45, 10, 67, 90 },
                { 67, 17, 19, 98, 34 },
                { 44, 22, 20, 21, 4 },
                { 11, 9, 5, 13, 16 }
            };
            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(myArray[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}

