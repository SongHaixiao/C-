using System;

namespace Practice
{
	public class A006_Assignment
	{
		static void Main(string[] args)
        {
			int i;
			double x;

			i = 5;
			x = 3.141592;
			Console.WriteLine("i = " + i + ", x = " + x );

			x = i;			// 암시적 형변환
			i = (int)x;     // 캐스트가 필요함 ( 형 변환 )
			Console.WriteLine("i= " + i + ", x = " + x);

        }
	}
}

