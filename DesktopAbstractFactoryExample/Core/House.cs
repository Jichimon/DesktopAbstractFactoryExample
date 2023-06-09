using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core
{
    public abstract class House
    {
        public abstract string IMAGE_SOURCE { get; set; }
        public abstract int BUILDING_ENDURANCE { get; set; }
        public abstract int UPGRADES_QUANTITY { get; set; }
        public abstract int LEVEL { get; set; }

        public int X { get; set; } = 40;
        public int Y { get; set; } = 40;

        public abstract Image Image { get; set; }
        public int Width { get; set; } = 200;
        public int Height { get; set; } = 200;
        public Rectangle Rectangle { get; private set; }


        public House()
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
            s += "Nivel: " + LEVEL + Environment.NewLine;
            s += "Cantidad de mejoras: " + UPGRADES_QUANTITY + Environment.NewLine;
            return s;
        }
    }
}
