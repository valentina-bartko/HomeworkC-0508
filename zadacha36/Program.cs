// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Я понимаю задачу так: числа автоматически генерируются из диапазона
// от -100 до 100. Всего чисел в массиве 8.

int[] array = new int[8]; //создаю массив

//Заполняю и распечатываю массив
void Array (int[] Array)
{
    for (int index = 0; index < Array.Length; index++)
    {
        Array[index] = new Random().Next(-100, 101);
        Console.Write($"{Array[index]}, ");
    }
}

//Метод нахождения суммы элементов, стоящих на нечётных позициях
void Sum (int[] Array)
{
    int sum = 0;
    for (int index = 0; index < Array.Length; index++)
    {
        if (index % 2 == 1) sum += Array[index];
    }
    Console.WriteLine($"-> {sum}");
}

Array(array);
Sum(array);