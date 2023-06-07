using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core.Orcs
{
    internal class OrcBarracks : Barracks
    {

        public OrcBarracks() : base()
        {
            Image = Image.FromFile(IMAGE_SOURCE);
        }

        public override string IMAGE_SOURCE { get; set; } = Environment.CurrentDirectory + "/Storage/Orcs/orc_barracks.jpg";

        public override int UPGRADES_QUANTITY { get; set; } = 3;
        public override int LEVEL { get; set; } = 2;
        public override int BUILDING_ENDURANCE { get; set; } = 1500;
        public override int GROUND_UNIT_CREATION_TIME_IN_SECONDS { get; set; } = 24;
        public override int AIR_UNIT_CREATION_TIME_IN_SECONDS { get; set; } = 38;

        public override Image Image { get; set; }
    }
}
