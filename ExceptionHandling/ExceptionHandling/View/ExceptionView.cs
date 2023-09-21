using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.View
{
	internal class ExceptionView
	{
		internal void ExceptionMessage(string message, Exception ex)
		{
			Console.WriteLine(message);
			Console.WriteLine($"Exception: {ex}");
			Console.ReadKey();
		}
	}
}
