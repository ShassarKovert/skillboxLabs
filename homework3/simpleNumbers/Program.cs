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
            Console.WriteLine("Введите число: ");
            string number = Console.ReadLine();
            double newnumber = double.Parse(number);
            bool test = false;
            double left;
            int i = 2;
            while (i!=newnumber-1)
            {
                left = newnumber % i;
                if (left==0) test = true;
                i++;
            }
            if (test==true) 
            { 
                Console.WriteLine("Введенное число не простое");
            }
            else
            Console.WriteLine("Введенное число простое");
            Console.ReadKey();
        }
    }
}