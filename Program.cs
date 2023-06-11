// Задача 10
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите трехзначное число: ");
//         int number = int.Parse(Console.ReadLine());

//         if (number < 100 || number > 999)
//         {
//             Console.WriteLine("Ошибка: число должно быть трехзначным");
//         }
//         else
//         {
//             int secondDigit = (number / 10) % 10;
//             Console.WriteLine("Вторая цифра: " + secondDigit);
//         }
//     }
// }

// // Задача 13
// using System;

// class Program {
//   static void Main(string[] args) {
//     int number =int.Parse(Console.ReadLine());

//     if (number > 99 && number < 1000) {  // проверяем, есть ли у числа 3 цифры
//       int thirdDigit = (number / 100) % 10; // вычисляем третью цифру

//       Console.WriteLine($"Третья цифра числа {number}: {thirdDigit}");
//     } else {
//       Console.WriteLine($"У числа {number} нет третьей цифры.");
//     }
//   }
// }

// Задача 15
// using System;

// class Programm
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите день недели (цифру): ");
//         int dayOfWeek = int.Parse(Console.ReadLine());

//         if (dayOfWeek == 6 || dayOfWeek == 7)
//         {
//             Console.WriteLine("Выходной день");
//         }
//         else
//         {
//             Console.WriteLine("Рабочий день");
//         }

//         Console.ReadLine();
//     }
// }