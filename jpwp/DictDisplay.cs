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
    public partial class DictDisplay : UserControl
    {
        public DictDisplay()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DictDisplay_Load(object sender, EventArgs e)
        {
            richTextBox1.Lines = MainGameWindow.parser.getCorrectSpellings().ToArray();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wyjscie_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.BringToFront();
            this.Parent.Focus();            
        }
    }
}
