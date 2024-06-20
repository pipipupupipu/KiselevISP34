using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Globalization;
using System.Threading;
using System.Net.Http;


namespace KiselevISP34
{
    class TemperatureConverter
    {
        static void Main()
        {
            Console.WriteLine("Выберите конвертацию: 1. Цельсий в Фаренгейт 2. Фаренгейт в Цельсий");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Введите температуру в Цельсиях:");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = CelsiusToFahrenheit(celsius);
                Console.WriteLine($"Температура в Фаренгейтах: {fahrenheit}");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Введите температуру в Фаренгейтах:");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = FahrenheitToCelsius(fahrenheit);
                Console.WriteLine($"Температура в Цельсиях: {celsius}");
            }
            else
            {
                Console.WriteLine("Неправильный выбор.");
            }
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }

    class TimeConverter
    {
        static void Main()
        {
            Console.WriteLine("Выберите конвертацию: 1. 12-часовой в 24-часовой 2. 24-часовой в 12-часовой");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Введите время в формате hh:mm tt (например, 07:45 PM):");
                string time12 = Console.ReadLine();
                DateTime dt = DateTime.ParseExact(time12, "hh:mm tt", CultureInfo.InvariantCulture);
                string time24 = dt.ToString("HH:mm");
                Console.WriteLine($"24-часовой формат: {time24}");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Введите время в формате HH:mm (например, 19:45):");
                string time24 = Console.ReadLine();
                DateTime dt = DateTime.ParseExact(time24, "HH:mm", CultureInfo.InvariantCulture);
                string time12 = dt.ToString("hh:mm tt");
                Console.WriteLine($"12-часовой формат: {time12}");
            }
            else
            {
                Console.WriteLine("Неправильный выбор.");
            }
        }
    }

    class AgeCalculator
    {
        static void Main()
        {
            Console.WriteLine("Введите дату рождения (гггг-мм-дд):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;
            int ageYears = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-ageYears)) ageYears--;

            int ageMonths = today.Month - birthDate.Month;
            if (ageMonths < 0) ageMonths += 12;

            int ageDays = today.Day - birthDate.Day;
            if (ageDays < 0)
            {
                DateTime previousMonth = today.AddMonths(-1);
                ageDays += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
            }

            Console.WriteLine($"Ваш возраст: {ageYears} лет, {ageMonths} месяцев, {ageDays} дней.");
        }
    }

    class Countdown
    {
        static void Main()
        {
            Console.WriteLine("Введите количество секунд:");
            int seconds = Convert.ToInt32(Console.ReadLine());

            for (int i = seconds; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Время вышло!");
        }
    }

    class TextAnalysis
    {
        static void Main()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            int wordCount = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int sentenceCount = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int paragraphCount = text.Split(new string[] { "\n\n", "\r\n\r\n", "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries).Length;

            Console.WriteLine($"Количество слов: {wordCount}");
            Console.WriteLine($"Количество предложений: {sentenceCount}");
            Console.WriteLine($"Количество абзацев: {paragraphCount}");
        }
    }

    class PasswordGenerator
    {
        static void Main()
        {
            Console.WriteLine("Введите длину пароля:");
            int length = Convert.ToInt32(Console.ReadLine());

            string password = GeneratePassword(length);
            Console.WriteLine($"Сгенерированный пароль: {password}");
        }

        static string GeneratePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(validChars[rnd.Next(validChars.Length)]);
            }
            return res.ToString();
        }
    }

    class CurrencyConverter
    {
        static void Main()
        {
            Console.WriteLine("Введите сумму в USD:");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите текущий курс USD к другой валюте:");
            double rate = Convert.ToDouble(Console.ReadLine());

            double convertedAmount = amount * rate;
            Console.WriteLine($"Конвертированная сумма: {convertedAmount}");
        }
    }

    class WeatherData
    {
        static void Main()
        {
            Console.WriteLine("Введите количество дней:");
            int days = Convert.ToInt32(Console.ReadLine());
            double[] temperatures = new double[days];

            for (int i = 0; i < days; i++)
            {
                Console.WriteLine($"Введите температуру для дня {i + 1}:");
                temperatures[i] = Convert.ToDouble(Console.ReadLine());
            }

            double maxTemp = temperatures[0];
            double minTemp = temperatures[0];
            double sumTemp = 0;

            foreach (double temp in temperatures)
            {
                if (temp > maxTemp)
                    maxTemp = temp;
                if (temp < minTemp)
                    minTemp = temp;
                sumTemp += temp;
            }

            double avgTemp = sumTemp / days;

            Console.WriteLine($"Максимальная температура: {maxTemp}");
            Console.WriteLine($"Минимальная температура: {minTemp}");
            Console.WriteLine($"Средняя температура: {avgTemp}");
        }
    }

    class ToDoList
    {
        static List<string> tasks = new List<string>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Добавить задачу\n2. Удалить задачу\n3. Редактировать задачу\n4. Просмотреть задачи\n5. Выйти");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        RemoveTask();
                        break;
                    case 3:
                        EditTask();
                        break;
                    case 4:
                        ViewTasks();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.WriteLine("Введите описание задачи:");
            string task = Console.ReadLine();
            tasks.Add(task);
        }

        static void RemoveTask()
        {
            Console.WriteLine("Введите номер задачи для удаления:");
            int taskNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            if (taskNumber >= 0 && taskNumber < tasks.Count)
            {
                tasks.RemoveAt(taskNumber);
            }
            else
            {
                Console.WriteLine("Неверный номер задачи.");
            }
        }

        static void EditTask()
        {
            Console.WriteLine("Введите номер задачи для редактирования:");
            int taskNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            if (taskNumber >= 0 && taskNumber < tasks.Count)
            {
                Console.WriteLine("Введите новое описание задачи:");
                tasks[taskNumber] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Неверный номер задачи.");
            }
        }

        static void ViewTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Нет задач.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }
    }

    class WeatherApiClient
    {
        static async Task Main()
        {
            Console.WriteLine("Введите город:");
            string city = Console.ReadLine();
            string apiKey = "your_api_key";  // Вставьте сюда ваш API ключ
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Данные о погоде:");
                    Console.WriteLine(data);
                }
                else
                {
                    Console.WriteLine("Ошибка при получении данных о погоде.");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
