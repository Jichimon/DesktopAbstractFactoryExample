using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.Core
{
    public abstract class GameObject
    {
        public abstract string IMAGE_SOURCE { get; set; }
        public abstract int BUILDING_ENDURANCE { get; set; }


        public abstract Image Image { get; set; }  
        public abstract int X { get; set; }
        public abstract int Y { get; set; }
        public int Width { get; set; } = 200;
        public int Height { get; set; } = 200;
        public Rectangle Rectangle;

        public override string ToString()
        {
            string s = "";
            s += "Puntos de vida: " + BUILDING_ENDURANCE + Environment.NewLine;
            return s;
        }


        public void InitRectangle()
        {
            Rectangle = new Rectangle(X, Y, Width, Height);
        }

    }
}
