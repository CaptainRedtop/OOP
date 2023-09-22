using BoGodt_test_.Model.Apartment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt_test_.Controller
{
	internal class MakeApartmentsController
	{
		internal List<Apartment> allApartments = new List<Apartment>();
		internal List<Apartment> MakeApartment()
		{
			for (int i = 0; i < 368; i++)
			{
				Apartment oneRoomApartment = new OneRoomApartment();
				allApartments.Add(oneRoomApartment);
			}
			for (int i = 0;i < 235; i++)
			{
				Apartment twoRoonApartmen = new TwoRoomApartment();
				allApartments.Add(twoRoonApartmen);
			}
			for (int i = 0; i < 167; i++)
			{
				Apartment threeRoomApartment = new ThreeRoomApartment();
				allApartments.Add(threeRoomApartment);
			}
			for (int i = 0; i < 97; i++)
			{
				Apartment fourRoomApartment = new FourRoomApartment();
				allApartments.Add(fourRoomApartment);
			}
			for (int i = 0; i < 47; i++)
			{
				Apartment fiveRoomApartment = new FiveRoomApartment();
				allApartments.Add(fiveRoomApartment);
			}
			return allApartments;
		}
	}
}
