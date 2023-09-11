using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Elon_s_New_Venture
{
	internal class RCController
	{
        RemoteControlCar car1 = new RemoteControlCar();
        RemoteControlCar car2 = new RemoteControlCar();
        RCModel makeCar = new RCModel();
        RCGui menu = new RCGui();

        public void MakeCar()
        {
            car1.CarColor = Color.Red;
            car1.MetersDriven = 0;
            car1.BatteryChage = 100;
            car2.CarColor = Color.Green;
            car2.MetersDriven = 0;
            car2.BatteryChage = 100;
        }
        public void StartController()
        {
            while (true)
            {
                menu.MainMenu();
                var input = Console.ReadKey();

                if (input.Key == ConsoleKey.D1)
                {
                    menu.DriveCar();
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.D1)
                    {
                        DriveCar(1);
                    }
                    else if (key.Key == ConsoleKey.D2)
                    {
                        DriveCar(2);
                    }
                }
                else if (input.Key == ConsoleKey.D2)
                {
                    menu.ChargeCar();
                    car1.BatteryChage = 100;
                    car2.BatteryChage = 100;
                    car1.MetersDriven = 0;
                    car2.MetersDriven = 0;
                }
                else if (input.Key == ConsoleKey.D3)
                {
                    menu.BatteryStatus(car1.BatteryChage, car2.BatteryChage);
                }
                else
                {
                    menu.Error(0);
                }
            }
        }
        public void DriveCar(int carNum)
        {
            switch (carNum)
            {
                case 1:
                    {
                        if (car1.BatteryChage > 0)
                        {
                            if (car1.BatteryChage > 0)
                            {
                                car1.MetersDriven += 20;
                                car1.BatteryChage--;
                            }
                            else
                            {
                                menu.Error(1);
                            }

                        }
                        
                        break;
                    }
                case 2:
                    {
                        if (car2.BatteryChage > 0)
                        {
                            if (car2.BatteryChage > 0)
                            {
                                car2.MetersDriven += 20;
                                car2.BatteryChage--;
                            }
                            else
                            {
                                menu.Error(1);
                            }
                        }
                        break;
                    }
            }

            Console.ReadKey();
        
        }
	}
}
