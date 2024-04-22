using System;
public class Triangle
{
    public double X1 { get; }
    public double Y1 { get; }
    public double X2 { get; }
    public double Y2 { get; }
    public double X3 { get; }
    public double Y3 { get; }

    public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
        X3 = x3;
        Y3 = y3;
    }

    public double Distance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    public double Perimeter()
    {
        double side1 = Distance(X1, Y1, X2, Y2);
        double side2 = Distance(X2, Y2, X3, Y3);
        double side3 = Distance(X3, Y3, X1, Y1);

        return side1 + side2 + side3;
    }

    public double Area()
    {
        double side1 = Distance(X1, Y1, X2, Y2);
        double side2 = Distance(X2, Y2, X3, Y3);
        double side3 = Distance(X3, Y3, X1, Y1);
        double s = (side1 + side2 + side3) / 2;

        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Вхідні дані
        double x1 = 0, y1 = 0, x2 = 0, y2 = 3, x3 = 4, y3 = 0;

        Triangle triangle = new Triangle(x1, y1, x2, y2, x3, y3);

        // Вивід результатів
        Console.WriteLine($"Периметр трикутника: {triangle.Perimeter()}");
        Console.WriteLine($"Площа трикутника: {triangle.Area()}");

        // Модульний тест
        RunTests();
    }

    static void RunTests()
    {
        // Тестовий приклад
        double x1 = 0, y1 = 0, x2 = 0, y2 = 3, x3 = 4, y3 = 0;
        Triangle triangle = new Triangle(x1, y1, x2, y2, x3, y3);
        double expectedPerimeter = 12;
        double expectedArea = 6;

        double actualPerimeter = triangle.Perimeter();
        double actualArea = triangle.Area();

        // Перевірка результатів
        Console.WriteLine("Модульний тест:");
        Console.WriteLine($"Очікуваний периметр: {expectedPerimeter}, Отриманий периметр: {actualPerimeter}");
        Console.WriteLine($"Очікувана площа: {expectedArea}, Отримана площа: {actualArea}");
    }
}
