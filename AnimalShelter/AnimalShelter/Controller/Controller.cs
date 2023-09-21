using AnimalShelter.Model;
using AnimalShelter.Model.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Controller
{
    internal class Controller
    {
        internal void StartControlelr()
        {
            Animal dog = new Dog("Male", "Long", 4, true);
            Animal chicken = new Chicken("Female", 2, false, true);
            Animal rabbit = new Rabbit("Male", "Short", 4, true);
        }
    }
}
