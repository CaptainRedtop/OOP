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
		private string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public FileWriteController(string logMessage)
		{
			WriteFile(logMessage);
		}
		/// <summary>
		/// Creating path for file
		/// </summary>
		/// <param name="logMessage"></param>
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
		/// <summary>
		/// Writing log message to file
		/// </summary>
		/// <param name="logMessage"></param>
		/// <param name="txtWriter"></param>
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
