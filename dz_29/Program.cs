//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] mass = new int[8];
Console.Write("[");
int i = 0;
for (; i < (mass.Length - 1); i++)
{
    mass[i] = new Random().Next();
    Console.Write($"{mass[i]}, ");
}
mass[i] = new Random().Next();
Console.Write($"{mass[i]}]");