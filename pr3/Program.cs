﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// пример из 5 элементов:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split();

Random rnd = new Random();
int [] array = new int[8];
for (int i = 0; i<8; i++)
{
    array[i] = rnd.Next();
}
Console.WriteLine(String.Join(", ", array));