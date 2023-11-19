using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpwp
{

    public partial class Game : UserControl
    {
        Player player;
        PlatformLayout platformLayout;
        public Game()
        {
            InitializeComponent();
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
            Console.WriteLine("tack");
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

        public void render(Graphics formGraphics)
        {
            Console.WriteLine("rendering game");
            player.render(formGraphics);
            platformLayout.renderPlatforms(formGraphics);
        }


        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("game handles events");
            if (e != null)
            {
                Console.WriteLine("game handles events");
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
                }
            }
        }




        public void keyDown(KeyEventArgs e)
        {
            Console.WriteLine("game handles events");
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
