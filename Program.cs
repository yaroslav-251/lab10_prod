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
