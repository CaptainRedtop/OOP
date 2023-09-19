using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm.Model
{
	internal class ProjectManager:Manager
	{
		protected string email;

		public ProjectManager(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string email) : base(firstName, lastName, socialSecurityNumber, phoneNumber)
		{
			this.email = email;
		}

		public override string ToString()
		{
			return $"{base.ToString()}, E-mail: {email}";
		}
	}
}
