// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArr(int n)
{
    Random random = new Random();
    double[] array = new double[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
double GetMinMax(double[] arr)
{ 
    double max = arr[0];  
    double min = arr[0]; 
    for (int i = 0; i < arr.Length; i++)
    {        
        if(arr[i] >= max)
        {
            max = arr[i];
        }    
    }
      for (int i = 0; i < arr.Length; i++)
    {       
        if(arr[i] <= min)
        {
            min = arr[i];
        }    
    }
    double tmp = max - min;
    return tmp;
   }

Console.Write("Введите размер массива - ");
int n = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArr(n);

PrintArray(array);
Console.WriteLine();

double tmp = GetMinMax(array);
Console.WriteLine($"Max элемент - min элемент = {tmp}");

