// See https://aka.ms/new-console-template for more information
using System;

public class zadanie1
{
    public static void Main(string[] args)
    {
        int a, b, c;

        a = (int)inputValue();
        b = (int)inputValue();
        c = (int)inputValue();
        int sredniaArytmetyczna;

        sredniaArytmetyczna = (int)((double)(a + b + c) / 2);
        Console.WriteLine(sredniaArytmetyczna);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

