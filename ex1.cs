using System;
class Program
{
    static void Main()
    {
        Console.Write("длина: ");
        double length = double.Parse(Console.ReadLine());



        Console.Write("ширина: ");
        double width = double.Parse(Console.ReadLine());

        double area = length * width;
        double perimeter = 2 * (length + width);

        Console.WriteLine($"площадь: {area}");
        Console.WriteLine($"периметр: {perimeter}");
    }
}