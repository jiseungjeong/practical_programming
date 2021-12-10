using System;

namespace FirstCsharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //BitFlag
            const int BIT_FLAG_SIZE = 8;
            //1바이트 안에 몇 개의 비트가 들어갈 수 있는지를 정의
            byte bitFlags = 0;

            byte mask1 = 1 << 2;
            //00000100
            bitFlags |= mask1;
            //OR 연산자를 이용하여 비트플래그에 초기값와 변한값 논리연산
            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));
            // 괄호안의 이상한 코드 신경쓰지 말자. 비트플래그 변수를 문자열로 출력하기 위해 한것.
            byte mask3 = (1 << 3) | (1 << 5);
            //00101000
            bitFlags |= mask3;
            //00101100
            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));
            bitFlags &= (byte)~mask1;
            //3번째 비트를 끄고 싶을때 다른 비트는 건드리면 안 됨. 다른 비트들은 그대로 인체로 유지.
            //마스크1의 비트들을 뒤집으면 00000100에서 11111011로 바뀜. 앤드로 연산하면 원래부분 꺼버릴 수 있음.
            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            bitFlags &= 0;
            //모두가 끄고 싶다면 변수를 모두 0으로 바꿔도 되지만, 0과 앤드 연산을 해도 됨.
            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            char char1 = 'A';
            int result1 = char1 | ' ';
            //아스키 코드 상에서 32는 스페이스바
            Console.WriteLine("result1: " + (char)result1);

            char char2 = 'a';
            int result2 = char2 & '_';
            //소문자 a를 대문자 A로 바꿈
            Console.WriteLine("result2: " + (char)result2);

        }
    }
}
