// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите изначальное число и степень которого вы хотите получить");
int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());
Console.WriteLine(Math.Pow(number, power));