// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


const uint n = 1;
const uint m = 9;
void OutNumber(uint n, uint m)
{
    if(n >= m)
    {
        Console.Write($"{n} ");
        return;
    }
    OutNumber(n+1, m);
    Console.Write($"{n} ");
    return;
}
OutNumber(n, m);
Console.WriteLine();