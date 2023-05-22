using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core
{
    public abstract class Barracks : GameObject
    {
        public abstract int UPGRADES_QUANTITY { get; set; }
        public abstract int GROUND_UNIT_CREATION_TIME_IN_SECONDS { get; set; }
        public abstract int AIR_UNIT_CREATION_TIME_IN_SECONDS { get; set; }
        public abstract int LEVEL { get; set; }

        public override int X { get; set; } = 450;
        public override int Y { get; set; } = 50;


        public Barracks()
        {
            InitRectangle();
        }



        public override string ToString()
        {
            string s = "";
            s += "Puntos de vida: " + BUILDING_ENDURANCE + Environment.NewLine;
            s += "Tiempo de creación por unidad terrestre: " + GROUND_UNIT_CREATION_TIME_IN_SECONDS + Environment.NewLine;
            s += "Tiempo de creación por unidad aerea: " + AIR_UNIT_CREATION_TIME_IN_SECONDS + Environment.NewLine;
            s += "Nivel: " + LEVEL + Environment.NewLine;
            s += "Cantidad de mejoras: " + UPGRADES_QUANTITY + Environment.NewLine;

            return s;

        }
    }
}
