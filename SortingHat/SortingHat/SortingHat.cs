using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHat
{
	internal class SortingHat
	{
		enum Houses { Gryffinfor, Hufflepuff, Ravenclaw, Slytherin };

		public int Random()
		{
			Random rand = new Random();
			int number = rand.Next(1,5);
			return number;
		}

		public void House()
		{
			int number = Random();

			switch (number)
			{
				case 1:
					{
						Console.WriteLine(Houses.Gryffinfor);
						break;
					}
				case 2:
					{
						Console.WriteLine(Houses.Hufflepuff);
						break;
					}
				case 3:
					{
						Console.WriteLine(Houses.Ravenclaw);
						break;
					}
				case 4:
					{
						Console.WriteLine(Houses.Slytherin);
						break;
					}
			}
		}

	}
}
