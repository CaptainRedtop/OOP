using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt_test_.Model.Apartment
{
	internal class FiveRoomApartment : Apartment
	{
		bool window;
		internal FiveRoomApartment()
		{
			livingroom = true;
			kitchen = true;
			bathroom = true;
			apartmentSize = 110;
			numberOfBedrooms = 4;
		}
		internal FiveRoomApartment(bool window)
		{
			this.window = window;
		}
	}
}
