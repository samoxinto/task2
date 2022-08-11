using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое чило");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе чило");
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
