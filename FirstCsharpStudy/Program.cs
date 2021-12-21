using System;

namespace FirstCsharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the firtst number: ");
            string numStr1 = Console.ReadLine();
            int num1 = int.Parse(numStr1);

            Console.WriteLine("Enter the second number: ");
            string numStr2 = Console.ReadLine();
            int num2 = int.Parse(numStr2);


            int result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");

        }
    }
}
