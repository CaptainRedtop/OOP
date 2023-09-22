using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt_test_.Model.Windows
{
	abstract class Window
	{
		protected Finace finace = new Finace();
		protected double price;
		protected byte numberOfPanes;
		protected enum color { Red, Black, Blue, Yellow, Green };

	}
}
