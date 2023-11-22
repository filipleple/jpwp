using System.Diagnostics;

namespace jpwp
{
    public partial class MainGameWindow : Form
    {
        public System.Windows.Forms.Timer myTimer;
        public static DictFileParser parser;


        public MainGameWindow()
        {
            InitializeComponent();

            // set main timer
            myTimer = new System.Windows.Forms.Timer();
            myTimer.Interval = 16;
            myTimer.Tick += new EventHandler(MyTimer_Tick);
            myTimer.Start();

            parser = new DictFileParser();            

            escMenu1.SendToBack();
            escMenu1.Enabled = false;
            escMenu1.Visible = false;

            mainMenu.Focus();
            mainMenu.BringToFront();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Main loop
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            switch (GlobalConfig.CURRENT_VIEW)
            {
                case GlobalConfig.VIEWS.MAIN_MENU:

                    break;
                case GlobalConfig.VIEWS.GAME:
                    if (!game.pause)
                        game.timerTick();
                    break;
            }

            this.Invalidate();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            game.Visible = false;
            game.render(formGraphics);
            formGraphics.Dispose();
        }

        private void MainGameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e != null)
            {
                switch (GlobalConfig.CURRENT_VIEW)
                {
                    case GlobalConfig.VIEWS.MAIN_MENU:

                        break;
                    case GlobalConfig.VIEWS.GAME:
                        game.keyDown(e);
                        break;
                }
            }
        }

        private void MainGameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e != null)
            {
                switch (GlobalConfig.CURRENT_VIEW)
                {
                    case GlobalConfig.VIEWS.MAIN_MENU:

                        break;
                    case GlobalConfig.VIEWS.GAME:
                        game.keyUp(e);
                        break;
                }
            }
        }

        private void escMenu1_Load(object sender, EventArgs e)
        {

        }

        private void dictDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}