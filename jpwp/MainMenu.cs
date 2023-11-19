using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace jpwp
{
    internal class MainMenu
    {
        // TODO: maybe make an interface/abstract class for all the
        // different menus
        public MainMenu() 
        { 
        
        }

        public void timerTick()
        {

        }

        public void render()
        {

        }

        public void keyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    break;
                case Keys.Enter:
                    break;
                case Keys.Left:                    
                    break;
                case Keys.Right:                    
                    break;
                case Keys.Escape:
                    break;
            }
        }

        public void keyUp(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    break;
                case Keys.Enter:
                    break;
                case Keys.Left:
                    break;
                case Keys.Right:
                    break;
                case Keys.Escape:
                    break;  
            }
        }
    }
}
