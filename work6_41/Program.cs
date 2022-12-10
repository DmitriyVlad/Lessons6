// Задача 41. Подсчитать кол-во чисел больше 0

Console.Write("Сколько чисел Вы хотите ввести? ");
int n = int.Parse(Console.ReadLine());
int i = 0;
int s = 0;
while (i < n)
{
    Console.WriteLine("Введите " + (i + 1) + " число: ");
    int a = int.Parse(Console.ReadLine());
    if (a > 0)
    {
        i++;
        s++;
    }
    else
        i++;
}

Console.WriteLine("Количество чисел больше 0: " + s);
