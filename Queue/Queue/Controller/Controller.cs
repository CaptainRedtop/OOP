using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Controller
{
	/// <summary>
	/// This is the controller controlling the program.
	/// </summary>
	public class Controller
	{
		View.View gui = new View.View();
		public Queue<string> playstation = new Queue<string>();
		public void Menu()
		{
			//The is the Main menu, where the user can choose what to do.
			bool menu = true;
			while (menu == true)
			{
			var key = gui.MainMenu();

				switch (key.Key)
				{
					case ConsoleKey.D1:
						{
							AddItem();
							break;
						}
					case ConsoleKey.D2:
						{
							DeleteItem();
							break;
						}
					case ConsoleKey.D3:
						{
							ShowNumberOfItems();
							break;
						}
					case ConsoleKey.D4:
						{
							ShowMinAndMax();
							break;
						}
					case ConsoleKey.D5:
						{
							FindItem();
							break;
						}
					case ConsoleKey.D6:
						{
							PrintItems();
							break;
						}
					case ConsoleKey.D7:
						{
							menu = false;
							break;
						}
				}
			}
		}
		public void AddItem()
		{
			var key = gui.AddItem();
			switch (key.Key)
			{
				case ConsoleKey.D1:
					{
						playstation.Enqueue("Playstation 1");
						break;
					}
				case ConsoleKey.D2:
					{
						playstation.Enqueue("Playstation 2");
						break;
					}
				case ConsoleKey.D3:
					{
						playstation.Enqueue("Playstation 3");
						break;
					}
				case ConsoleKey.D4:
					{
						playstation.Enqueue("Playstation 4");
						break;
					}
				case ConsoleKey.D5:
					{
						playstation.Enqueue("Playstation 5");
						break;
					}
			}
		}
		public void DeleteItem()
		{
			byte choice = gui.DeleteItem();
			if (choice > playstation.Count)
			{
				playstation.Clear();
			}
			else
			{
				for (int i = 0; i < choice; i++)
				{
					playstation.Dequeue();
				}
			}
			
		}
		public void ShowNumberOfItems()
		{
			gui.ShowNumberOfItems(playstation);
		}
		public void ShowMinAndMax()
		{
			//Camilla said this one doesn't make sense, but is show the min and max of the queue.
			string min = playstation.Min();
			string max = playstation.Max();
			gui.ShowMinAndMax(min, max);
		}
		public void FindItem()
		{
			gui.FindItem(playstation);
		}
		public void PrintItems()
		{
			gui.PrintItems(playstation);
		}

	}
}
