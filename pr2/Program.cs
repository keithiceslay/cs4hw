// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
int sum = 0;
int num = number;
for (int i = 0; i<numberStr.Length; i++)
{
    sum = sum + num%10;
    num = num/10;
}
Console.WriteLine(sum);