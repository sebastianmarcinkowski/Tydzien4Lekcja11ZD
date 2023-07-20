using System;

namespace Tydzien4Lekcja11ZD
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				while (true)
				{
					Console.WriteLine("Sprawdzę, czy wprowadzona przez Ciebie liczba jest parzysta.");

					var number = GetInt();

					if (IsEven(number))
					{
						Console.Clear();
						Console.WriteLine($"Liczba {number} jest liczbą parzystą.");
					}
					else
					{
						Console.Clear();
						Console.WriteLine($"Liczba {number} jest liczbą nieparzystą.");
					}

					Console.Write("Aby sprawdzić koleją liczbę wpisz 'TAK' i zatwierdź enterem, w przeciwnym wypadku wystarczy wcisnąć samo enter: ");
					if (!(Console.ReadLine().ToUpper() == "TAK"))
						break;
					Console.Clear();
				}
			}
			catch (Exception)
			{
				Console.Clear();
				Console.WriteLine("Wystąpił nieoczekiwany błąd, program zostanie zamknięty!");
			}
			finally
			{
				Console.Write("Aby zakończyć program naciśnij dowolny klawisz...");
				Console.ReadKey();
			}
		}
		static int GetInt()
		{
			var number = 0;

			Console.Write("Wprowadź liczbę: ");

			while (true)
			{
				if (int.TryParse(Console.ReadLine(), out number))
					break;

				Console.Clear();
				Console.WriteLine("Podana wartość jest nieprawidłowa, spróbuj jeszcze raz!");
				Console.Write("Wprowadź liczbę: ");
			}

			return number;
		}
		static bool IsEven(int number)
		{
			return number % 2 == 0;
		}
	}
}
