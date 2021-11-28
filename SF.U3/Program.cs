using System;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.BackgroundColor = ConsoleColor.Yellow;
		Console.ForegroundColor = ConsoleColor.DarkBlue;
		Console.WriteLine("\t Задание по модулю 3 ");
		Console.BackgroundColor = ConsoleColor.Black;
		Console.ForegroundColor = ConsoleColor.White;

		Console.Write("What is your name? ");
		var name = Console.ReadLine();

		Console.Write("What is your age? ");
		var age = checked((byte)int.Parse(Console.ReadLine()));

		Console.Write("What's your birthday date? ");
		DateTime birthday = Convert.ToDateTime(Console.ReadLine());
		DateTime today = DateTime.Now;
		var howold = today.Subtract(birthday);
		var howoldyear = today.Year - birthday.Year;
		
		Console.WriteLine("Your name is {0} and your age is {1} (born - {2}) ", name, age, birthday.ToLongDateString());
		if (howoldyear != age)
		{
			Console.WriteLine("However, according to my calculations you're {0} this year", howoldyear);
		}

		Console.Write("What is your favorite day of week? ");

		var day = (DayOfWeek)int.Parse(Console.ReadLine());
		
		Console.WriteLine("Your favorite day is {0}", day);
		Console.WriteLine("By the way, {0} was {1}", birthday.ToLongDateString(), birthday.DayOfWeek);
		Console.ReadKey();
		
	}
}