using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirm.Model;

namespace TheFirm.Controller
{
	internal class Controller
	{
		View.Gui gui = new View.Gui();
		List<Sweeper> sweepers = new List<Sweeper>();
		internal void StartController()
		{
			List<Employee> employees = AddEmployee();
			List<Manager> manager = AddManager();
			List<ProjectManager> projectManagers = AddProjectManager();
			List<Sweeper> sweepers = AddSweeper();
			gui.MainWindow(employees, manager, projectManagers, sweepers);
		}
		public List<Employee> AddEmployee()
		{
			List<Employee> employees = new List<Employee>();
			Employee employee = new Employee("Maria", "Jackson", "280499-1314");
			employees.Add(employee);
			return employees;
		}
		public List<Manager> AddManager()
		{
			List<Manager> managers = new List<Manager>();
			Manager manager = new Manager("David", "Anderson", "051291-6277", "62519584");
			managers.Add(manager);
			return managers;
		}
		public List<ProjectManager> AddProjectManager()
		{
			List<ProjectManager> projectManagers = new List<ProjectManager>();
			ProjectManager projectManager = new ProjectManager("Julie", "Poulsen", "140296-9144", "21365901", "JulieP@gmail.com");
			projectManagers.Add(projectManager);
			return projectManagers;
		}
		public List<Sweeper> AddSweeper()
		{
			List<Sweeper> sweepers = new List<Sweeper>();
			Sweeper sweeper = new Sweeper("Bent", "Bentsen", "020202-0101");
			sweepers.Add(sweeper);
			return sweepers;
		}
	}
}
