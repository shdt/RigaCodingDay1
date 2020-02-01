using System;

namespace Day1_basics
{
	class Program
	{
		static void Main (string[] args)
		{
			//cilveks ievada skaitli
			//parbaudam vai ir lielaks par pieci
			//ja ir ##
			//ja nav #

			//Majas- sameklet ka parbaudit divus nosacijumus
			//un parbaudit vai cilveks ievada pareiza garuma String
			//un vai sis String ir vienads ar "aaaaaaaaaa"
			string assertion = "aaaaaaaaaa";

			Console.WriteLine("Try guessing a string:");
			string input = Console.ReadLine();

				if (input == assertion)
				{
					Console.WriteLine("you guessed the actual string");
				}
				else if (input.Length >= assertion.Length)
				{
					Console.WriteLine("you guessed length correctly");
				}
				else
				{
					Console.WriteLine("didn't guess");
				}
		}

		static int AgeCalc(int year, int born)
		{
			int age = year - born;
			return age;
		}

		static void Example()
		{
			int a = 7;
			int b = 5;
			int c = a + b;

			Console.WriteLine("Calculation result:" + c + " Insert result here:");
			string input = Console.ReadLine();

			int convertedNr = Convert.ToInt32(input);
			c = convertedNr - b;
			Console.WriteLine($"your number minus 5  = {c}");

			string st1 = "hey";
			string st2 = "ho";
			Console.WriteLine($"{st1} {st2}");
		}

		static void tst()
		{
			string input;
			Console.WriteLine("Hi there, we need to perform several validations to validate your age, which year is it?");
			input = Console.ReadLine();
			int yearCurrent = Convert.ToInt32(input);
			Console.WriteLine("And which year where you born?");
			input = Console.ReadLine();
			int yearBorn = Convert.ToInt32(input);

			int age = AgeCalc(yearCurrent, yearBorn);

			Console.WriteLine($"Thnx, so it means you are {age} old!");
			Console.WriteLine($"Or maybe it's {age - 1} old!");


			if (age > 18)
			{
				if (age - 1 == 18)
				{
					Console.WriteLine("Hardly valid for you to visit adult sites");
				}
				else
				{
					Console.WriteLine("And it means you are legit to visit adult sites");
				}
			}
			else
			{
				Console.WriteLine("You are too young to be here");
			}
		}
		static void tst2 (string[] args)
		{
			Console.WriteLine("Insert digit:");
			string input = Console.ReadLine();
			int digit = Convert.ToInt32(input);

			if (digit > 5)
			{
				Console.WriteLine("##");
			}
			else
			{
				Console.WriteLine("#");
			}
		}
	}
}
