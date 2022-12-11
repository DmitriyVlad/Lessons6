// Задача 43. Найти точку пересечения двух прямых

Console.WriteLine("Для поиска точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1 и y = k2 * x + b2,");
Console.WriteLine("необходимо указать значения b1, k1, b2 и k2.");
Console.WriteLine("");

Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine("Точка пересечения двух прямых равна: (" + x + "; " + y + ")");