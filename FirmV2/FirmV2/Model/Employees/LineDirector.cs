using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmV2.Model.Employees
{
    internal class LineDirector : Chief
    {
        protected bool ownOffice;
        protected string title;

        internal LineDirector(string firstName, string lastName, double salaty, bool keys, string area, bool car, bool sharedOffice, bool ownOffice, string title) : base (firstName, lastName, salaty, keys, area, car, sharedOffice)
        {
            this.ownOffice = ownOffice;
            this.title = title;
        }
        public override string ToString()
        {
            return $"{base.ToString()}Own Office: {ownOffice}\nTitle: {title}\n";
        }
    }
}
