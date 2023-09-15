using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediMindTricks.View
{
	internal class Gui
	{
		public void Output(Dictionary<string, int> person)
		{
			Console.WriteLine(person.First().ToString());
			Console.ReadKey();
		}
		public void RemoveElement(Dictionary<string, bool> characters)
		{
			foreach (var character in characters)
			{
				Console.WriteLine(character.ToString());
			}
			Console.ReadKey();
		}
	}
}
