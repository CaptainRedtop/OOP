using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmV2.Model.Employees
{
    internal class CEO : LineDirector
    {
        protected bool ownership;

        internal CEO(string firstName, string lastName, double salaty, bool keys, string area, bool car, bool sharedOffice, bool ownOffice, string title, bool ownership) : base(firstName, lastName, salaty, keys, area, car, sharedOffice, ownOffice, title)
        {
            this.ownership = ownOffice;
        }
        public override string ToString()
        {
            return $"{base.ToString()}Ownership: {ownership}";
        }
    }
}
