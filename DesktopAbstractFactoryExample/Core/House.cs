using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core
{
    public abstract class House : GameObject
    {

        public abstract int UPGRADES_QUANTITY { get; set; }
        public abstract int LEVEL { get; set; }

        public override int X { get; set; } = 40;
        public override int Y { get; set; } = 40;


        public House()
        {
            InitRectangle();
        }

        public override string ToString()
        {
            string s = "";
            s += "Puntos de vida: " + BUILDING_ENDURANCE + Environment.NewLine;
            s += "Nivel: " + LEVEL + Environment.NewLine;
            s += "Cantidad de mejoras: " + UPGRADES_QUANTITY + Environment.NewLine;
            return s;
        }
    }
}
