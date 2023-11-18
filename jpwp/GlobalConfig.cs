using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpwp
{
    internal class GlobalConfig
    {
        //meta
        public static int SCREEN_WIDTH = 1280;
        public static int SCREEN_HEIGHT = 760;

        //player
        public static System.Drawing.Color PLAYER_COLOR = System.Drawing.Color.BlueViolet;
        public static int PLAYER_START_XPOS = 100;
        public static int PLAYER_START_YPOS = 600;
        public static int PLAYER_WIDTH = 40;
        public static int PLAYER_HEIGHT = 80;
        public static int PLAYER_FORCE = 15;
        public static int PLAYER_X_SPEED = 8;
        public static int PLAYER_JUMP_SPEED = 14;
        public static int PLAYER_GRAVITY = 8;

        //platforms
        public static int PLATFORM_HEIGHT = 30;
        public static int ROOT_PLATFORM_X = 30;
        public static int ROOT_PLATFORM_Y = SCREEN_HEIGHT - PLATFORM_HEIGHT;
        public static int ROOT_PLATFORM_WIDTH = 150;
        public static int MAX_PLATFORM_YPOS_DIFF = 150;
        public static int MIN_PLATFORM_YPOS_DIFF = 100;
        public static int MAX_PLATFORM_XPOS_DIFF = 600;
        public static int MIN_PLATFORM_XPOS_DIFF = 400;
        public static int MAX_PLATFORM_WIDTH = 200;
        public static int MIN_PLATFORM_WIDTH = 100;
        public static int PLATFORM_SPEED = 2;
        public static System.Drawing.Color PLATFORM_COLOR = System.Drawing.Color.Aquamarine;


        //debug
        public static bool FREEZE_PLATFORMS = true;
    }
}
