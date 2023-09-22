using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt_test_.Model
{
	internal class Finace
	{
		internal double money = 550000000;
		internal void Money(double price)
		{
			money = money - price;
		}
	}
}
