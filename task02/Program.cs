// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите первое число:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberN = int.Parse(Console.ReadLine());
int SumNumber (int M, int N)
{
    if (M > N)
    {
        Console.WriteLine("Первое число больше второго, некорректное условие");
        return 0;
    }
    if (M == N)
    {
        return M;
    }
    int summ = M;
    summ = SumNumber(M+1, N) + summ;
    return summ;
}

Console.WriteLine($"Сумма натуральных элементов от {numberM} до {numberN} = {SumNumber(numberM, numberN)}");