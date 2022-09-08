// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Даны прямые y = k1*x+b1, y = k2x+b2");
Console.WriteLine("Введите b1 - ");
bool isNumb1 = double.TryParse(Console.ReadLine(), out double b1);
if(isNumb1 == false)
{
    Console.WriteLine("Число введено неверно");
    return;
}
Console.WriteLine("Введите k1 - ");
bool isNumk1 = double.TryParse(Console.ReadLine(), out double k1);
if(isNumk1 == false)
{
    Console.WriteLine("Число введено неверно");
    return;
}
Console.WriteLine("Введите b2 - ");
bool isNumb2 = double.TryParse(Console.ReadLine(), out double b2);
if(isNumb2 == false)
{
    Console.WriteLine("Число введено неверно");
    return;
}
Console.WriteLine("Введите k2 - ");
bool isNumk2 = double.TryParse(Console.ReadLine(), out double k2);
if(isNumk2 == false)
{
    Console.WriteLine("Число введено неверно");
    return;
}
double GetTochkaX(double b1, double k1, double b2, double k2)
{
    double X = (b2 - b1) / (k1 - k2);
     
        if (k1 - k2 == 0)
        {
          Console.WriteLine("Точки пересечения нет");
           return -1; 
        }
   return X;
}
GetTochkaX(b1, k1, b2, k2);

double GetTochkaY(double b1, double k1, double b2, double k2)
{
        double Y = k1 * ((b2 - b1) / (k1 - k2)) + b1;   
        if (k1 - k2 == 0)
        {
          Console.WriteLine("Точки пересечения нет");
           return -1; 
        }
      return Y;
}
GetTochkaY(b1, k1, b2, k2);
Console.WriteLine($"Координаты точки пересечения ({GetTochkaX(b1, k1, b2, k2)};{GetTochkaY(b1, k1, b2, k2)}) ");

