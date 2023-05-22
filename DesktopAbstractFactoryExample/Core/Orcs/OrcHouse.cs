using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core.Orcs
{
    internal class OrcHouse : House
    {
        private string imageSrc = Environment.CurrentDirectory + "/Storage/Orcs/orc_house.jpg";

        public OrcHouse() : base()
        {
            Image = Image.FromFile(imageSrc);
        }

        public override int UPGRADES_QUANTITY { get; set; } = 6;
        public override int LEVEL { get; set; } = 3;
        public int DAMAGE_PER_SECOND { get; set; } = 5;
        public override int BUILDING_ENDURANCE { get; set; } = 1500;

        public override Image Image { get; set; }


        public override string ToString()
        {
            string s = "";
            s += "Puntos de vida: " + BUILDING_ENDURANCE + Environment.NewLine;
            s += "Nivel: " + LEVEL + Environment.NewLine;
            s += "Cantidad de mejoras: " + UPGRADES_QUANTITY + Environment.NewLine;
            s += "Daño por segundo: " + DAMAGE_PER_SECOND + Environment.NewLine;
            return s;
        }
    }
}
