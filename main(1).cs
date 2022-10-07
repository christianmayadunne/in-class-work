using System;

class Program
{
    public static void Main(string[] args)
    {
        int radius;
        double area;
        const double pi = 3.14;

        radius = 5;
        area = pi * radius * radius;
        Console.WriteLine("Area is " + area);
    }
}