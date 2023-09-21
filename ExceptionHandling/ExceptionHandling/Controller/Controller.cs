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
		View.ExceptionView exceptionGui = new View.ExceptionView();
		FileWriteController writeController;
		internal void StartController()
		{
			Random rand = new Random();
			while (true)
			{
				int number1 = rand.Next(0, 10);
				int number2 = gui.Gui();
				float resault = Calcu(number1, number2);
			}
		}
		internal int Calcu( int number1, int number2)
		{
			try
			{
				int resault = number1 / number2;
				return resault;
			}
			catch (Exception ex)
			{
				writeController = new FileWriteController(ex.Message);
				exceptionGui.ExceptionMessage("You can't divid by 0", ex);
				return 0;
			}
		}
	}
}
