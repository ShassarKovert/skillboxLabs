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
        static void Reverse(string getString)
        {
            string[] Splitted = SplitText(getString);
            string ResultString="", NewString;
                for (int i = Splitted.Length - 1; i >= 0; i--)
            {
                NewString = Splitted[i];
                ResultString += NewString + " ";
            }
                Console.WriteLine(ResultString);
        }

        static void Main(string[] args)
        {
           Console.WriteLine("Введите строку: ");
           string String = Console.ReadLine();
           Reverse(String);
        }
    }
}
