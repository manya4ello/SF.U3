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
		Console.WriteLine("Your name is {0} and age is {1} ( {2} г.р.) ", name, age, birthday.ToLongDateString());
		Console.WriteLine("However, according to my calculations you're {0} year old.", howoldyear);
		
		Console.Write("What is your favorite day of week? ");

		var day = (DayOfWeek)int.Parse(Console.ReadLine());
		if (day < 0) 
				{
			Console.WriteLine("Your favorite day is {0}", day);
		}
		else Console.WriteLine("It seems like you have no favorite day of week");
		Console.WriteLine("Your favorite day is {0}", day);
		Console.WriteLine("By the way, {0} was {1}", birthday, birthday.DayOfWeek);
		Console.ReadKey();
	}
}