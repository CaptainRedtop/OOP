using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmV2.Model.Employees
{
    internal class Chief : Leader
    {
        protected bool car;
        protected bool sharedOffice;

        internal Chief(string firstName, string lastName, double salaty, bool keys, string area, bool car, bool sharedOffice) : base (firstName, lastName, salaty, keys, area)
        {
            this.car = car;
            this.sharedOffice = sharedOffice;
        }
        public override string ToString()
        {
            return $"{base.ToString()}Car: {car}\nShared Office: {sharedOffice}\n";
        }
    }
}
