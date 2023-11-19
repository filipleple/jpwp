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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
            this.tytul.Top = GlobalConfig.SCREEN_HEIGHT * 2 / 6;
            this.tytul.Left = GlobalConfig.SCREEN_WIDTH / 2 - this.tytul.Width / 2;

            this.nowagra.Top = this.tytul.Bottom + this.nowagra.Height / 2;
            this.nowagra.Left = GlobalConfig.SCREEN_WIDTH / 2 - this.nowagra.Width / 2;

            this.slownik.Left = this.nowagra.Left;
            this.slownik.Top = this.nowagra.Bottom + this.nowagra.Height / 4;

            this.wyjscie.Left = this.nowagra.Left;
            this.wyjscie.Top = this.slownik.Bottom + this.wyjscie.Height / 4;
        }

        private void nowagra_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainGameWindow.game.startNewGame();
            GlobalConfig.CURRENT_VIEW = GlobalConfig.VIEWS.GAME;
            this.SendToBack();
            
            //this.Parent.BringToFront();
            //this.Parent.Focus();

            MainGameWindow.game.BringToFront();
            //MainGameWindow.game.Focus(); // -- game does not handle keys for some reason
            this.Parent.Focus();
        }

        private void wyjscie_Click(object sender, EventArgs e)
        {
            
        }
    }
}
