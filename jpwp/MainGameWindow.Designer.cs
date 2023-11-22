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
            dictDisplay1 = new DictDisplay();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.BackColor = Color.CadetBlue;
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(1280, 760);
            mainMenu.TabIndex = 0;
            // 
            // game
            // 
            game.Location = new Point(0, 0);
            game.Name = "game";
            game.Size = new Size(1280, 760);
            game.TabIndex = 1;
            // 
            // escMenu1
            // 
            escMenu1.BorderStyle = BorderStyle.FixedSingle;
            escMenu1.Location = new Point(438, 103);
            escMenu1.Name = "escMenu1";
            escMenu1.Size = new Size(429, 482);
            escMenu1.TabIndex = 2;
            escMenu1.Load += escMenu1_Load;
            // 
            // dictDisplay1
            // 
            dictDisplay1.BackColor = SystemColors.Control;
            dictDisplay1.BorderStyle = BorderStyle.FixedSingle;
            dictDisplay1.Location = new Point(356, 72);
            dictDisplay1.Name = "dictDisplay1";
            dictDisplay1.Size = new Size(524, 585);
            dictDisplay1.TabIndex = 3;
            // 
            // MainGameWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1262, 713);
            Controls.Add(dictDisplay1);
            Controls.Add(escMenu1);
            Controls.Add(game);
            Controls.Add(mainMenu);
            Name = "MainGameWindow";
            Text = "Rzutki Grzegorz";
            Load += Form1_Load;
            Paint += Form1_Paint;
            KeyDown += MainGameWindow_KeyDown;
            KeyUp += MainGameWindow_KeyUp;
            ResumeLayout(false);
        }

        public static DictDisplay dictDisplay1;
        public static Game game;
        public static EscMenu escMenu1;
        public static MainMenu mainMenu;
    }
}