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
            Console.WriteLine("Введите количество карт: ");
            number = Console.ReadLine();
            int sum = 0;
            string entered;
            double newnumber = double.Parse(number);
           for (int i = 0; i<newnumber; i++)
            {
                Console.WriteLine("Введите вес карты: ");
                entered = Console.ReadLine();
                switch (entered)
                {
                    case "1": 
                        sum++;
                        break;

                        case "2": 
                        sum=sum + 2 ;
                        break;

                        case "3": 
                        sum = sum+3;
                        break;

                        case "4": 
                        sum = sum+4;
                        break;

                        case "5": 
                        sum = sum+5;
                        break;

                        case "6": 
                        sum = sum + 6;
                        break;

                        case "7": 
                        sum = sum +7;
                        break;

                        case "8": 
                        sum = sum + 8;
                        break;

                        case "9": 
                        sum = sum +9;
                        break;

                        case "10": 
                        sum = sum+10;
                        break;

                        case "J":
                        sum = sum + 10;
                        break;

                        case "Q": 
                        sum = sum + 10;
                        break;

                        case "K":
                        sum = sum + 10;
                        break;

                        case "T": 
                        sum = sum + 10;
                        break;
                }
            }
            Console.WriteLine("Сумма ваших карт: "+sum);
            Console.ReadKey();
        }
    }

}