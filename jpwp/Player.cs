using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace jpwp
{
    internal class Player
    {
        public int xpos, ypos, width, height, score;
        Rect rect;

        public bool goLeft, goRight, jumping, inAirNoCollision;
        int force, horizontalSpeed, jumpSpeed, gravity;
        
        System.Drawing.Color color;

        public void move(List<Platform> platforms)
        {
            // TODO: fix top/side stuck to platform seemingly mid-air

            rect.X = xpos;
            rect.Y = ypos;            

            Console.WriteLine("jumping: " + jumping + " force: " + force + " y speed: " + horizontalSpeed + " nocollision: " + inAirNoCollision);

            // collision-independent segment (x axis)
            if (goLeft == true)
            {
                xpos -= horizontalSpeed;
            }
            if (goRight == true)
            {
                xpos += horizontalSpeed;
            }

            inAirNoCollision = true;
            foreach (Platform platform in platforms)
            {
                if (rect.IntersectsWith(platform.rect))                
                {
                    inAirNoCollision = false;
                }                
            }

            // collision-dependent segment (y axis)
            if (inAirNoCollision && !jumping)
            {
                ypos += gravity;
            }

            if (jumping)
            {
                if (force > 0)
                {                    
                    force--;
                    ypos -= jumpSpeed;

                }
                else
                {
                    jumping = false;
                    force = GlobalConfig.PLAYER_FORCE;
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
            this.width = GlobalConfig.PLAYER_WIDTH;
            this.height = GlobalConfig.PLAYER_HEIGHT;
            this.rect = new Rect(xpos, ypos, width, height);

            this.score = 0;

            this.goLeft = false;
            this.goRight = false;
            this.jumping = false;

            this.force = GlobalConfig.PLAYER_FORCE;
            this.horizontalSpeed = GlobalConfig.PLAYER_X_SPEED;
            this.jumpSpeed = GlobalConfig.PLAYER_JUMP_SPEED;
            this.gravity = GlobalConfig.PLAYER_GRAVITY;

            this.color = GlobalConfig.PLAYER_COLOR;
        }
    }
}
