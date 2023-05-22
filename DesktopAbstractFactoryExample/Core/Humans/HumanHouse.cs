using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core.Humans
{
    internal class HumanHouse : House
    {
        private string imageSrc = Environment.CurrentDirectory + "/Storage/Humans/human_house.jpg";
        
        public HumanHouse() : base()
        {
            Image = Image.FromFile(imageSrc);
        }

        public override int UPGRADES_QUANTITY { get; set; } = 3;
        public override int LEVEL { get; set; } = 1;
        public override int BUILDING_ENDURANCE { get; set; } = 250;

        public override Image Image { get; set; }
    }
}
