using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static partial class Program
{
    static void Division(double a, double b)
    {
    //Деление
        double total = a / b;
        Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
    }

    static void Multiplication(double a, double b)
    {
    //Умножение
        double total = a * b;
        Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
    }

    static void Subtraction(double a, double b)
    {
    //Разность
        double total = a - b;
        Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
    }

    static void Sum(double a, double b)
    {
    //Cумма
        double total = a + b;
        Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
    }
}


