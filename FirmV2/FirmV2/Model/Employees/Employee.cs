using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmV2.Model.Employees
{
    internal class Employee
    {
        protected string firstName;
        protected string lastName;
        protected double salary;

        internal Employee(string firstName, string lastName, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"First Name: {firstName}\nLast Name: {lastName}\nSalary: {salary}kr\n";
        }
    }
}
