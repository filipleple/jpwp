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
            userControl11 = new MainMenu();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.BackColor = Color.CadetBlue;
            userControl11.Location = new Point(0, 0);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(1280, 760);
            userControl11.TabIndex = 0;
            // 
            // MainGameWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1262, 713);
            Controls.Add(userControl11);
            Name = "MainGameWindow";
            Text = "Rzutki Grzegorz";
            Load += Form1_Load;
            Paint += Form1_Paint;
            KeyDown += MainGameWindow_KeyDown;
            KeyUp += MainGameWindow_KeyUp;
            ResumeLayout(false);
        }

        private MainMenu userControl11;
    }
}