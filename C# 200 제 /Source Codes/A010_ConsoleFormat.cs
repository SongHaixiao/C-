using System;

namespace Practice
{
	public class A010_ConsoleFormat
	{
		static void Main(string[] args)
        {
			Console.Clear();

			Console.WriteLine("Standard Numeric Format Specifiers");

			Console.WriteLine(
				"(C) Currency    : ............. {0:C}\n" +
                "(D) Decimal     : ............. {0:D}\n" +
                "(E) Scientific  : ............. {1:E}\n" +
                "(F) Fixed Point : ............. {1:F}\n" +
                "(G) General     : ............. {0:G}\n" +
                "(N) Number      : ............. {0:N}\n" +
                "(P) Percent     : ............. {1:P}\n" +
                "(R) Round Trip  : ............. {1:R}\n" +
                "(X) Hexadecimal : ............. {0:X}\n",
                -12345678, -1234.5678f);

            decimal value = 123456.789m;
            Console.WriteLine("잔액은 {0:C2} 원입니;.", value);

            Console.WriteLine("잔액은 {0,20:C2} 원입니다.", value);
        }
	}
}

