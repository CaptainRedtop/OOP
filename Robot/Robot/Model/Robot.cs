using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Model
{
	public class Robot
	{
		public string _color;
		public string _chip;
		public bool _wiFi;
		public bool _small;
		public bool _battery;
		
		public Robot()
		{ 

		}
		public Robot(bool small) : this()
		{
			_small = small;
		}
		public Robot(bool small, string chip) : this(small)
		{
			_chip = chip;
		}
		public Robot(bool battery, bool small, string chip) : this(small, chip)
		{
			_battery = battery;
		}

	}
}
