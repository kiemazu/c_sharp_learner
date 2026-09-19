using System;
class Program
{
    static void Main()
    {
        double sum = 0;
        int days = 7;

        for (int i = 1; i <= days; i++)
        {
            Console.Write($"температурa за {i}-й день: ");
            sum += double.Parse(Console.ReadLine());
        }
        double avg = sum / days;
        Console.WriteLine($"cредняя температура за неделю: {avg:F2}");
    }
}