﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    internal class Program
    {
        //•	Задача 11: Напишите программу, которая проверяет, является ли год високосным.
        public static string year;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            year = Console.ReadLine();
            int num = int.Parse(year);
            if(num % 4 == 0 && num % 100 != 0 || num % 400 == 0)
            {
                Console.WriteLine(num + " Этот год високосный");
                return;
            }
            Console.WriteLine(num + " Этот год НЕ високосный");

        }
    }
}
