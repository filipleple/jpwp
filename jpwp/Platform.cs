using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpwp
{
    internal class Platform
    {
        public static int PLATFORM_HEIGHT = 30; //?????
        public int width, xpos, ypos;
        System.Drawing.Color color = System.Drawing.Color.Aquamarine;

        public Platform(int xpos, int ypos, int width)
        {
            this.xpos = xpos;
            this.ypos = ypos;
            this.width = width;
        }

        public void render(System.Drawing.Graphics formGraphics)
        {       

            System.Drawing.SolidBrush localBrush = new System.Drawing.SolidBrush(color);
            formGraphics.FillRectangle(localBrush, new Rectangle(xpos, ypos, width, PLATFORM_HEIGHT));
            localBrush.Dispose();
        }
    }
}
