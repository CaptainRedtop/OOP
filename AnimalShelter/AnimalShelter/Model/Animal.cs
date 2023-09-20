using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Model
{
	internal class Animal
	{
		protected string gender;
		protected string fur;
		protected byte legs;
		protected bool egglaying;

		internal Animal(string gender, string fur, byte legs, bool egglaying) 
		{
			this.gender = gender;
			this.fur = fur;
			this.legs = legs;
			this.egglaying = egglaying;
		}
	}
}
