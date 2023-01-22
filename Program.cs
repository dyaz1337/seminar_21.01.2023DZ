// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number){
//   if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine($"{number} -> ДА");
//   }
//   else Console.WriteLine($"{number} -> НЕТ");
// }

// if (number!.Length == 5){
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координаты точки A:");
// double x = Convert.ToInt32(Console.ReadLine());
// double y = Convert.ToInt32(Console.ReadLine());
// double z = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки B:");
// double x1 = Convert.ToInt32(Console.ReadLine());
// double y1 = Convert.ToInt32(Console.ReadLine());
// double z1 = Convert.ToInt32(Console.ReadLine());

// double L = Math.Sqrt(Math.Pow((x1-x), 2) + Math.Pow((y1 - y), 2) + Math.Pow((z1 - z), 2));
// Console.WriteLine($"Длина заданного отрезка {Math.Round(L, 2)}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//   Console.Write($"{Math.Pow(i, 3)} ");
// }