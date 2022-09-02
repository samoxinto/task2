using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат");
            
            if (a > b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
