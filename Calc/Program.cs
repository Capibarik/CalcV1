﻿using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int next;
            char n;
            double a, b, Sum;
            char [] mas = { '*', '/', '-', '+', '^' };
            Console.WriteLine("--------------------------Calculator--------------------------");
            Console.WriteLine("        '*' -  умножение ");
            Console.WriteLine("        '/' -  деление ");
            Console.WriteLine("        '-' -  вычетание ");
            Console.WriteLine("        '+' -  сложение ");
            Console.WriteLine("        '^' - возведение в степень");
            do
            {
                 Console.Write("Выберете один из следущих знаков для подсчета: ");
                 n = Convert.ToChar(Console.ReadLine());
            }
            while (!HaveElem(n, mas));
            
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());

            switch (n)
            {
                case '*':
                    Sum = a * b;
                    Console.WriteLine("Ваш ответ: {0}", Sum); break;
                case '/':
                    Sum = a / b;
                    Console.WriteLine("Ваш ответ: {0}", Sum); break;
                case '-':
                    Sum = a - b;
                    Console.WriteLine("Ваш ответ: {0}", Sum); break;
                case '+':
                    Sum = a + b;
                    Console.WriteLine("Ваш ответ: {0}", Sum); break;
                case '^':
                    Sum = Math.Pow(a, b);
                    Console.WriteLine("Ваш ответ: {0}", Sum); break;
            }
            Console.WriteLine();
            Console.WriteLine("Хотите вычислить еще что-то?");

            //Цикличность действия
            Console.Write("Если да нажмите 'Y' для отмены нажмите любую клавишу: ");
            next = Convert.ToChar(Console.ReadLine());
            while (next == 'Y' | next == 'y' | next == 'у')
            {

                Console.WriteLine("--------------------------Calculator--------------------------");
                Console.WriteLine("        '*' -  умножение ");
                Console.WriteLine("        '/' -  деление ");
                Console.WriteLine("        '-' -  вычетание ");
                Console.WriteLine("        '+' -  сложение ");
                Console.WriteLine("        '^' - возведение в степень");
                Console.Write("Выберете один из следущих знаков для подсчета: ");
                n = Convert.ToChar(Console.ReadLine());
                Console.Write("Введите первое число: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе число: ");
                b = Convert.ToDouble(Console.ReadLine());
                switch (n)
                {
                    case '*':
                        Sum = a * b;
                        Console.WriteLine("Ваш ответ: {0}", Sum); break;
                    case '/':
                        Sum = a / b;
                        Console.WriteLine("Ваш ответ: {0}", Sum); break;
                    case '-':
                        Sum = a - b;
                        Console.WriteLine("Ваш ответ: {0}", Sum); break;
                    case '+':
                        Sum = a + b;
                        Console.WriteLine("Ваш ответ: {0}", Sum); break;
                }
                Console.WriteLine();
                Console.WriteLine("Хотите вычислить еще что-то?");
                Console.Write("Если да нажмите 'Y' для отмены нажмите любую клавишу: ");
                next = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadKey();
        }
        static bool HaveElem(char elem, char[] mas)
        {
            bool a = false;
            foreach (char i in mas)
            {
                if (i == elem)
                {
                    a = true;
                }       
            }
            return a;
        }
    }
}
