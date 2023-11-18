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
        public bool goLeft, goRight, jumping, inAirNoCollision;

        public int score;

        // TODO: standardize in config
        int force;        
        int horizontalSpeed = 5;
        int jumpSpeed = 3;
        int gravity = 5;        

        Rect rect;
        int width = GlobalConfig.PLAYER_WIDTH;
        int height = GlobalConfig.PLAYER_HEIGHT;
        System.Drawing.Color color = GlobalConfig.PLAYER_COLOR;

        public void move(List<Platform> platforms)
        {
            rect.X = xpos;
            rect.Y = ypos;            

            Console.WriteLine("jumping: " + jumping + " force: " + force + " y speed: " + horizontalSpeed);

            // collision-independent segment (x axis)
            if (goLeft == true)
            {
                xpos -= horizontalSpeed;
            }
            if (goRight == true)
            {
                xpos += horizontalSpeed;
            }

            foreach (Platform platform in platforms)
            {
                if (rect.IntersectsWith(platform.rect))                
                {
                    //collision
                }                
            }

            // collision-dependent segment (y axis)


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
            this.score = 0;
        }
    }
}
