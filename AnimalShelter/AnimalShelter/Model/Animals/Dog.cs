using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Model.Animals
{
	internal class Dog : Animal
	{
		internal Dog( string gender, string fur, byte legs, bool egglaying) : base (gender, fur, legs, egglaying) { }

	}
}
