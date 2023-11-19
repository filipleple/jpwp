namespace jpwp
{
    partial class MainGameWindow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainMenu = new MainMenu();
            game = new Game();
            escMenu1 = new EscMenu();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.BackColor = Color.CadetBlue;
            mainMenu.Location = new Point(0, 0);
            mainMenu.Margin = new Padding(3, 2, 3, 2);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(1120, 570);
            mainMenu.TabIndex = 0;
            // 
            // game
            // 
            game.Location = new Point(0, 0);
            game.Margin = new Padding(3, 2, 3, 2);
            game.Name = "game";
            game.Size = new Size(1120, 570);
            game.TabIndex = 1;
            // 
            // escMenu1
            // 
            escMenu1.Location = new Point(383, 77);
            escMenu1.Margin = new Padding(3, 2, 3, 2);
            escMenu1.Name = "escMenu1";
            escMenu1.Size = new Size(376, 362);
            escMenu1.TabIndex = 2;
            escMenu1.Load += escMenu1_Load;
            // 
            // MainGameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1104, 535);
            Controls.Add(escMenu1);
            Controls.Add(game);
            Controls.Add(mainMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainGameWindow";
            Text = "Rzutki Grzegorz";
            Load += Form1_Load;
            Paint += Form1_Paint;
            KeyDown += MainGameWindow_KeyDown;
            KeyUp += MainGameWindow_KeyUp;
            ResumeLayout(false);
        }

        public static Game game;
        public static EscMenu escMenu1;
        public static MainMenu mainMenu;
    }
}