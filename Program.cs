static partial class Program
{

    public static void Main(String[] args)
    {

        double a;
        double b;
        char oper;

        Console.WriteLine("Введите первое число:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите оператор:");
        oper = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        b = Convert.ToDouble(Console.ReadLine());

        if (oper == '+')
        {
            Sum(a, b);
        }

        else if (oper == '-')
        {
            Subtraction(a, b);
        }

        else if (oper == '*')
        {
            Multiplication(a, b);
        }

        else if (oper == '/')
        {
            Division(a, b);
        }
        else
        {
            Console.WriteLine("Неизвестный оператор.");
            Console.WriteLine("aaaaaaaaaaaaa");
            Console.WriteLine("aaaaaaaaaaaaa");
            Console.WriteLine("aaaaaaaaaaaaa");
            Console.WriteLine("aaaaaaaaaaaaa");
            Console.WriteLine("aaaaaaaaaaaaa");
        }
    }
}