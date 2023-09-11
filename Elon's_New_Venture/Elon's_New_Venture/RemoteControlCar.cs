using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Elon_s_New_Venture
{
	public class RemoteControlCar
	{
		private Color _carColor;
		private short _metersDriven;
		private byte _batteryCharge;

		public Color CarColor
		{
			get { return _carColor; }
			set { _carColor = value; }
		}

		public short MetersDriven
		{
			get { return _metersDriven; }
			set { _metersDriven = value; }
		}
		public byte BatteryChage
		{
			get { return (byte)_batteryCharge; }
			set { _batteryCharge = value; }
		}
	}
}
