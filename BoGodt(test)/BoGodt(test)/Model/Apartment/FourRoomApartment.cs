using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt_test_.Model.Apartment
{
	internal class FourRoomApartment : Apartment
	{
		bool window;
		internal FourRoomApartment()
		{
			livingroom = true;
			kitchen = true;
			bathroom = true;
			apartmentSize = 85;
			numberOfBedrooms = 3;
		}
		internal FourRoomApartment(bool window)
		{
			this.window = window;
		}
	}
}
