using DesktopAbstractFactoryExample.Core.Humans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core.Orcs
{
    public class OrcBreedFactory : BreedFactory
    {
        public override string Name => "Orcos";

        public override TownHall CreateTownHall()
        {
            return new OrcTownHall();
        }

        public override Barracks CreateBarracks()
        {
            return new OrcBarracks();
        }

        public override House CreateHouse()
        {
            return new OrcHouse();
        }
    }
}
