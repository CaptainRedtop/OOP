using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.View
{
	internal class ExceptionView
	{
		/// <summary>
		/// Writing Exception to the user
		/// </summary>
		/// <param name="message"></param>
		/// <param name="ex"></param>
		internal void ExceptionMessage(string message, Exception ex)
		{
			Console.WriteLine(message);
			Console.WriteLine($"Exception: {ex}");
			Console.ReadKey();
		}
	}
}
