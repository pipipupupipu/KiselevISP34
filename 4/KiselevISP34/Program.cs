using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KiselevISP34
{
    internal class Program
    {
        static void zadacha1()
        {
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Числа равны");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else
            {
                Console.WriteLine("Первое число меньше второго");
            }
        }
        static void zadacha2() 
        {
            Console.WriteLine("Введите число:");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num >= 5 && num <= 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
        static void zadacha3()
        {
            Console.WriteLine("Введите число:");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num == 5 || num == 10)
            {
                Console.WriteLine("Число либо равно 5, либо равно 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
        static void zadacha4()
        {
            Console.WriteLine("Введите сумму вклада:");
            double deposit = Convert.ToDouble(Console.ReadLine());
            double finalAmount;

            if (deposit < 100)
            {
                finalAmount = deposit + (deposit * 0.05);
            }
            else if (deposit >= 100 && deposit <= 200)
            {
                finalAmount = deposit + (deposit * 0.07);
            }
            else
            {
                finalAmount = deposit + (deposit * 0.10);
            }

            Console.WriteLine("Сумма вклада с процентами: " + finalAmount);
        }
        static void zadacha5()
        {
            Console.WriteLine("Введите номер операции: 1. Сложение 2. Вычитание 3. Умножение");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Сложение");
                    break;
                case 2:
                    Console.WriteLine("Вычитание");
                    break;
                case 3:
                    Console.WriteLine("Умножение");
                    break;
                default:
                    Console.WriteLine("Операция неопределена");
                    break;
            }
        }
        static void zadacha6()
        {
            Console.WriteLine("Введите сумму вклада:");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите количество месяцев:");
            int months = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < months; i++)
            {
                deposit += deposit * 0.07m;
            }

            Console.WriteLine("Конечная сумма вклада: " + deposit);
        }
        static void zadacha7()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((i * j).ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }
        static void zadacha8()
        {
            while (true)
            {
                Console.WriteLine("Введите первое число:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (num1 >= 0 && num1 <= 10 && num2 >= 0 && num2 <= 10)
                {
                    Console.WriteLine("Произведение: " + (num1 * num2));
                    break;
                }
                else
                {
                    Console.WriteLine("Введенные числа недопустимы. Введите числа в диапазоне от 0 до 10.");
                }
            }
        }
        static void zadacha9()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Нечетные числа из массива:");
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
        static void zadacha10()
        {
            string[] strings = { "apple", "banana", "cherry", "date", "elderberry" };

            Console.WriteLine("Введите строку для поиска:");
            string input = Console.ReadLine();

            bool found = false;
            foreach (string str in strings)
            {
                if (str == input)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Строка найдена!");
            }
            else
            {
                Console.WriteLine("Строка не найдена!");
            }
        }
        static void zadacha11()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine("Сумма элементов массива: " + sum);
            Console.WriteLine("Среднее арифметическое значение элементов массива: " + average);
        }
        static void Main(string[] args)
        {
        }
    }
}
