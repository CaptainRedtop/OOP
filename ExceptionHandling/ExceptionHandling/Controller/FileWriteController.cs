using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Controller
{
	internal class FileWriteController
	{
		View.ExceptionView exceptionGui = new View.ExceptionView();
		private string path = @"C:\Users\zbc23nksk\Desktop";
		public FileWriteController(string logMessage)
		{
			WriteFile(logMessage);
		}
		internal void WriteFile(string logMessage)
		{
			try
			{
				using (StreamWriter s = File.AppendText(path + "\\" + "log.txt"))
				{
					Log(logMessage, s);
				}
			}
			catch (Exception ex)
			{
				exceptionGui.ExceptionMessage("",ex);
			}
		}
		internal void Log(string logMessage, TextWriter txtWriter)
		{
			try
			{
				txtWriter.Write("\r\nLog Entry : ");
				txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
					DateTime.Now.ToLongDateString());
				txtWriter.WriteLine("  :");
				txtWriter.WriteLine("  :{0}", logMessage);
				txtWriter.WriteLine("-------------------------------");
			}
			catch (Exception ex)
			{
				exceptionGui.ExceptionMessage("",ex);
			}
		}
	}
}
