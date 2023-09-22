using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt_test_.View
{
	internal class Gui
	{
		/// <summary>
		/// Main screen
		/// </summary>
		/// <returns></returns>
		internal ConsoleKeyInfo Menu()
		{
			Console.Clear();
			Console.WriteLine("===========================");
			Console.WriteLine("          Bo Godt          ");
			Console.WriteLine("===========================");
			Console.WriteLine();
			Console.WriteLine("You have the following options");
			Console.WriteLine();
			Console.WriteLine("1. Renovate apartment.");
			Console.WriteLine("2. See number of apartments");
			Console.WriteLine("3. Show finances");
			Console.WriteLine("4. Exit");
			ConsoleKeyInfo key = Console.ReadKey();
			return key;
		}
		/// <summary>
		/// Renovate screen
		/// </summary>
		/// <returns></returns>
		internal ConsoleKeyInfo RenovateApartmentMenu()
		{
			Console.Clear();
			Console.WriteLine("Which apartment would you like to renovate?");
			Console.WriteLine();
			Console.WriteLine("1. One room apartment");
			Console.WriteLine("2. Two room apartment");
			Console.WriteLine("3. Three room apartment");
			Console.WriteLine("4. Four room apartment");
			Console.WriteLine("5. Five room apartment");
			ConsoleKeyInfo key = Console.ReadKey();
			return key;
		}
		/// <summary>
		/// Number of apartment screen
		/// </summary>
		/// <param name="apartment"></param>
		internal void ShowNumberOfApartment(int[] apartment)
		{
			Console.Clear();
			Console.WriteLine($"There are {apartment[0]} 1 room apartments left");
			Console.WriteLine($"There are {apartment[1]} 2 room apartments left");
			Console.WriteLine($"There are {apartment[2]} 3 room apartments left");
			Console.WriteLine($"There are {apartment[3]} 4 room apartments left");
			Console.WriteLine($"There are {apartment[4]} 5 room apartments left");
			Console.ReadKey();
		}
		/// <summary>
		/// Renovate screen
		/// </summary>
		/// <returns></returns>
		internal ConsoleKeyInfo RenovateApartment()
		{
			Console.WriteLine("You have choosen a 1 room apartment..");
			Console.WriteLine("What would you like to do?");
			Console.WriteLine();
			Console.WriteLine("1. Add new kitchen");
			Console.WriteLine("2. Add window");
			Console.WriteLine("3. Add floor");
			Console.WriteLine("4. Add door");
			ConsoleKeyInfo key = Console.ReadKey();
			return key;
		}
		/// <summary>
		/// WindowScreen
		/// </summary>
		/// <returns></returns>
		internal ConsoleKeyInfo AddWindow()
		{
			Console.Clear();
			Console.WriteLine("Which window would you like?");
			Console.WriteLine("1. 1 pane window");
			Console.WriteLine("2. 2 pane window");
			Console.WriteLine("3. 3 pane window");
			Console.WriteLine("4. 1 pane frosted window");
			ConsoleKeyInfo key = Console.ReadKey();
			return key;
		}
	}
}
