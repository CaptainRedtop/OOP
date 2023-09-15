using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediMindTricks.Controller
{
	internal class Controller
	{
		View.Gui gui = new View.Gui();
		public void Start()
		{
			Dictionary<string, int> person = new Dictionary<string, int>();

			person.Add("Niklas", 25);

			person["Matias"] = 23;

			gui.Output(person);
			RemoveElement();
		}
		public void RemoveElement()
		{
			Dictionary<string, bool> characters = new Dictionary<string, bool>()
			{
				{ "Luke", true },
				{ "Han", false },
				{ "Chewbacca", false }
			};
			characters.Remove("Han");
			gui.RemoveElement(characters);
		}
	}
}
