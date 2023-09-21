using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ExceptionHandling.View
{
	internal class View
	{
		/// <summary>
		/// Main screen for user
		/// </summary>
		/// <returns></returns>
		internal int Gui()
		{
			Console.Clear();
			Console.WriteLine("=================================================");
			Console.WriteLine("               Exception Handeling               ");
			Console.WriteLine("=================================================");
			Console.WriteLine();
			Console.WriteLine("Enter a number to divid:");
			int number = Convert.ToInt32(Console.ReadLine());
			return number;
		}
		/// <summary>
		/// Showing number of log entires
		/// </summary>
		/// <param name="numberOfExceptions"></param>
		/// <returns></returns>
		internal ConsoleKeyInfo ExceptionList (int numberOfExceptions)
		{
			Console.Clear();
			Console.WriteLine($"There have been {numberOfExceptions} exceptions in total");
			Console.ReadKey();
			Console.WriteLine();
			Console.WriteLine("Do you want to exit? y/n");
			var key = Console.ReadKey();
			return key;
		}
	}
}
