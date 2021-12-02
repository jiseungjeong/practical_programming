using System;

namespace FirstCsharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type Conversion
            char char1 = 'a';

            int int1 = char1; //묵시적 변환, 아스키코드에 의해 대문자 65, 소문자 에이 97
            Console.WriteLine("int1:" + int1);

            long long1 = char1;//묵시적 변환, 97
            Console.WriteLine("long1: " + long1);

            ulong ulong1 = char1;//97
            Console.WriteLine("ulong1: " + ulong1);

            float float1 = char1;//97
            Console.WriteLine("float1: " + float1);

            double double1 = char1;//97
            Console.WriteLine("double1: " + double1);

            long long2 = long.MaxValue;
            int long2ToInt = (int)long2;//63~32 자리의 비트 영역이 날라가기 때문에 명시적 변환 필요

            Console.WriteLine("long2: " + long2);
            Console.WriteLine("long2ToInt: " + long2ToInt);

            float float2 = 3.14159f;
            int float2ToInt = (int)float2;//소수점 아래의 숫자 날라가기 때문에 명시적 변환 필요

            Console.WriteLine("float2: " + float2);
            Console.WriteLine("float2ToInt: " + float2ToInt);

            int int2 = -1;
            uint int2ToUInt = (uint)int2;

            Console.WriteLine("int2: " + int2);
            Console.WriteLine("int2ToUInt: " + int2ToUInt);

        }
    }
}
