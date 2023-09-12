namespace Robot.Model
{
	public class Robot
	{
		public byte _wheel;
		public string _color;
		public string _extraChip;
		public bool _wiFi;
		public bool _small;
		public bool _battery;
		
		public Robot()
		{ 
			_wiFi = false;
			_small = false;
			_battery = false;
			_color = "White";
            _extraChip = "None";
			_wheel = (byte)0;
		}
		public Robot(bool small) : this()
		{
			_small = small;
		}
		public Robot(bool small, string chip) : this(small)
		{
            _extraChip = chip;
		}
		public Robot(bool small, string chip, bool battery) : this(small, chip)
		{
			_battery = battery;
		}
		public Robot(bool small, string chip, bool battery, bool wifi) : this(small, chip, battery)
		{
			_wiFi = wifi;
		}
		public Robot(bool small, string chip, bool battery, bool wifi, byte wheel) : this(small, chip, battery, wifi)
		{
			_wheel = wheel;
		}
		public Robot(bool small, string chip, bool battery, bool wifi, byte wheel, string color) : this(small, chip, battery, wifi, wheel)
		{
			_color = color;
		}
    }
}
