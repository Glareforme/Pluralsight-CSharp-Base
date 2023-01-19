﻿using System;
using System.Collections.Generic;

namespace Gragebook
{
    class Program
    {
        static Book book = new Book("Test");
        static Random random = new Random();
        static void Main(string[] args)
        {
            book.AddGrade(13.3);
            book.AddGrade(0.1);
            book.AddGrade(10.1);
            book.AddGrade(4.44);
            book.AddGrade(random.Next(1, 20));

            try
            {
                Console.WriteLine($"Hello, {args[0]}");
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine($"Hello, noname");
            }
            finally
            {
                Console.WriteLine("Start program");
            }
            book.ShowStatistics();
        }
    }
}