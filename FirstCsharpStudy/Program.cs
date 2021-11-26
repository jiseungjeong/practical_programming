using System;

namespace FirstCsharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1234567890;
            float num2 = num1;
            // 아래 (int)num2는 곧 배울꺼니 여기서는 무시
            // float 형에 들어있는 값을 int 형으로 바꿈
            Console.WriteLine(num1 - (int)num2);
        }
    }
}
