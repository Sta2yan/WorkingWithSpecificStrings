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
            int rowsArray = 0;
            int secondRowArray = 1;
            int columnsArray = 1;
            int firstColumnArray = 0;
            int sumNumbersSecondRowArray = 0;
            int multiplicationNumbersFirstRowArray = 1;

            for (int currentRow = 0; currentRow < numbers.GetLength(rowsArray); currentRow++)
            {
                for (int currentColumn = 0; currentColumn < numbers.GetLength(columnsArray); currentColumn++)
                {
                    numbers[currentRow, currentColumn] = random.Next(1, 10);
                }
            }

            Console.WriteLine("-----------------");

            for (int currentRow = 0; currentRow < numbers.GetLength(rowsArray); currentRow++)
            {
                for (int currentColumn = 0; currentColumn < numbers.GetLength(columnsArray); currentColumn++)
                {
                    Console.Write(" | " + numbers[currentRow, currentColumn]);
                }
                Console.WriteLine(" | ");
            }

            Console.WriteLine("-----------------");

            for (int currentColumn = 0; currentColumn < numbers.GetLength(columnsArray); currentColumn++)
            {
                sumNumbersSecondRowArray += numbers[secondRowArray, currentColumn];
            }

            for (int currentRow = 0; currentRow < numbers.GetLength(rowsArray); currentRow++)
            {
                multiplicationNumbersFirstRowArray *= numbers[currentRow, firstColumnArray];
            }

            Console.WriteLine($"\nСумма второй строки: {sumNumbersSecondRowArray}");
            Console.WriteLine($"\nПроизведение первого столбца: {multiplicationNumbersFirstRowArray}");
        }
    }
}