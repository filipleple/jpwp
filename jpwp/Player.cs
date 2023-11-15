using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace jpwp
{
    internal class Player
    {
        int xpos, ypos;
        public bool goLeft, goRight, jumping = false;
                
        int force;
        int score = 0;
        
        int horizontalSpeed = 5;
        int jumpSpeed = 3;

        int width = 40;
        int height = 80;

        public void move(List<Platform> platforms)
        {
            ypos += jumpSpeed;

            if (goLeft == true)
            {
                xpos -= horizontalSpeed;
            }
            if (goRight == true)
            {
                xpos += horizontalSpeed;
            }

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }


            foreach (Platform platform in platforms)
            {
                if (player.Bounds.IntersectsWith(x.Bounds))
                {
                    force = 8;
                    player.Top = x.Top - player.Height;

                    if ((string)x.Name == "horizontalPlatform" && goLeft == false || (string)x.Name == "horizontalPlatform" && goRight == false)
                    {
                        player.Left -= horizontalSpeed;
                    }
                }
                x.BringToFront();
            }
        }

        public void render(System.Drawing.Graphics formGraphics)
        {
            System.Drawing.SolidBrush localBrush = new System.Drawing.SolidBrush(System.Drawing.Color.BlueViolet);
            formGraphics.FillRectangle(localBrush, new Rectangle(xpos, ypos, width, height));
            localBrush.Dispose();
        }        
        public Player(int xpos, int ypos)
        {
            this.xpos = xpos;
            this.ypos = ypos;
            this.goLeft = false;
            this.goRight = false;
            this.jumping = false;
        }
    }
}
