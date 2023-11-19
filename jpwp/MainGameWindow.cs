using System.Diagnostics;

namespace jpwp
{
    public partial class MainGameWindow : Form
    {
        public System.Windows.Forms.Timer myTimer;
        public static Game game;
        public static MainMenu mainMenu;


        public MainGameWindow()
        {
            InitializeComponent();

            // set main timer
            myTimer = new System.Windows.Forms.Timer();
            myTimer.Interval = 16;
            myTimer.Tick += new EventHandler(MyTimer_Tick);
            myTimer.Start();

            mainMenu.Focus();
            mainMenu.BringToFront();            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Main loop
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("tick");
            switch (GlobalConfig.CURRENT_VIEW)
            {
                case GlobalConfig.VIEWS.MAIN_MENU:

                    break;
                case GlobalConfig.VIEWS.GAME:
                    game.timerTick();
                    break;
            }

            this.Invalidate();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            Console.WriteLine("rendering main window");
            game.Visible = false;
            game.render(formGraphics);
            formGraphics.Dispose();
        }

        private void MainGameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e != null)
            {
                Console.WriteLine("mgw handles keys"); 
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

    }
}