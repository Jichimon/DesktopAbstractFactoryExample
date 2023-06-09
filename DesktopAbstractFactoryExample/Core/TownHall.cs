using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core
{
    public abstract class TownHall
    {
        public abstract string IMAGE_SOURCE { get; set; }
        public abstract int BUILDING_ENDURANCE { get; set; }
        public abstract int UPGRADES_QUANTITY { get; set; }
        public abstract int DAMAGE_PER_SECOND { get; set; }
        public abstract int WORK_UNIT_CREATION_TIME_IN_SECONDS { get; set; }
        public abstract int LEVEL { get; set; }

        public int X { get; set; } = 250;
        public int Y { get; set; } = 150;

        public abstract Image Image { get; set; }
        public int Width { get; set; } = 200;
        public int Height { get; set; } = 200;
        public Rectangle Rectangle { get; private set; }

        public TownHall()
        {
            InitRectangle();
        }

        private void InitRectangle()
        {
            Rectangle = new Rectangle(X, Y, Width, Height);
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
