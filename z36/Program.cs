// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Создаём массив
int[] CreateArr(int n)
{
    Random random = new Random();
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = random.Next(-100, 100);
    }
    return array;
}

// Выводим массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

// Считаем сумму нечётных
int SumPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i == 0 || i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

// Получаем длину от пользователя
Console.Write("Введите размер массива - ");
int n = Convert.ToInt32(Console.ReadLine());

// Создаём массив
int[] array = CreateArr(n);

// Выводим массив
PrintArray(array);

// Производим вычисления
int sum = SumPosition(array);

// Выводим результат
Console.WriteLine($"Сумма чисел на нечётных позициях - {sum}");
