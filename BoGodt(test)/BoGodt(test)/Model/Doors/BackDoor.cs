using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt_test_.Model.Doors
{
	enum Firedoor { None, BD60, BD40 }
	internal class BackDoor : Door
	{
		internal readonly Firedoor _door;
		internal BackDoor(Firedoor firedoor)
		{
			price = 4879.00;
			_door = firedoor;
			if (firedoor == Firedoor.BD60)
			{
				price = price * 1.58;
			}
			else if (firedoor == Firedoor.BD40)
			{
				price = price * 1.43;
			}
			finace.Money(price);
		}
	}
}
