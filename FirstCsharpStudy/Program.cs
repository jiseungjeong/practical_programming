using System;

namespace FirstCsharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName1 = "Kim Leon";
            float winRate1 = 30.2351f;

            string studentName2 = "Lulu";
            float winRate2 = 70.11f;

            string studentName3 = "Blitzcrank";
            float winRate3 = 98.284f;

            Console.WriteLine("{0}     {1}\n", "Name", "WinRate");
            Console.WriteLine("{0} {1}", studentName1, winRate1);
            Console.WriteLine("{0}     {1}", studentName2, winRate2);
            Console.WriteLine("{0}     {1}", studentName3, winRate3);

        }
    }
}
