using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt_test_.Model.Windows
{
	internal class OnePaneWindow : Window
	{
		private bool _frostedGlass;
		internal OnePaneWindow(bool frostedGlass) 
		{
			_frostedGlass = frostedGlass;
			price = Frosted(frostedGlass);
		}

		private double Frosted(bool frosted)
		{
			if (frosted == true)
			{
				price = price * 1.3;
			}
			else
			{
				price = 1879.00;
			}
			return price;
		}
	}
}
