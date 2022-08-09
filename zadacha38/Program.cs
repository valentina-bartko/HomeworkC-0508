// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3, 7, 22, 2, 78] -> 76

// Я понимаю задачу так: массив состоит из 5 элементов, числа генерируются автоматически
// из диапазона от 1 до 100.

float[] array = new float[5]; // создаю массив вещественных чисел


// метод заполнения и печати массива
void Array(float[] Array)
{
    int index = 0;
    while (index < Array.Length)
    {
        Array[index] = new Random().Next(1, 101);
        Console.Write($"{Array[index]}, ");
        index++;
    }
}

// метод нахождения максимума и минимума, и разницы между ними
void MaxMin(float[] Array)
{
    float res = 0;
    int index = 0;
    float max = Array[index];
    float min = Array[index];
    index++;
    while (index < Array.Length)
    {
        if (Array[index] > max)
        {
            max = Array[index];
        }
        if (Array[index] < min)
        {
            min = Array[index];
        }
        index++;
    }
    res = max - min;
    Console.WriteLine($"-> {res}");
}

Array(array);
MaxMin(array);