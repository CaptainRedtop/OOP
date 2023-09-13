using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets.View
{
	internal class View
	{
		public void GUI(List<Model.Planets> planets)
		{
			foreach (var planet in planets)
			{
				Console.WriteLine(planet);
				Console.WriteLine();
			}
			Console.WriteLine("There are: " + planets.Count + " planets");
		}

	}
}
