// See https://aka.ms/new-console-template for more information
using System.Linq;


Console.WriteLine("Hello, World!");
Console.WriteLine("Hello 2");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static double GetAverage(int[] numbers)
{
    int sumx = 0;
    foreach (var number in numbers)
    {
        sumx += number;
    }

    return (double) sumx / numbers.Length;
}

int[] numbers = {1, 2, 3, 4};
double average = GetAverage(numbers);
Console.WriteLine(average);

static int GetMaxValue(int[] numbers)
{
    return numbers.Max();
}