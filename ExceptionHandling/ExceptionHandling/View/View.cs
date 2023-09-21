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
	}
}
