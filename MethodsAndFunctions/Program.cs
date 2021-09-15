using System;

namespace MethodsAndFunctions
{
    class Program
    {
        static string StringReturn()
        {
            uint numbersOfChars;
            string valueOfChars;
            string resultString = "";

            Console.Write("Введите количество символов в строке: ");
            numbersOfChars = uint.Parse(Console.ReadLine());

            for (int i = 0; i < numbersOfChars; i++)
            {
                Console.Write("Введите символ: ");
                valueOfChars = Console.ReadLine();

                resultString = resultString + valueOfChars;
            }

            return resultString;
        }

        static void PrintString(string value) 
        {
            Console.WriteLine(value);
        }

        static void Main(string[] args)
        {
            string test = StringReturn();
            PrintString(test);
        }
    }
}

