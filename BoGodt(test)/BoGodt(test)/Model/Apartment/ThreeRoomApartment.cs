using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt_test_.Model.Apartment
{
	internal class ThreeRoomApartment : Apartment
	{
		internal ThreeRoomApartment()
		{
			livingroom = true;
			kitchen = true;
			bathroom = true;
			apartmentSize = 70;
			numberOfBedrooms = 2;
		}
	}
}
