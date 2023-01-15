// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void PaliTest(int num) 
// {
//     int num1 = num / 10000; 
//     int num2 = num / 1000 % 10;
//     int num4 = num % 100 / 10; 
//     int num5 = num % 10; 
//     if (num1 >=10) Console.WriteLine("Ошибка проверьте вводимое число");
//     else if (num1 == num5 && num2 == num4) Console.WriteLine("Да. Число " + num + " является палиндромом!"); //сравнение и вывод
//     else Console.WriteLine("Нет. Число " + num + " не является палиндромом!");
// }
// try
// {
//     Console.WriteLine("Введите пятизначное число для проверки:");
//     int num = Convert.ToInt32(Console.ReadLine());
//     PaliTest(num); 
// }
// catch
// {
//     Console.WriteLine("Ошибка! Проверьте вводимое число.");
// }

// // Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53 

// using System;
// using static System.Console;
// Clear();
// Write("Enter x1: ");
// int x1 = int.Parse(ReadLine());
// Write("Enter y1: ");
// int y1 = int.Parse(ReadLine());
// Write("Enter z1: ");
// int z1 = int.Parse(ReadLine());
// Write("Enter x2: ");
// int x2 = int.Parse(ReadLine());
// Write("Enter y2: ");
// int y2 = int.Parse(ReadLine());
// Write("Enter z2: ");
// int z2 = int.Parse(ReadLine());
// int X = x1 - x2;
// int Y = y1 - y2;
// int Z = z1 - z2;
// double range = Math.Round(Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2)), 2);
// WriteLine($"Result: {range}");

// // Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// using System;
// using static System.Console;
// Clear();
// Write("Введите число: ");
// int num = int.Parse(ReadLine());
// for (int i = 1; i <= num; i++)
// {
//     WriteLine(Math.Pow(i, 3));
// }
