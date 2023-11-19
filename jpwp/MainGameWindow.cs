using System.Diagnostics;

namespace jpwp
{
    public partial class MainGameWindow : Form
    {
        private System.Windows.Forms.Timer myTimer;
        Game game;
        MainMenu mainMenu;

        public MainGameWindow()
        {            
            InitializeComponent();
            
            // set main timer
            myTimer = new System.Windows.Forms.Timer();
            myTimer.Interval = 16; 
            myTimer.Tick += new EventHandler(MyTimer_Tick); 
            myTimer.Start();

            //to be moved to after calling from main menu? 
            game = new Game();

            mainMenu = new MainMenu();
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
                    mainMenu.timerTick(); 
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

            switch (GlobalConfig.CURRENT_VIEW)
            {
                case GlobalConfig.VIEWS.MAIN_MENU:
                    mainMenu.render();
                    break;
                case GlobalConfig.VIEWS.GAME:
                    game.render(formGraphics);
                    break;
            }
            
            formGraphics.Dispose();
        }

        private void MainGameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e != null)
            {
                switch (GlobalConfig.CURRENT_VIEW)
                {
                    case GlobalConfig.VIEWS.MAIN_MENU:
                        mainMenu.keyDown(e);
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
                        mainMenu.keyUp(e);
                        break;
                    case GlobalConfig.VIEWS.GAME:
                        game.keyUp(e);
                        break;
                }
            }
        }

    }
}