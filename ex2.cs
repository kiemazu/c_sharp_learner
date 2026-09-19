using System;
class Program
{
    static void Main()
    {
        Console.Write("суммa в рублях: ");
        double rubles = double.Parse(Console.ReadLine());

        Console.Write("курс доллара: ");
        double exchangeRate = double.Parse(Console.ReadLine());
        double dollars = rubles / exchangeRate;
        Console.WriteLine($"cумма в долларах: {dollars:F2}"); 
    }
}