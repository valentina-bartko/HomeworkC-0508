// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3, 7, 22, 2, 78] -> 76

// Я понимаю задачу так: массив состоит из 5 элементов, числа генерируются автоматически
// из диапазона от 1 до 100.

float[] array = new float[5]; // создаю массив вещественных чисел


// метод заполнения и печати массива
void Array(float[] Array)
{
    for (int index = 0; index < Array.Length; index++)
    {
        Array[index] = new Random().Next(1, 101);
        Console.Write($"{Array[index]}, ");
    }
}

// метод нахождения максимума и минимума, и разницы между ними
void MaxMin(float[] Array)
{
    float res = 0;
    int index = 0;
    float max = Array[index];
    float min = Array[index];
    for (index = 1; index < Array.Length; index++)
    {
        if (Array[index] > max) max = Array[index];
        else
        {
            if (Array[index] < min) min = Array[index];
        }
    }
    res = max - min;
    Console.WriteLine($"-> {res}");
}

Array(array);
MaxMin(array);