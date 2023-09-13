namespace SortingHat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				SortingHat sortingHat = new SortingHat();
				Console.WriteLine("You belong to: \n");
				sortingHat.House();
				Console.WriteLine("\n\nDo you want to go again? y/n");
				char choice = Convert.ToChar(Console.ReadLine().ToLower());
				if(choice == 'y')
				{
					Console.Clear();
				}
				else if (choice == 'n')
				{
					break;
				}
				else
				{
					Console.WriteLine("Wrong input you donk!");
					Thread.Sleep(5000);
					break;
				}
			}
		}
	}
}