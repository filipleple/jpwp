using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace jpwp
{

    public partial class Game : UserControl
    {
        public Player player;
        PlatformLayout platformLayout;
        public bool pause;
        public Game()
        {
            InitializeComponent();
            startNewGame();
            pause = false;
        }

        public void startNewGame()
        {
            GlobalConfig.FREEZE_PLATFORMS = true;
            this.player = new Player(GlobalConfig.PLAYER_START_XPOS, GlobalConfig.PLAYER_START_YPOS);
            this.platformLayout = new PlatformLayout();
            pause = false;
        }
        public void timerTick()
        {
            platformLayout.generateRandomLayout();
            player.move(platformLayout.platforms);
            platformLayout.movePlatforms();

            if (player.ypos > GlobalConfig.SCREEN_HEIGHT)
            {
                //startNewGame();
                pause = true;
                MainGameWindow.quickTimeEvent1.generateNewQTE();
                MainGameWindow.quickTimeEvent1.Enabled = true;
                MainGameWindow.quickTimeEvent1.Visible = true;
                MainGameWindow.quickTimeEvent1.Focus();
                MainGameWindow.quickTimeEvent1.BringToFront();
            }

            else if (player.ypos < 0)
            {
                player.ypos = 0;
                player.jumping = false;
            }



        }

        public void render(Graphics formGraphics)
        {
            player.render(formGraphics);
            platformLayout.renderPlatforms(formGraphics);
        }


        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e != null)
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
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e != null)
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
                    case Keys.Escape:
                        pause = true;
                        break;
                }
            }
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
                case Keys.Escape:
                    pause = true;

                    MainGameWindow.escMenu1.Enabled = true;
                    MainGameWindow.escMenu1.Visible = true;
                    MainGameWindow.escMenu1.BringToFront();
                    MainGameWindow.escMenu1.Focus();

                    break;
            }
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Game
            // 
            Name = "Game";
            Load += Game_Load;
            KeyDown += Game_KeyDown;
            KeyUp += Game_KeyUp;
            ResumeLayout(false);
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

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
