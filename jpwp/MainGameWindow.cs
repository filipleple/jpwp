using System.Diagnostics;

namespace jpwp
{
    public partial class MainGameWindow : Form
    {
        
        Player player;
        PlatformLayout platformLayout;
        private System.Windows.Forms.Timer myTimer;

        public void startNewGame()
        {
            GlobalConfig.FREEZE_PLATFORMS = true;
            this.player = new Player(GlobalConfig.PLAYER_START_XPOS, GlobalConfig.PLAYER_START_YPOS);
            this.platformLayout = new PlatformLayout();
        }

        public MainGameWindow()
        {            
            InitializeComponent();
            
            // set main timer
            myTimer = new System.Windows.Forms.Timer();
            myTimer.Interval = 16; 
            myTimer.Tick += new EventHandler(MyTimer_Tick); 
            myTimer.Start();

            startNewGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Main loop
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            platformLayout.generateRandomLayout();
            player.move(platformLayout.platforms);
            platformLayout.movePlatforms();
            
            if(player.ypos > GlobalConfig.SCREEN_HEIGHT)
            {
                startNewGame();
            }

            this.Invalidate();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            //renders section
            player.render(formGraphics);
            platformLayout.renderPlatforms(formGraphics);

            formGraphics.Dispose();
        }

        private void MainGameWindow_KeyDown(object sender, KeyEventArgs e)
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

        private void MainGameWindow_KeyUp(object sender, KeyEventArgs e)
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
    }
}