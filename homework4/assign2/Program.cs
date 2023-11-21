using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace another_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы: ");
            string linesStr = Console.ReadLine();
            int lines = int.Parse(linesStr);
            Console.WriteLine("Введите количество столбцов матрицы: ");
            string columnsStr = Console.ReadLine();
            int columns = int.Parse(columnsStr);
            Random random = new Random();
            int[,] matrix = new int[lines, columns];
            int[,] matrix2 = new int[lines, columns];
            Console.WriteLine("Первый сгенерированный массив: ");
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(10);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Второе сгенерированный массив: ");
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix2[i, j] = random.Next(10);
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine();
            }
            int[, ] matrixsum= new int[lines, columns];
            Console.WriteLine("Сумма получившихся массивов: ");
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixsum[i, j] = matrix[i,j]+matrix2[i,j];
                    Console.Write($"{matrixsum[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
