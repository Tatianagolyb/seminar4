// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Введите 8 чисел: ");
int n= int.Parse(Console.ReadLine()!);

static void Main(string[] args)
    {
        int[] A = new int[8];
        int[] B = new int[8];
        int[] C = new int[8];
        int b = 0, c = 0;
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write("A[{0}] = ", i);
            A[i] = int.Parse(Console.ReadLine());
            if (A[i] > 0)
                B[b++] = A[i];
            else if (A[i] < 0) C[c++] = A[i];
        }
        Console.WriteLine();
        for (int i = 0; i < b; i++) Console.WriteLine("B[{0}] = " + B[i], i);
        Console.WriteLine();
        for (int i = 0; i < c; i++) Console.WriteLine("C[{0}] = " + C[i], i);
         Console.WriteLine(Main);
        
     }

