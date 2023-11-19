using System.Diagnostics;

namespace jpwp
{
    public partial class MainGameWindow : Form
    {
        private System.Windows.Forms.Timer myTimer;
        Game game;

        public MainGameWindow()
        {            
            InitializeComponent();
            
            // set main timer
            myTimer = new System.Windows.Forms.Timer();
            myTimer.Interval = 16; 
            myTimer.Tick += new EventHandler(MyTimer_Tick); 
            myTimer.Start();

            game = new Game();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Main loop
        private void MyTimer_Tick(object sender, EventArgs e)
        {

            game.timerTick();

            this.Invalidate();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            game.render(formGraphics);

            formGraphics.Dispose();
        }

        private void MainGameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e != null)
            {
                game.keyDown(e);
            }
        }

        private void MainGameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e != null)
            {
                game.keyUp(e);
            }
        }
    }
}