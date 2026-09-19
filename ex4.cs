using System;
class Program
{
    static void Main()
    {
        int studentsCount = 3;
        int gradesCount = 5;
        for (int i = 1; i <= studentsCount; i++ )
        {
            double sum = 0;
            Console.WriteLine($"\nоценка {i}-го студента:");
            for (int j = 1; j <= gradesCount; j++)
            {
                Console.Write($"  оценка {j}: ");
                sum += double.Parse(Console.ReadLine());
            }

            double avg = sum / gradesCount;
            Console.WriteLine($"средняя оценка студента {i}: {avg:F2}");
        }
    }
}