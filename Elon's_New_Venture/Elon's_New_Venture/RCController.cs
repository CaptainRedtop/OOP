using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon_s_New_Venture
{
	internal class RCController
	{
        RCModel makeCar = new RCModel();
        RCGui menu = new RCGui();

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
                    if(key.Key == ConsoleKey.D1)
                    {
                        makeCar.CarStatus(1);
                    }
                    else if (key.Key == ConsoleKey.D2)
                    {
                        makeCar.CarStatus(2);
                    }

                    break;
                }
                else if (input.Key == ConsoleKey.D2)
                {
                    menu.ChargeCar();
                    break;
                }
                else if (input.Key == ConsoleKey.D3)
                {
                    menu.ListCar();
                    break;
                }
                else
                {
                    menu.Error(0);
                }
            }



            Console.ReadKey();
        }
	}
}
