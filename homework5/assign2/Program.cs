using System;
using System.Text;

namespace another_test
{
    internal class Program
    {
        static string[] SplitText(string text)
        {
            var delimeter = ' ';
            return text.Split(delimeter);
        }

        static void Print(string[] args)
        { 
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
        }

        static void Main(string[] args)
        {
           Console.WriteLine("Введите строку: ");
           string String = Console.ReadLine();
           Print(SplitText(String));
        }
    }
}
