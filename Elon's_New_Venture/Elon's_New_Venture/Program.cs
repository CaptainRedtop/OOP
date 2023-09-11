namespace Elon_s_New_Venture
{
	internal class Program
	{
		private void Main(string[] args)
		{
			StartController();
		}

		#region GUI
		private System.ConsoleKeyInfo MainMenu()
		{
			Console.WriteLine("--------------------------------");
			Console.WriteLine("-------------RC Car-------------");
			Console.WriteLine("--------------------------------");
			Console.WriteLine("\n\n\nWhat would you like to do?\n");
			Console.WriteLine("1. Create a new RC car.");
			Console.WriteLine("2. Drive a car.");
			Console.WriteLine("3. View a list of cars.");
			Console.WriteLine("4. Charge a cars battery");
			var key = Console.ReadKey();
			return key;
		}
		#endregion GUI

		#region Controller
		private void StartController()
		{
			switch (MainMenu())
			{
				case (ConsoleKey.D1):
				{
					break;
				}
			}
		}
		#endregion Controller

		#region Model

		#endregion Model
	}
}