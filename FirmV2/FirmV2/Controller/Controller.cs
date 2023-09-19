using FirmV2.Model.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmV2.Controller
{
    internal class Controller
    {
        View.View gui = new View.View();
        public void StartController()
        {
            List<Employee> employees = new List<Employee>();
            Employee bella = new CEO("Bella", "Nia", 90500, true, "Everything", true, false, true, "CEO", true);
            Employee mike = new LineDirector("Mike", "Jackson", 78000, true, "Finace", true, false, true, "CFO");
            Employee karen = new LineDirector("Karen", "Nielsen", 78000, true, "Organization", true, false, true, "COO");
            Employee anders = new Chief("Anders", "Hansen", 65400, true, "Chief Salary", true, true);
            Employee clara = new Chief("Clara", "Andersen", 65400, true, "Chief Production", true, true);
            Employee susan = new Chief("Susan", "Lüstrup", 65400, true, "Chief Accounting", true, true);
            Employee alfred = new Chief("Alfred", "Jensen", 65400, true, "Chief Security", true, true);
            Employee josephine = new Leader("Josephine", "Petersen", 54000, true, "Salary");
            Employee jacob = new Leader("Jacob", "Christiansen", 54000, true, "Accounting");
            Employee fie = new Leader("Fie", "Mortensen", 54000, true, "Production");
            Employee peter = new Leader("Peter", "Clasuen", 54000, true, "Managment");
            Employee alberte = new Leader("Alberte", "Ditlevsen", 54000, true, "Health and Safty");
            Employee björn = new Leader("Björn", "¨Fyrosia", 54000, true, "Security");
            Employee maria = new Leader("Maria", "Gregersen", 54000, true, "Shipment");
            Employee natashia = new Leader("Natashia", "Fredesen", 54000, true, "Hiring");
        }
    }
}
