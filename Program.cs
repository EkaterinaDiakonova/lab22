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

// Dictionary<string, int> products = new Dictionary<string, int>
// {
//     { "Хлеб", 12 },
//     { "Молоко", 8 },
//     { "Сыр", 5 },
//     { "Яблоки", 20 }
// };
// products.Add("Колбаса", 10);
// foreach (KeyValuePair<string, int> pair in products){
//     Console.WriteLine($"{pair.Key}: {pair.Value}");
// };

// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         HashSet<int> numbers = new HashSet<int>
//         {
//             101, 104, 107, 104, 110, 101
//         };

//         Console.WriteLine($"Количество уникальных чисел: {numbers.Count}");

//         foreach (int number in numbers)
//         {
//             Console.WriteLine(number);
//         }
//     }
// }

// HashSet<string> colors = new HashSet<string>
// {
//     "Красный",
//     "Синий",
//     "Зелёный",
//     "Синий",
//     "Красный"
// };
// Console.WriteLine($"Количество уникальных цветов: {colors.Count}");
// Console.WriteLine($"Список цветов:");
// foreach (string color in colors){
//     Console.WriteLine(color);
// }
// colors.Add("Желтый");
// Console.WriteLine($"Количество после добавления: {colors.Count}");

// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         HashSet<int> visitedRooms = new HashSet<int>();

//         visitedRooms.Add(101);
//         visitedRooms.Add(102);
//         visitedRooms.Add(103);

//         bool firstResult = visitedRooms.Add(102);
//         bool secondResult = visitedRooms.Add(104);

//         Console.WriteLine($"Повторное добавление 102: {firstResult}");
//         Console.WriteLine($"Добавление 104: {secondResult}");
//         Console.WriteLine($"Количество комнат: {visitedRooms.Count}");

//         Console.WriteLine(visitedRooms.Contains(103));
//         Console.WriteLine(visitedRooms.Contains(999));
//     }
// }

// HashSet<int> rooms = new HashSet<int> { 101, 102, 103 };

// bool addExisting = rooms.Add(102);
// bool addNew = rooms.Add(104);

// Console.WriteLine($"Попытка добавить 102 (дубликат): {addExisting}");
// Console.WriteLine($"Попытка добавить 104 (новый): {addNew}");

// Console.WriteLine($"Есть ли кабинет 101? {rooms.Contains(101)}");
// Console.WriteLine($"Есть ли кабинет 999? {rooms.Contains(999)}");

// Console.WriteLine($"Количество элементов: {rooms.Count}");

// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         HashSet<string> products = new HashSet<string>
//         {
//             "Хлеб",
//             "Молоко",
//             "Сыр",
//             "Яблоки"
//         };

//         products.Remove("Молоко");

//         Console.WriteLine($"Количество товаров: {products.Count}");

//         foreach (string product in products)
//         {
//             Console.WriteLine(product);
//         }
//     }
// }

// HashSet<int> numbers = new HashSet<int>
// {
//     5, 10, 15, 20, 25
// };
// numbers.Remove(15);
// bool removed100 = numbers.Remove(100);
// Console.WriteLine($"Количество элементов после удаления: {numbers.Count}");
// Console.WriteLine($"Есть ли число 20? {numbers.Contains(20)}");

// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         List<int> numbers = new List<int>
//         {
//             5, 10, 5, 15, 10, 20, 5
//         };

//         HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

//         Console.WriteLine($"Элементов в списке: {numbers.Count}");
//         Console.WriteLine($"Уникальных значений: {uniqueNumbers.Count}");

//         foreach (int number in uniqueNumbers)
//         {
//             Console.WriteLine(number);
//         }
//     }
// }

// List<string> names = new List<string>
// {
//     "Анна", "Иван", "Анна", "Олег", "Иван", "Мария"
// };

// HashSet<string> uniqueNames = new HashSet<string>(names);
// Console.WriteLine($"Элементов в исходном списке: {names.Count}");
// Console.WriteLine($"Уникальных имен: {uniqueNames.Count}");
// Console.WriteLine("Уникальные имена:");
// foreach (string name in uniqueNames)
// {
//     Console.WriteLine(name);
// }


// Console.WriteLine("Задача А");

// Dictionary<string, int> studentScores = new Dictionary<string, int>
// {
//     { "Анна", 90 },
//     { "Иван", 75 },
//     { "Олег", 82 }
// };
// studentScores.Add("Мария", 95);
// Console.WriteLine($"Оценка Анны: {studentScores["Анна"]}");
// Console.WriteLine($"Количество записей: {studentScores.Count}");

Console.WriteLine("Вариант 8");
List<int> numbers = new List<int>
{
    5, 10, 5, 15, 10, 20, 5
};

HashSet<int> uniqueNumbers = new HashSet<int>(numbers);
Console.WriteLine($"Количество элементов ДО удаления повторов: {numbers.Count}");
Console.WriteLine($"Количество уникальных значений ПОСЛЕ преобразования: {uniqueNumbers.Count}");
Console.Write("Уникальные значения: ");
foreach (int num in uniqueNumbers)
{
    Console.Write(num + " ");
}