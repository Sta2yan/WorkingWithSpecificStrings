using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithSpecificStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] numbers = new int[3, 3];
            int rowArray = 0;
            int secondRowArray = 1;
            int columnArray = 1;
            int firstColumnArray = 0;
            int sumSecondRowArray = 0;
            int multiplicationFirsRowArray = 1;

            for (int row = 0; row < numbers.GetLength(rowArray); row++)
            {
                for (int column = 0; column < numbers.GetLength(columnArray); column++)
                {
                    numbers[row, column] = random.Next(1, 10);
                }
            }

            Console.WriteLine("-----------------");

            for (int row = 0; row < numbers.GetLength(rowArray); row++)
            {
                for (int column = 0; column < numbers.GetLength(columnArray); column++)
                {
                    Console.Write(" | " + numbers[row, column]);
                }
                Console.WriteLine(" | ");
            }

            Console.WriteLine("-----------------");

            for (int column = 0; column < numbers.GetLength(columnArray); column++)
            {
                sumSecondRowArray += numbers[secondRowArray, column];
            }

            for (int row = 0; row < numbers.GetLength(rowArray); row++)
            {
                multiplicationFirsRowArray *= numbers[row, firstColumnArray];
            }

            Console.WriteLine($"\nСумма второй строки: {sumSecondRowArray}");
            Console.WriteLine($"\nПроизведение первого столбца: {multiplicationFirsRowArray}");
        }
    }
}