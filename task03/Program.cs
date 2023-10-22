// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// m = 3, n = 2 -> A(m,n) = 9

Console.WriteLine("Введите первое число:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberN = int.Parse(Console.ReadLine());

int Ackerman(int m, int n)
{
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Неккоректные значения");
        return 0;
    }
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackerman(m-1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}

Console.WriteLine($"Значение функции Аккермана для параметров {numberM} и {numberN} = {Ackerman(numberM, numberN)}");