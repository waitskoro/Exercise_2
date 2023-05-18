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
<<<<<<< HEAD
=======


            Console.WriteLine("aaaaaaaaaaaaa");
            Console.WriteLine("aaaaaaaaaaaaa");
>>>>>>> ee2de5f188d825b460d33d8d6391e48685757a55
        }
    }
}
