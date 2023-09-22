using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt_test_.Model.Apartment
{
	internal class TwoRoomApartment : Apartment
	{
		internal TwoRoomApartment()
		{
			livingroom = true;
			kitchen = true;
			bathroom = true;
			apartmentSize = 55;
			numberOfBedrooms = 1;
		}
		
	}
}
