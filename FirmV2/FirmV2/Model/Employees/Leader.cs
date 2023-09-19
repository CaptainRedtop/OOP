using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmV2.Model.Employees
{
    internal class Leader : Employee
    {
        protected bool keys;
        protected string area;

        internal Leader(string firstName, string lastName, double salary, bool keys, string area) : base(firstName, lastName, salary)
        {
            this.keys = keys;
            this.area = area;
        }
        public override string ToString()
        {
            return $"{base.ToString()}Keys: {keys}\nArea: {area}\n";
        }
    }
}
