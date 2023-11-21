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
            Console.WriteLine("Введите максимальное число: ");
            string number = Console.ReadLine();
            int newnumber = int.Parse(number);
            Random randomize = new Random();
            int random = randomize.Next(newnumber+1);
            Console.WriteLine("Число загадано!");
            int ending=0;
            while (ending!=random)
            {
                Console.WriteLine("Введите предположение: ");
                string entered = Console.ReadLine();
                if (entered != "")
                {
                    ending = int.Parse(entered);
                    if (ending > random) Console.WriteLine("Загаданное число меньше");
                    if (ending < random) Console.WriteLine("Загаданное число больше");
                    if (ending == random) Console.WriteLine("Вы угадали!");
                }
                else if (entered == "")
                {
                    break;
                }
            }
            Console.WriteLine("Загаданным число являлось: " + random);
            Console.ReadKey();
        }
    }
}