using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpwp
{
    internal class PlatformLayout
    {
        static Random rand = new Random();
        public List<Platform> platforms = new List<Platform>();        

        public PlatformLayout() 
        {
            platforms.Add(new Platform(
                GlobalConfig.ROOT_PLATFORM_X, 
                GlobalConfig.ROOT_PLATFORM_Y, 
                GlobalConfig.ROOT_PLATFORM_WIDTH));
        }
        public void renderPlatforms(System.Drawing.Graphics formGraphics)
        {
            foreach (Platform platform in platforms)
            {
                platform.render(formGraphics);
            }
        }
        public void generateRandomLayout()
        {
            int min_ypos, max_ypos, min_xpos, max_xpos,x, dir = 1;

            min_ypos = platforms.Last().ypos - GlobalConfig.MAX_PLATFORM_YPOS_DIFF;
            max_ypos = platforms.Last().ypos;

            while 
            (
                platforms.Last().ypos > -GlobalConfig.MIN_PLATFORM_YPOS_DIFF              

            )
            {        
                
                min_xpos = platforms.Last().xpos + dir * GlobalConfig.MIN_PLATFORM_XPOS_DIFF;
                max_xpos = platforms.Last().xpos + dir * GlobalConfig.MAX_PLATFORM_XPOS_DIFF;

                while( min_xpos < GlobalConfig.SCREEN_WIDTH - GlobalConfig.MIN_PLATFORM_WIDTH && min_xpos > 0 )
                {
                    if (dir == 1){ x = rand.Next(min_xpos, max_xpos); }
                    else { x = rand.Next(max_xpos, min_xpos); }
                    
                    platforms.Add(new Platform(
                        x,
                        rand.Next(min_ypos, max_ypos),
                        rand.Next(GlobalConfig.MIN_PLATFORM_WIDTH, GlobalConfig.MAX_PLATFORM_WIDTH)
                        ));


                    min_xpos = platforms.Last().xpos + dir * GlobalConfig.MIN_PLATFORM_XPOS_DIFF;
                    max_xpos = platforms.Last().xpos + dir * GlobalConfig.MAX_PLATFORM_XPOS_DIFF;

                }
                dir = -dir;

                max_ypos -= GlobalConfig.MAX_PLATFORM_YPOS_DIFF;
                min_ypos -= GlobalConfig.MAX_PLATFORM_YPOS_DIFF;

            }

            if(platforms.First().ypos > GlobalConfig.SCREEN_HEIGHT)
            {
                platforms.RemoveAt(0);
            }

        }
        public void movePlatforms()
        {
            foreach (Platform platform in platforms)
            {
                platform.ypos += GlobalConfig.PLATFORM_SPEED;
            }
        }
    }
}
