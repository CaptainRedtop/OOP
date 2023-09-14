using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.View
{
	internal class View
	{
		public ConsoleKeyInfo MainMenu()
		{
			Console.Clear();
			Console.WriteLine("==================================================");
			Console.WriteLine();
			Console.WriteLine("                    Queue Menu                    ");
			Console.WriteLine();
			Console.WriteLine("==================================================");
			Console.WriteLine();
			Console.WriteLine("1. Add items");
			Console.WriteLine("2. Delete items");
			Console.WriteLine("3. Show the number of items");
			Console.WriteLine("4. Show min and max items");
			Console.WriteLine("5. Find an item");
			Console.WriteLine("6. Print all items");
			Console.WriteLine("7. Exit\n");
			Console.Write("Enter your choice: ");
			var key = Console.ReadKey();
			return key;

		}
		public ConsoleKeyInfo AddItem()
		{
			Console.Clear();
			Console.WriteLine("\nWhich playstatoin would you like to add?");
			Console.WriteLine("\nYou have the following choices:");
			Console.WriteLine("1. Playstation 1");
			Console.WriteLine("2. Playstation 2");
			Console.WriteLine("3. Playstation 3");
			Console.WriteLine("4. Playstation 4");
			Console.WriteLine("5. Playstation 5");
			var key = Console.ReadKey();
			return key;
		}
		public byte DeleteItem()
		{
			Console.Clear();
			Console.WriteLine("How many items would you like to delete?");
			byte choice = Convert.ToByte(Console.ReadLine());
			return choice;
		}
		public void ShowNumberOfItems(Queue<string> queue)
		{
			Console.Clear();
			Console.Write("Counting items");
			for (int i = 0; i < 3; i++)
			{
				Thread.Sleep(1000);
				Console.Write(". ");
			}
			Console.WriteLine("\nThere are: " + queue.Count() + " items in the queue");
			Console.ReadKey();
		}
		public void ShowMinAndMax(string min, string max)
		{
			Console.Clear();
			Console.WriteLine("Don't understand what to do here... But I can show what it does.");
			Console.WriteLine();
			Console.WriteLine("The minimun item in queue is:");
			Console.WriteLine(min);
			Console.WriteLine("\nThe maximun item in queue is:");
			Console.WriteLine(max);

			Console.ReadKey();
		}
		public void FindItem(Queue<string> playstation)
		{
			Console.Clear();
			Console.WriteLine("Which item would you like to find?");
			string choice = Console.ReadLine();
			if (playstation.Contains(choice))
			{
				byte i = 0;
				foreach (var item in playstation)
				{
					if (item == choice)
					{
						i++;
					}
				}
				Console.WriteLine();
				Console.WriteLine("There are " +  i + " " + choice + " in the queue");
			}
			else
			{
				Console.WriteLine("There are no such item in queue");
			}
			Console.ReadKey();
			

		}
		public void PrintItems(Queue<string> playstation)
		{
			Console.Clear();
			Console.Write("Printing items");
			for (int i = 0; i < 3; i++)
			{
				Thread.Sleep(1000);
				Console.Write(". ");
			}
			Console.WriteLine();
			if (playstation.Count() > 0)
			{
				foreach (string item in playstation)
				{
					Console.WriteLine(item);
				}
			}
			else
			{
				Console.WriteLine("There are no items in queue!");
			}
			Console.ReadKey();
		}
	}
}
