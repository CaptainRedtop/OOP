using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirm.Model;

namespace TheFirm.View
{
	internal class Gui
	{
		public void MainWindow(List<Employee> employees, List<Manager> managers, List<ProjectManager>projectManagers, List<Sweeper>sweepers)
		{
			Console.WriteLine("================================================");
			Console.WriteLine("                    The Firm                    ");
			Console.WriteLine("================================================");
			Console.WriteLine();
			foreach (Employee employee in employees)
			{
				Console.WriteLine(employee);
			}
			Console.WriteLine();
			foreach(Manager manager in managers)
			{
				Console.WriteLine(manager);
			}
			Console.WriteLine();
			foreach (ProjectManager projectManager in projectManagers)
			{
				Console.WriteLine(projectManager);
			}
			Console.WriteLine();
			foreach (Sweeper sweeper in sweepers)
			{
				Console.WriteLine(sweeper);
			}
			Console.ReadKey();
		}
	}
}
