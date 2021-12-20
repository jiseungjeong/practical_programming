using System;

namespace FirstCsharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", 3.14159265359);
            Console.WriteLine("{0:f4}", 3.14159265359);
            Console.WriteLine("{0:f3}", 3.14159265359);
            Console.WriteLine("{0:f2}", 3.14159265359);
            Console.WriteLine("{0:f1}", 3.14159265359);

            Console.WriteLine("{0}", 10.1);
            Console.WriteLine("{0:f2}", 10.1);
            Console.WriteLine("{0:f3}", 10.1);
            Console.WriteLine("{0:f4}", 10.1);

            Console.WriteLine("{0}", 200);
            Console.WriteLine("{0:f1}", 200);
            Console.WriteLine("{0:f2}", 200);
            Console.WriteLine("{0:f3}", 200);

        }
    }
}
