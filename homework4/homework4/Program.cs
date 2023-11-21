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
            string linesStr= Console.ReadLine();
            int lines = int.Parse(linesStr);
            Console.WriteLine("Введите количество столбцов матрицы: ");
            string columnsStr = Console.ReadLine();
            int columns = int.Parse(columnsStr);
            Random random = new Random();
            int[,] matrix = new int[lines, columns];
            int sum = 0;
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns;j++)
                {
                    matrix[i,j] = random.Next(10); 
                    sum = sum + matrix[i,j];
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма всех элементов: " + sum);
            Console.ReadKey();
        }
    }
}
