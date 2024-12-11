using System;

class AreaCalculationTask
{
    static void Main(string[] args)
    {
        Console.Write("Enter the width of the triangle: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = double.Parse(Console.ReadLine());

        double area = CalculateTriangleArea(width, height);
        Console.WriteLine($"The area of the triangle is: {area}");
    }

    static double CalculateTriangleArea(double width, double height)
    {
        return (width * height) / 2;
    }
}
