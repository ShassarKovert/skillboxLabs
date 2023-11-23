using System.IO;
using System;
using System.Text;

namespace homework6
{
    internal class Program
    {
        static void Reading(string path)
        {
            using (StreamReader  sw = new StreamReader(path, Encoding.Unicode))
            {
                string line;
                Console.WriteLine($"\n{" ID: ", 10} {" Дата и время записи: ", 20} {"ФИО: ",22}{"Возраст: ", 11}{"Рост: ", 10}{"Дата рождения: ", 17}{"Место рождения: ", 22}");

                while ((line = sw.ReadLine()) !=null)
                {
                    string[] data = line.Split('\t');
                    Console.WriteLine($"{data[0], 10} {data[1], 20} {data[2], 22} {data[3], 11} {data[4], 9} {data[5], 15} {data[6], 22}");
                }
            }
        }

        static void Writing(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.Unicode))
            {
                char key = 'д';

                do
                {
                    string note = string.Empty;
                    Console.Write("\nВведите ID: ");
                    note += $"{Console.ReadLine()}\t";

                    string now = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                    Console.Write($" Дата и время добавления записи: {now}\n");
                    note += $"{now}\t";

                    Console.Write("Введите ФИО:");
                    note += $"{Console.ReadLine()}\t";

                    Console.Write("Введите возраст:");
                    note += $"{Console.ReadLine()}\t";

                    Console.Write("Введите рост:");
                    note += $"{Console.ReadLine()}\t";

                    Console.Write("Введите дату рождения:");
                    note += $"{Console.ReadLine()}\t";

                    Console.Write("Введите место рождения:");
                    note += $"{Console.ReadLine()}\t";
                    sw.WriteLine(note);
                    Console.Write("Продолжить н/д: ");
                    key = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(key) == 'д');
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1, если хотите добавить запись в файл. Введите 2, если хотите просмотреть записи в файле: ");
            string ans = Console.ReadLine();
            if (ans == "1")
            Writing("test.txt");//или добавить фигурные скобки и сделать просмотр после изменений
            else
            Reading("test.txt");
            Console.ReadKey();
        }
    }
}