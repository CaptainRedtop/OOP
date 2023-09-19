using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm.Model
{
	internal class Manager:Employee
	{
		protected string phoneNumber;

		public Manager(string firstName, string lastName, string socialSecurityNumber, string phoneNumber) : base(firstName, lastName, socialSecurityNumber)
		{
			 this.phoneNumber = phoneNumber;
		}

		public override string ToString()
		{
			return $"{base.ToString()}, Phonenumber: {phoneNumber}";
		}
	}
}
