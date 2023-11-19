using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpwp
{
    internal class Game
    {
        Player player;
        PlatformLayout platformLayout;
        
        public Game()
        {
            startNewGame();
        }
        public void startNewGame()
        {
            GlobalConfig.FREEZE_PLATFORMS = true;
            this.player = new Player(GlobalConfig.PLAYER_START_XPOS, GlobalConfig.PLAYER_START_YPOS);
            this.platformLayout = new PlatformLayout();
        }

        public void timerTick()
        {
            platformLayout.generateRandomLayout();
            player.move(platformLayout.platforms);
            platformLayout.movePlatforms();

            if (player.ypos > GlobalConfig.SCREEN_HEIGHT)
            {
                startNewGame();
            }

            else if (player.ypos < 0)
            {
                player.ypos = 0;
                player.jumping = false;
            }
        }

        public void render(System.Drawing.Graphics formGraphics)
        {
            player.render(formGraphics);
            platformLayout.renderPlatforms(formGraphics);
        }


        public void keyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Space:
                    if (!player.inAirNoCollision)
                    {
                        player.jumping = true;
                        GlobalConfig.FREEZE_PLATFORMS = false;
                    }

                    break;
                case Keys.Left:
                    player.goLeft = true;
                    break;
                case Keys.Right:
                    player.goRight = true;
                    break;
            }
        }

        public void keyUp(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Space:
                    break;
                case Keys.Left:
                    player.goLeft = false;
                    break;
                case Keys.Right:
                    player.goRight = false;
                    break;
            }
        }
    }
}
