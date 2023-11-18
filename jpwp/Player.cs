using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

enum collisionTypes
{
    TOP=0,
    LEFT,
    RIGHT,
    BOTTOM
} 


namespace jpwp
{
    internal class Player
    {
        public int xpos, ypos, width, height, score;
        Rect rect;

        public bool goLeft, goRight, jumping, inAirNoCollision;
        int force, horizontalSpeed, jumpSpeed, gravity;

        List<bool> collisions = new List<bool>();
        
        System.Drawing.Color color;

        public void move(List<Platform> platforms)
        {
            // TODO: fix top/side stuck to platform seemingly mid-air

            rect.X = xpos;
            rect.Y = ypos;            

            // jump params debug dump
            //Console.WriteLine("jumping: " + jumping + " force: " + force + " y speed: " + horizontalSpeed + " nocollision: " + inAirNoCollision);

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
            collisions = new List<bool> { false, false, false, false };

            foreach (Platform platform in platforms)
            {
                if (rect.IntersectsWith(platform.rect))                
                {                    
                    inAirNoCollision = false;

                    if (!jumping)
                    {
                        ypos = platform.ypos - height+1;
                    }

                    // more complex collision detection
                    //collisions = getCollisionType(rect, platform.rect);
                    /*
                    Console.WriteLine(
                        "TOP: " + collisions[(int)collisionTypes.TOP] +
                        " RIGHT: " + collisions[(int)collisionTypes.RIGHT] +
                        " BOTTOM: " + collisions[(int)collisionTypes.BOTTOM] +
                        " LEFT: " + collisions[(int)collisionTypes.LEFT]
                    );
                    */


                }
            }


            // collision-dependent segment (y axis)
            if (inAirNoCollision && !jumping)
            {
                ypos += gravity;
                //try to replace with only bottom collision 
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
            this.rect = new Rect(xpos, ypos, width, height+2);

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

        public List<bool> getCollisionType(Rect player, Rect platform)
        {
            List<bool> result = new List<bool>() { false, false, false, false };

            // Top collision
            Rect underPlatform = new Rect(platform.X, platform.Y + platform.Height, platform.Width, GlobalConfig.SCREEN_HEIGHT - platform.Height);
            if (underPlatform.IntersectsWith(player))
            {
                result[(int)collisionTypes.TOP] = true;
            }

            // Right collision
            Rect leftOfPlatform = new Rect(0, platform.Y, platform.X, platform.Height);
            if (leftOfPlatform.IntersectsWith(player))
            {
                result[(int)collisionTypes.RIGHT] = true;
            }

            // Bottom collision
            Rect abovePlatform = new Rect(platform.X, 0, platform.Width, platform.Y);
            if (abovePlatform.IntersectsWith(player))
            {
                result[(int)collisionTypes.BOTTOM] = true;
            }

            // Left collision
            Rect rightOfPlatform = new Rect(platform.X + platform.Width, platform.Y, GlobalConfig.SCREEN_WIDTH - platform.X - platform.Width, platform.Height);
            if (rightOfPlatform.IntersectsWith(player))
            {
                result[(int)collisionTypes.LEFT] = true;
            }
                        

            return result;
        }
    }
}
