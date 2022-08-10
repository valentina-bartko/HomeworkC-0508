// Задайте массив, заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Я понимаю задачу так: всего в массиве 4 числа.

// создать массив
// заполнить его
// метод подсчета четных чисел
// вывести на экран массив и количество четных чисел

int[] array = new int[4];

void Array (int[] Array)
{
    for (int index = 0; index < Array.Length; index ++)
    {
        Array[index] = new Random().Next(100, 1000);
        Console.Write($"{Array[index]}, ");
    }
}

void EvenNumbers (int[] Array)
{
    int amount = 0;
    for (int index = 0; index < Array.Length; index++)
    {
            if (Array[index] % 2 == 0) amount++;
    }
    Console.WriteLine($"-> {amount}");
}

Array(array);
EvenNumbers(array);