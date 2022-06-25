using System;
namespace Practice
{
	public class A014_StringToNumber
	{
		static void Main(string[] args)
        {
			string input;
			int value;

			Console.Write("1. int로 변환할 문자열을 입력하세요 : ");
			input = Console.ReadLine();
			bool result = Int32.TryParse(input, out value);

			if (!result)
				Console.WriteLine(" '{0}'는 int로 변환될 수 없다.\n", input);
			else
				Console.WriteLine("int '{0}'으로 변환되었다.\n", value);

			Console.Write("2. double로 변환할 문자열을 입력하세요 : ");
			input = Console.ReadLine();

			try
            {
				double value2 = Double.Parse(input);
				//double m = Convert.ToDouble(input);
				Console.WriteLine("double '{0}'으로 변환되없.\n", value2);
            }

			catch(FormatException e)
            {
				Console.WriteLine(e.Message);
            }
        }
	}
}

