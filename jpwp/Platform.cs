using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace jpwp
{
    public class Platform
    {
        int height = GlobalConfig.PLATFORM_HEIGHT;
        public int width, xpos, ypos;
        System.Drawing.Color color = GlobalConfig.PLATFORM_COLOR;
        public Rect rect;

        public Platform(int xpos, int ypos, int width)
        {
            this.xpos = xpos;
            this.ypos = ypos;
            this.width = width;
            this.rect = new Rect(xpos, ypos, width, height);
        }

        public void render(System.Drawing.Graphics formGraphics)
        {       
            System.Drawing.SolidBrush localBrush = new System.Drawing.SolidBrush(color);
            formGraphics.FillRectangle(localBrush, new Rectangle(xpos, ypos, width, height));
            localBrush.Dispose();
        }
    }
}
