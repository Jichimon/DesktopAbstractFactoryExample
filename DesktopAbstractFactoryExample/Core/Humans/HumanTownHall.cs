using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core.Humans
{
    internal class HumanTownHall : TownHall
    {
        private string imageSrc = Environment.CurrentDirectory + "/Storage/Humans/human_castle.jpg";

        public HumanTownHall() : base()
        {
            Image = Image.FromFile(imageSrc);
        }

        public override int UPGRADES_QUANTITY { get; set; } = 5;
        public override int LEVEL { get; set; } = 2;
        public override int BUILDING_ENDURANCE { get; set; } = 5000;
        public override int DAMAGE_PER_SECOND { get; set; } = 15;
        public override int WORK_UNIT_CREATION_TIME_IN_SECONDS { get; set; } = 10;

        public override Image Image { get; set; }
    }
}
