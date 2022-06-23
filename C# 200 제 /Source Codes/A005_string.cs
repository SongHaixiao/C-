using System;

namespace Practice
{
	public class A005_string
	{
		static void Main(string[] args)
        {
			string a = "Hello";
			string b = "H";

			b = b + "ello";

			Console.WriteLine(a == b);
			Console.WriteLine("b = " + b);

			int x = 10;
			string c = b + '!' + " " + x;
			Console.WriteLine("c = " + c);
        }

	}
}

