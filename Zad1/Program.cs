﻿ 
// Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
// Начальные условия:
// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5

int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
int count = 0;
    foreach (int value in array)
 {
    if (value >= 10 && value <= 90)
{
    count++;
}
}
Console.WriteLine("Отрезок [10, 90]: массива 1-100" + " " + "количество цыфр" + " " + count);