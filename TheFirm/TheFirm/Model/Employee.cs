using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm.Model
{
	internal class Employee
	{
		protected string firstName;
		protected string lastName;
		protected string socialSecurityNumber;

		public Employee(string firstName, string lastName, string socialSecurityNumber)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.socialSecurityNumber = socialSecurityNumber;
		}

		public override string ToString()
		{
			return $"First Name: {firstName}, Last Name: {lastName}, Social Security Number: {socialSecurityNumber}";
		}

	}
}
