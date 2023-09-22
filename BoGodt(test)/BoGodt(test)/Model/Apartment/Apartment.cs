using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt_test_.Model.Apartment
{
	abstract class Apartment
	{
		protected bool livingroom;
		protected bool kitchen;
		protected bool bathroom;
		protected byte apartmentSize;
		protected byte numberOfBedrooms;
		protected double kitchenPrice;

		protected Apartment() 
		{
			livingroom = true;
			kitchen = true;
			bathroom = true;
		}
		protected Apartment(bool livingroom, bool kitchen, bool bathroom, double kitchenPrice) : this()
		{
			this.livingroom = livingroom;
			this.kitchen = kitchen;
			this.bathroom = bathroom;
			this.kitchenPrice = kitchenPrice;
		}
	}
}
