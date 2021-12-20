using System;

namespace FirstCsharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "LuLu";
            int id = 201900001;

            //방법 1
            string message1 = string.Format("Student Name: {0} / Student ID: {1}", name, id);
            Console.WriteLine(message1);

            //방법 2
            Console.WriteLine("Student Name: {0} / Student ID: {1}", name, id);
        }
    }
}
