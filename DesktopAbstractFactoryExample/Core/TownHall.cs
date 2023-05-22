using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core
{
    public abstract class TownHall : GameObject
    {
        public abstract int UPGRADES_QUANTITY { get; set; }
        public abstract int DAMAGE_PER_SECOND { get; set; }
        public abstract int WORK_UNIT_CREATION_TIME_IN_SECONDS { get; set; }
        public abstract int LEVEL { get; set; }

        public override int X { get; set; } = 250;
        public override int Y { get; set; } = 150;


        public TownHall()
        {
            InitRectangle();
        }


        public override string ToString()
        {
            string s = "";
            s += "Puntos de vida: " + BUILDING_ENDURANCE + Environment.NewLine;
            s += "Daño por segundo: " + DAMAGE_PER_SECOND + Environment.NewLine;
            s += "Tiempo de creación por unidad de trabajo: " + WORK_UNIT_CREATION_TIME_IN_SECONDS + Environment.NewLine;
            s += "Nivel: " + LEVEL + Environment.NewLine;
            s += "Cantidad de mejoras: " + UPGRADES_QUANTITY + Environment.NewLine;

            return s;

        }
    }
}
