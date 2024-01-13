using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace jpwp
{
    public partial class QuickTimeEvent : System.Windows.Forms.UserControl
    {
        public string correctSpelling;
        public List<string> randomizedSpellings;

        public QuickTimeEvent()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void generateNewQTE()
        {
            //richTextBox1.Lines = MainGameWindow.parser.getCorrectSpellings().ToArray();
            MainGameWindow.parser.getRandomLine(ref correctSpelling, ref randomizedSpellings);

            button1.Text = randomizedSpellings[0];
            button2.Text = randomizedSpellings[1];
            button3.Text = randomizedSpellings[2];
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void checkIfCorrect(string spelling)
        {
            if (correctSpelling == spelling)
            {
                Console.WriteLine("poprawna pisownia");
                this.Hide();
                GlobalConfig.CURRENT_VIEW = GlobalConfig.VIEWS.GAME;
                this.Parent.BringToFront();
                this.Parent.Focus();
                MainGameWindow.game.player.ypos = 0;
                MainGameWindow.game.pause = false;
            }

            else
            {
                Console.WriteLine("niepoprawna pisownia");
                generateNewQTE();
            }




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            checkIfCorrect(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkIfCorrect(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkIfCorrect(button3.Text);
        }
    }
}
