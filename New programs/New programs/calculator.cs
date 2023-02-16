using System;


namespace New_programs
{
	class calculator
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			char op = char.Parse(Console.ReadLine());
			switch (op)
			{
				case '+': Console.WriteLine("ADDITION OF TWO NUMBERS :  " + (a + b)); break;
				case '-': Console.WriteLine("SUBTRACTION OF TWO NUMBERS :  " + (a - b)); break;
				case '*': Console.WriteLine("PRODUCT OF TWO NUMBERS :  " + (a * b)); break;
				case '/': Console.WriteLine("ADDITION OF TWO NUMBERS :  " + ((float)a / (float)b)); break;
				default:
					Console.WriteLine("enter correct operator");
					break;
			}



			Console.ReadLine();
		}
	}
}
