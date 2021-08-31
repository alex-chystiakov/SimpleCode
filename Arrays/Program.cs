using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[2, 3];

            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.WriteLine($"Y: {i} X: {j}");
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
