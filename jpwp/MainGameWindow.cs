using System.Diagnostics;

namespace jpwp
{
    public partial class MainGameWindow : Form
    {
        const int PLAYER_START_XPOS = 100;
        const int PLAYER_START_YPOS = 600;
        Player player = new Player(PLAYER_START_XPOS, PLAYER_START_YPOS);
        PlatformLayout platformLayout = new PlatformLayout();
        private System.Windows.Forms.Timer myTimer;

        public MainGameWindow()
        {
            InitializeComponent();
            //generate layout
            platformLayout.generateRandomLayout();

            // set main timer
            myTimer = new System.Windows.Forms.Timer();
            myTimer.Interval = 16; 
            myTimer.Tick += new EventHandler(MyTimer_Tick); 

            // Start the Timer
            myTimer.Start();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Main loop
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            platformLayout.movePlatforms();
            platformLayout.generateRandomLayout();
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
                        break;
                    case Keys.Left:
                        break;
                    case Keys.Right:
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
                        break;
                    case Keys.Right:
                        break;
                }
            }
        }
    }
}