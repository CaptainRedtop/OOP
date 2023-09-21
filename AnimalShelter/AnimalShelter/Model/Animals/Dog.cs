﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Model.Animals
{
	internal class Dog : Animal
	{
		private string fur;
		internal Dog(string gender, string fur, byte legs, bool mammal) : base(gender, legs, mammal)
		{
			this.fur = fur;
		}
	}
}
