// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArr(int M)
{
    Random random = new Random();
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        array[i] = random.Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите размер массива: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArr(M);

PrintArray(array);

int count = CountNumber(array);
Console.WriteLine();
Console.WriteLine($"Сумма чисел больше нуля: {count}");