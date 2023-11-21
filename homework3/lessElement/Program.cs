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
            Console.WriteLine("Введите длину последовательности: ");
            string number = Console.ReadLine();
            double lesser=double.MaxValue;
            double newnumber = double.Parse(number);
            for (int i = 0; i<newnumber;i++)
            {
                Console.WriteLine("Введите число: ");
                string current = Console.ReadLine();
                double newcurrent = double.Parse(current);
                if (newcurrent < lesser)
                    lesser = newcurrent;
            }
            Console.WriteLine("Наименьшее число последовательности: "+ lesser);
            Console.ReadKey();
        }
    }
}