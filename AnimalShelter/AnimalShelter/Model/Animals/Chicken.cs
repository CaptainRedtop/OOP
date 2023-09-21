using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Model.Animals
{
	internal class Chicken : Animal
	{
		internal bool feather;
		internal Chicken(string gender, byte legs, bool mammal, bool feather) : base(gender, legs, mammal)
		{
			this.feather = feather;
		}
	}
}
