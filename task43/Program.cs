// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// k1 = 5,  b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5)

double[] CrossPoint( double k1, double b1, double k2, double b2)
{
    double[] array = new double[2];
    array[0] = (b2-b1)/(k1-k2);
    array[1] = k1 * array[0] + b1;

    System.Console.Write($"Точка пересечения: ({string.Join(", ", array)})");
    return array;
}

System.Console.WriteLine("Точка пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");

System.Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

CrossPoint(k1, b1, k2, b2);