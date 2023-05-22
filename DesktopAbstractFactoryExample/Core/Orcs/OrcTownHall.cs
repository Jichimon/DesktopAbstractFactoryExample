using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core.Orcs
{
    internal class OrcTownHall : TownHall
    {
        private string imageSrc = Environment.CurrentDirectory + "/Storage/Orcs/orc_castle.jpg";

        public OrcTownHall() : base()
        {
            Image = Image.FromFile(imageSrc);
        }

        public override int UPGRADES_QUANTITY { get; set; } = 5;
        public override int LEVEL { get; set; } = 4;
        public override int BUILDING_ENDURANCE { get; set; } = 3500;
        public override int DAMAGE_PER_SECOND { get; set; } = 15;
        public override int WORK_UNIT_CREATION_TIME_IN_SECONDS { get; set; } = 18;

        public override Image Image { get; set; }
    }
}
