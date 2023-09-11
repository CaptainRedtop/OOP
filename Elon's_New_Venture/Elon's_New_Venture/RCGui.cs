using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Elon_s_New_Venture
{
    internal class RCGui
    {
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("----------------RC Car----------------");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\n\nWhat would you like to do?\n");
            Console.WriteLine("1. Drive a car.");
            Console.WriteLine("2. Charge a car.");
            Console.WriteLine("3. Check battery status");
            Console.Write("Press 1-3 on your keyboard to choose: ");
        }
        public void DriveCar()
        {
            Console.Clear();
            Console.WriteLine("Which car would you like to drive?\n");
            Console.WriteLine("1. car 1");
            Console.WriteLine("2. car 2");
        }
        public void ChargeCar()
        {
            Console.Clear();
            Console.WriteLine("All cars have been charged");
            Console.ReadKey();
        }
        public void BatteryStatus(byte car1Charge, byte car2Charge)
        {
            Console.Clear();
            Console.WriteLine("Car 1: " + car1Charge);
            Console.WriteLine("Car 2: " + car2Charge);
            Console.ReadKey();
            
        }
        public void Error(int errorNum)
        {
            switch (errorNum)
            {
                case 0:
                    {
                        Console.WriteLine("\nWrong input, try again");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("\nCar is not charged");
                        break;
                    }
                case 2:
                    {
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
