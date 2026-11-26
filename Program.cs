// using System.Collections.Generic;
// class Program
// {
//     static void Main()
//     {
//         Dictionary<string, int> scores = new Dictionary<string, int>
//         {
//             { "Анна", 90 },
//             { "Иван", 75 },
//             { "Олег", 82 },
//             { "Мария", 95},
//             { "Пётр", 82}
//         };

//         Console.WriteLine($"Оценка Анны: {scores["Анна"]}");
//         Console.WriteLine($"Оценка Ивана: {scores["Иван"]}");
//         Console.WriteLine($"Оценка Марии: {scores["Мария"]}");
//         Console.WriteLine($"Оценка Петра: {scores["Пётр"]}");
//         Console.WriteLine($"Количество записей: {scores.Count}");
//     }
// }

// using System.Collections.Generic;
// Console.WriteLine("шаг 3");
// class Program
// {
//     static void Main()
//     {
//         Dictionary<string, int> scores = new Dictionary<string, int>
//         {
//             { "Анна", 90 },
//             { "Иван", 75 },
//             { "Олег", 82 }
//         };

//         scores.Add("Мария", 95);

//         Console.WriteLine("После добавления Марии:");
//         Console.WriteLine($"Оценка Марии: {scores["Мария"]}");

//         scores["Иван"] = 88;

//         Console.WriteLine("После изменения оценки Ивана:");
//         Console.WriteLine($"Оценка Ивана: {scores["Иван"]}");

//         Console.WriteLine($"Количество записей: {scores.Count}");
//     }
// }

// Dictionary<string, int> stock = new Dictionary<string, int>
// {
//     { "Хлеб", 12 },
//     { "Молоко", 8 },
//     { "Сыр", 5 }
// };
// stock.Add("Яблоки", 20);
// stock["Молоко"] = 15;
// Console.WriteLine($"Хлеб: {stock["Хлеб"]}");
// Console.WriteLine($"Молоко: {stock["Молоко"]}");
// Console.WriteLine($"Сыр: {stock["Сыр"]}");
// Console.WriteLine($"Яблоки: {stock["Яблоки"]}");
// Console.WriteLine($"Всего записей: {stock.Count}");

// using System.Collections.Generic;

//Console.WriteLine("Шаг 4");
// class Program
// {
//     static void Main()
//     {
//         Dictionary<string, int> scores = new Dictionary<string, int>
//         {
//             { "Анна", 90 },
//             { "Иван", 75 },
//             { "Олег", 82 }
//         };

//         string name = "Анна";

//         if (scores.ContainsKey(name))
//         {
//             Console.WriteLine($"Оценка: {scores[name]}");
//         }
//         else
//         {
//             Console.WriteLine("Студент не найден");
//         }
//     }
// }

// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Dictionary<string, int> scores = new Dictionary<string, int>
//         {
//             { "Анна", 90 },
//             { "Иван", 75 },
//             { "Олег", 82 }
//         };

//         string name = "Пётр";

//         if (scores.ContainsKey(name))
//         {
//             Console.WriteLine($"Оценка: {scores[name]}");
//         }
//         else
//         {
//             Console.WriteLine("Студент не найден");
//         }
//     }
// }

// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Dictionary<string, int> scores = new Dictionary<string, int>
//         {
//             { "Анна", 90 },
//             { "Иван", 75 },
//             { "Олег", 82 }
//         };

//         string name = "Олег";

//         if (scores.ContainsKey(name))
//         {
//             Console.WriteLine($"Оценка: {scores[name]}");
//         }
//         else
//         {
//             Console.WriteLine("Студент не найден");
//         }
//     }
// }

// Console.WriteLine("Шаг 5");
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Dictionary<string, int> scores = new Dictionary<string, int>
//         {
//             { "Анна", 90 },
//             { "Иван", 75 },
//             { "Олег", 82 },
//             { "Мария", 95 }
//         };

//         foreach (KeyValuePair<string, int> pair in scores)
//         {
//             Console.WriteLine($"{pair.Key}: {pair.Value}");
//         }
//     }
// }

Dictionary<string, int> products = new Dictionary<string, int>
{
    { "Хлеб", 12 },
    { "Молоко", 8 },
    { "Сыр", 5 },
    { "Яблоки", 20 }
};
products.Add("Колбаса", 10);
foreach (KeyValuePair<string, int> pair in products){
    Console.WriteLine($"{pair.Key}: {pair.Value}");
};
