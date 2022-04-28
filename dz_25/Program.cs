int Res(int N, int S)
{
    int r = N;
    for (int i = 2; i <= S; i++)
    {
        r *= N;
    }
    return r;
}
Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine(Res(A, B));