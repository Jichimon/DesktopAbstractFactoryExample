using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core.Humans
{
    public class HumanBreedFactory : BreedFactory
    {
        public override string Name => "Humanos";

        public override TownHall CreateTownHall()
        {
            return new HumanTownHall();
        }

        public override Barracks CreateBarracks()
        {
            return new HumanBarracks();
        }

        public override House CreateHouse()
        {
            return new HumanHouse();
        }
    }
}
