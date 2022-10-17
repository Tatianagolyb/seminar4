// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16
int GetPow(int A, int B)
{
    int pow = 1;
    for (int i = 0; i < B; i++)
    {
        pow = pow * A;
    }
    return pow;
}

Console.WriteLine("Введите первое число: ");
int a= int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetPow(a, b));
