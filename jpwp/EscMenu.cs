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
    public partial class EscMenu : UserControl
    {
        public EscMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kontynuuj_Click(object sender, EventArgs e)
        {
            continueGame();
        }

        private void nowagra_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGameWindow.game.startNewGame();
            GlobalConfig.CURRENT_VIEW = GlobalConfig.VIEWS.GAME;
            MainGameWindow.game.BringToFront();

            //MainGameWindow.game.Focus(); // -- game does not handle keys for some reason
            this.Parent.Focus();
        }

        private void continueGame()
        {
            this.Hide();
            GlobalConfig.CURRENT_VIEW = GlobalConfig.VIEWS.GAME;
            this.Parent.BringToFront();
            this.Parent.Focus();
            MainGameWindow.game.pause = false;
        }

        private void EscMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e != null)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    continueGame();
                }
            }
        }

        private void EscMenu_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void wyjscie_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void slownik_Click(object sender, EventArgs e)
        {
            MainGameWindow.dictDisplay1.Enabled = true;
            MainGameWindow.dictDisplay1.Visible = true;
            MainGameWindow.dictDisplay1.BringToFront();
            MainGameWindow.dictDisplay1.Focus();
        }
    }
}
