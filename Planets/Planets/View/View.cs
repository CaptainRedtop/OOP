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
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}

		public void LowMeanTemp(List<Model.Planets> planetsUnder0)
		{
			Console.WriteLine("\nPlanets with a Mean Temperature under 0:\n");
            foreach (var planet in planetsUnder0)
            {
                Console.WriteLine(planet);
                Console.WriteLine();
            }
			
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
		public void PlanetDiameter(List<Model.Planets> planetDiameter)
		{
			Console.WriteLine("\nPlanets with a Diameter between 10.000km and 50.000km:\n");
            foreach (var planet in planetDiameter)
            {
                Console.WriteLine(planet);
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
		public void LastList(List<Model.Planets> planets)
		{
            foreach (var planet in planets)
            {
                Console.WriteLine(planet);
                Console.WriteLine();
            }
			Console.WriteLine("\nIt seems empty...\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

	}
}
