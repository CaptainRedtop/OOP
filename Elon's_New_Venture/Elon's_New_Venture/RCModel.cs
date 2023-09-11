using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon_s_New_Venture
{
    internal class RCModel
    {
        RemoteControlCar car1 = new RemoteControlCar();
        RemoteControlCar car2 = new RemoteControlCar();

        public void MakeCar()
        {

            car1.CarColor = Color.Red;
            car1.BatteryChage = 100;
            car1.MetersDriven = 0;

            car2.CarColor = Color.Green;
            car2.BatteryChage = 100;
            car2.MetersDriven = 0;

        }
        public void CarStatus(int car)
        {
            if (car == 1)
            {
                if (car1.BatteryChage > 0)
                {
                    car1.MetersDriven += 20;
                    car1.BatteryChage -= 1;
                }

            }
            else if (car == 2)
            {
                if (car2.BatteryChage > 0)
                {
                    car2.MetersDriven += 20;
                    car2.BatteryChage -= 1;
                }
            }
        }
    }
}
