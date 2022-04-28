//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNum(int N)
{
    int i = 1;
    int sum = 0;
    while (N > 10)
    {
        sum += N % 10;
        N = N / 10;
        i++;
    }
    sum += N % 10;
    return sum;
}

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(SumNum(N));