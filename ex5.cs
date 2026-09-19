using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("введите 9 чисел через пробел для матрицы 3x3:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int[,] matrix1 = new int[3, 3];
        int k = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix1[i, j] = int.Parse(numbers[k]);
                k++;
            }
        }
        int[,] matrix2 = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix2[j, i] = matrix1[i, j];
            }
        }
        Console.WriteLine("\nБыло:       Стало:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix1[i, j] + " ");
            }
            Console.Write("  >  ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix2[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}