using BoGodt_test_.Model.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt_test_.Model.Apartment
{
	internal class OneRoomApartment : Apartment
	{
		Windows.Window window;
		internal OneRoomApartment()
		{
			apartmentSize = 40;
			livingroom = true;
			kitchen = true;
			bathroom = true;
		}
		internal OneRoomApartment(bool kitchen) : this()
		{
			this.kitchen = kitchen;
			if(kitchen)
			{
				kitchenPrice = 37899.00;
			}
		}
		
	}
}
