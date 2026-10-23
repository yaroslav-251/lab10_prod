// string text = "  Строки в C# неизменяемы  ";
// Console.WriteLine(text.Length);
// string clean = text.Trim();
// Console.WriteLine(clean);
// Console.WriteLine(clean[0]);
// Console.WriteLine(clean[clean.Length - 1]);
// Console.WriteLine(clean.Contains("C#"));
// Console.WriteLine(clean.Contains("c#"));
// Console.WriteLine(clean.IndexOf("C#"));
// string result = clean.Replace("неизменяемы", "удобны");
// Console.WriteLine($"8. Новая строка: {result}");
// шаг 4
// string date = "15.09.2025";
// string[] w = date.Split(".");
// Console.WriteLine(w[0]);
// Console.WriteLine(w[1]);
// Console.WriteLine(w[2]);
// шаг 5
// string line = "Иванов,25,Программист";
// string[] n = line.Split(',');
// Console.WriteLine(n.Length);
// for (int i = 0; i < n.Length; i++)
// {
//     Console.WriteLine($"{i}, n[i]");

// }
// Console.WriteLine($"{n[0]}, {n[1]} лет, {n[2]}");
//шаг 6
// string sentence = "  Сегодня   хорошая   погода  ";
// string[] n = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// Console.WriteLine(n.Length);
// foreach(string b in n)
// {
//     Console.WriteLine(b);
// }
//шаг 7
// string? text;
// do
// {
//     Console.Write("Введите строку: ");
//     text = Console.ReadLine();
// }
// while (string.IsNullOrWhiteSpace(text));
// string clean = text.Trim();
// bool containsCode = clean.ToLower().Contains("код");
// bool startsHello = clean.ToLower().StartsWith("привет");
// bool endsExclamation = clean.EndsWith("!");
// Console.WriteLine($"Содержит слово «код»: {containsCode}");
// Console.WriteLine($"Начинается с «Привет»: {startsHello}");
// Console.WriteLine($"Заканчивается на !: {endsExclamation}");
// шаг 8
// using System.Text;
// string result = "";
// for (int i = 1; i <= 5; i++)
// {
//     result += i + " ";
// }
// Console.WriteLine("Через +=: " + result);
// StringBuilder sb = new StringBuilder();

// for (int i = 1; i <= 5; i++)
// {
//     sb.Append(i);
//     sb.Append(" ");
// }

// Console.WriteLine("Через StringBuilder: " + sb.ToString());
// шаг 9
// using System.Text;
// string[] students = ["Иван", "Анна", "Пётр"];
// StringBuilder sb = new StringBuilder();
// sb.AppendLine("=== ОТЧЁТ ===");
// sb.Append("Группа: ")
//   .AppendLine("2ИС-1");

// sb.Append("Студентов: ")
//   .AppendLine(students.Length.ToString());

// for (int i = 0; i < students.Length; i++)
// {
//     sb.Append(i + 1)
//       .Append(". ")
//       .AppendLine(students[i]);
// }
// Console.WriteLine(sb.ToString());

// шаг 10
// using System.Globalization;
// CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

// string[] products = ["Хлеб", "Молоко", "Ноутбук"];
// double[] prices = [45, 89.5, 65999.99];

// Console.WriteLine($"{"№",-4}{"Товар",-15}{"Цена",10}");
// Console.WriteLine(new string('-', 29));

// for (int i = 0; i < products.Length; i++)
// {
//     Console.WriteLine($"{i + 1:D2}  {products[i],-15}{prices[i],10:N2}");
// }
// шаг 11
// double value = 0.256;
// int number = 255;
// Console.WriteLine($"{value:P0}");
// Console.WriteLine($"{number:X}");
// итоговая
using System;
using System.Globalization;
using System.Text;

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Введите количество товаров: ");

        int count;

        while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
        {
            Console.Write("Введите положительное целое число: ");
        }
        string[] names = new string[count];
        double[] prices = new double[count];
        int[] quantities = new int[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Введите товар №{i + 1} (название,цена,количество):");

            string? line = Console.ReadLine();

            string name;
            double price;
            int quantity;

            while (line == null ||
                   !TryParseItem(line, out name, out price, out quantity))
            {
                Console.WriteLine("Ошибка! Проверьте название, цену и количество.");
                Console.WriteLine("Пример правильного ввода: Хлеб,45,2");
                line = Console.ReadLine();
            }

            names[i] = name;
            prices[i] = price;
            quantities[i] = quantity;
        }
        string report = BuildReport(names, prices, quantities);

        Console.WriteLine();
        Console.WriteLine(report);
    }

    // 2. Метод разбора и проверки одной строки
    static bool TryParseItem(
        string line,
        out string name,
        out double price,
        out int quantity)
    {
        name = "";
        price = 0;
        quantity = 0;

        string[] parts = line.Split(',');

        if (parts.Length != 3)
        {
            return false;
        }

        name = parts[0].Trim();
        string priceText = parts[1].Trim();
        string quantityText = parts[2].Trim();
        if (name == "" ||
            !double.TryParse(priceText, out price) ||
            !int.TryParse(quantityText, out quantity) ||
            price < 0 ||
            quantity <= 0)
        {
            return false;
        }

        return true;
    }

    static string BuildReport(
        string[] names,
        double[] prices,
        int[] quantities)
    {
        StringBuilder sb = new StringBuilder();

        double grandTotal = 0;

        sb.AppendLine("========== ПОКУПКИ ==========");
        sb.AppendLine(
            $"{"Товар",-18}{"Кол-во",8}{"Цена",11}{"Сумма",11}");
        sb.AppendLine(new string('-', 48));

        for (int i = 0; i < names.Length; i++)
        {
            double total = prices[i] * quantities[i];

            grandTotal += total;

            sb.AppendLine(
                $"{names[i],-18}{quantities[i],8}{prices[i],11:F2}{total,11:F2}");
        }

        sb.AppendLine(new string('-', 48));
        sb.AppendLine($"{"ИТОГО:",-37}{grandTotal,11:F2}");

        return sb.ToString();
    }
}