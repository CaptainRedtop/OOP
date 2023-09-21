using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ExceptionHandling.Controller
{
	internal class Controller
	{
		View.View gui = new View.View();
		Model.ReadFile readFile = new Model.ReadFile();
		View.ExceptionView exceptionGui = new View.ExceptionView();
		FileWriteController writeController;
		internal void StartController()
		{
			bool exit = true;
			Random rand = new Random();
			while (exit == true)
			{
				//Getting numbers
				int number1 = rand.Next(0, 10);
				int number2 = gui.Gui();
				//Getting resault
				float resault = Calcu(number1, number2);
				//Counting log entries
				int numberofExceptions = readFile.ReadLogFile();
				var key = gui.ExceptionList(numberofExceptions);

				if (key.Key == ConsoleKey.Y)
				{
					exit = false;
				}
			}
		}
		internal int Calcu( int number1, int number2)
		{
			int resault;
			//Setting highest number first and dividing
            try
			{
				if (number1 > number2)
				{
					resault = number1 / number2;
				}
				else
				{

                    resault = number2 / number1;
                }
				return resault;
			}
			catch (Exception ex)
			{
				writeController = new FileWriteController(ex.ToString());
				exceptionGui.ExceptionMessage("You can't divid by 0", ex);
				return 0;
			}
		}
	}
}
