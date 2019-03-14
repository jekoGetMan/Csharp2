//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Diagnostics;
using System.Net;

namespace tst
{
    class Program
    {
        static void Main(string[] args)
        {
            // Стучимся в класс рандом через ссылку
            Random rnd = new Random();    
            
            Console.WriteLine("Поираем? [Y/N]" );
            Console.ReadKey();

            string input = Console.ReadLine();

            while (input == "y")
            {
                // Вызываем метод next класса rnd
                int defNum = rnd.Next(1, 101);
                int userNum = 0;

                bool loss = true;

                while (loss)
                {
                    bool isValidNum = false;
                    while (!isValidNum)
                    {
                        Console.WriteLine("Enter your guess: ");
                        input = Console.ReadLine();

                        isValidNum = Int32.TryParse(input, out userNum);

                        if (!isValidNum)
                        {
                            Console.WriteLine("That is not a Number!");
                        }
                    }

                }
            }


        }
    }
}
    