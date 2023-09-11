using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Elon_s_New_Venture
{
	public class RemoteControlCar
	{
		private string _carColor;
		private short _metersDriven = 0;
		private byte _batteryCapacity = 100;

		public string CarColor
		{
			get { return _carColor; }
			set { _carColor = value; }
		}

		public short MetersDriven
		{
			get { return _metersDriven; }
			set { _metersDriven = value; }
		}
		public byte BatteryCapacity
		{
			get { return (byte)_batteryCapacity; }
			set { _batteryCapacity = value; }
		}
	}
}
