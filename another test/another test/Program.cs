﻿using System;
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
            string fullName = "His Full Name";
            byte age = 17;
            string email = "hisemail@example.com";
            float programmingRes = 68;
            float physicsRes = 55;
            float mathRes = 74;
            float sumRes, midAr;

            sumRes = programmingRes + physicsRes + mathRes;
            midAr = sumRes / 3;
            Console.WriteLine($"ФИО: {fullName} " +
                $"\nВозраст: {age} " +
                $"\nЭлектронная почта: {email} " +
                $"\nБаллы про программированию: {programmingRes} " +
                $"\nБаллы по математике: {mathRes} " +
                $"\nБаллы по физике: {physicsRes}");
            Console.ReadKey();
            Console.WriteLine(
                $"Сумма баллов: {sumRes}" +
                $"\nСреднее арифметическое всех балов: {midAr}");
            Console.ReadKey();
        }
    }
}
