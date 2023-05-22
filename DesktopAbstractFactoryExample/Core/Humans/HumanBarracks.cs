using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core.Humans
{
    internal class HumanBarracks : Barracks
    {
        private string imageSrc = Environment.CurrentDirectory + "/Storage/Humans/human_barracks.jpg";

        public HumanBarracks() : base()
        {
            Image = Image.FromFile(imageSrc);
        }

        public override int UPGRADES_QUANTITY { get; set; } = 2;
        public override int LEVEL { get; set; } = 1;
        public override int BUILDING_ENDURANCE { get; set; } = 2000;
        public override int GROUND_UNIT_CREATION_TIME_IN_SECONDS { get; set; } = 20;
        public override int AIR_UNIT_CREATION_TIME_IN_SECONDS { get; set; } = 35;

        public override Image Image { get; set; }
    }
}
