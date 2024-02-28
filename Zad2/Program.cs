// Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.
// Начальные условия:
// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
// Выводится: 6

int[] array = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };
Console.Write("Массив: ");
    foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        int countEvenNumbers = 0;
    foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                countEvenNumbers++;
            }
        }
        Console.WriteLine("Количество чётных чисел в массиве: " + countEvenNumbers);

