using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace another_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number;
            Console.WriteLine("Введите число: ");
            number = Console.ReadLine();
            double newnumber = double.Parse(number);
            if (newnumber % 2 == 0)
            {
                Console.WriteLine("Введенное число четное");
            }
            else
            {
                Console.WriteLine("Введенное число нечетное");
            }
            Console.ReadKey();
        }
    }

}