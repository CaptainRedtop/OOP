using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Model
{
	abstract class Animal
	{
		protected string gender;
		protected byte legs;
		protected bool mamal

		protected Animal(string gender, byte legs, bool mammal)
		{
			this.gender = gender;
			this.legs = legs;
			this.egglaying = mammal;
		}
	}
}
