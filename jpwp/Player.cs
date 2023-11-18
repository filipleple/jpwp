using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


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

        int width = GlobalConfig.PLAYER_WIDTH;
        int height = GlobalConfig.PLAYER_HEIGHT;

        Rect rect;
        System.Drawing.Color color = GlobalConfig.PLAYER_COLOR;

        public void move(List<Platform> platforms)
        {
            rect.X = xpos;
            rect.Y = ypos;

            ypos += jumpSpeed;

            Console.WriteLine("jumping: " + jumping + " force: " + force + " y speed: " + horizontalSpeed);

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
                if (rect.IntersectsWith(platform.rect))                
                {
                    force = 8;
                    ypos = platform.ypos - height - 1;
                    

                }
                
            }
        }

        public void render(System.Drawing.Graphics formGraphics)
        {
            System.Drawing.SolidBrush localBrush = new System.Drawing.SolidBrush(color);
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
            this.rect = new Rect(xpos, ypos, width, height);
        }
    }
}
