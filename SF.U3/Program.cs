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

		Console.Write("Ваше имя? ");
		var name = Console.ReadLine();

		int age;
		{
			Console.Write("Сколько Вам лет? ");
			int.TryParse(Console.ReadLine(), out age);
			if (age == 0)
				Console.WriteLine("Видимо какая-то ошибка");
		}

		Console.Write("Когда родились? (дд.мм.гг) ");
		DateTime birthday = Convert.ToDateTime(Console.ReadLine());
		DateTime today = DateTime.Now;
		int howoldyear = today.Year - birthday.Year;  //считает возраст в годах
		{
			if (today <= birthday.AddYears(today.Year - birthday.Year)) //если ДР уже прошел - вычитает год
			howoldyear -= 1;
			}
		Console.WriteLine("Уважаемый {0}, Ваш возраст - {1} (родились - {2}) ", name, age, birthday.ToLongDateString());
		if (howoldyear != age)
		{
			Console.WriteLine("Однако, по моим расчетам, Вам уже {0}!", howoldyear);
		}
				
		int tryday; //проверяет корректность ввода
		{
            do
            {
				bool test;
				Console.Write("Какой ваш любимый день недели?");
				test = int.TryParse(Console.ReadLine(), out tryday);
				if (test == false)
					tryday = 100;
				if (tryday < 0 || tryday > 6)
					Console.WriteLine("Фигня какая-то. Введите день недели от 0 до 6");
			}
			while (tryday < 0 || tryday > 6);		
		}
		var day = (DayOfWeek) tryday;
		Console.WriteLine("Значит {0}...", day);
		Console.WriteLine("Кстати, {0} (ваш день рождения) был {1}", birthday.ToLongDateString(), birthday.DayOfWeek);
		Console.ReadKey();
		
	}
}