using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core
{
    public abstract class BreedFactory
    {
        public abstract string Name { get; }
        public abstract TownHall CreateTownHall();
        public abstract House CreateHouse();
        public abstract Barracks CreateBarracks();
    }
}
