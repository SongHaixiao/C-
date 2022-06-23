using System;

namespace Practice
{
    public class A004_Variable
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세: ");
            string name = Console.ReadLine();

            Console.Write("나이를 입력하세: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("키를 입력하세 (cm): ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("안녕하세, ");
            Console.Write(name);
            Console.WriteLine("님!");

            Console.Write("나이는 ");
            Console.Write(age);
            Console.Write("세, 키는 ");
            Console.Write(height);
            Console.WriteLine("cm 이군요!");
        }
    }
}
