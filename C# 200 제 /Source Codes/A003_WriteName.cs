using System;

namespace Practice
{
    public class A003_WriteName
    {
        static void Main(string[] args)
        {
            Console.Write("Hello");
            Console.WriteLine("World!");
            Console.Write("이름을 입력하세: ");

            string name = Console.ReadLine();   // 이름을 입력받습니.

            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님 !");
        }
    }
}