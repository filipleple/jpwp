﻿namespace jpwp
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
            SuspendLayout();
            // 
            // MainGameWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1280, 760);
            Name = "MainGameWindow";
            Text = "Rzutki Grzegorz";
            Load += Form1_Load;
            Paint += Form1_Paint;
            KeyDown += MainGameWindow_KeyDown;
            KeyUp += MainGameWindow_KeyUp;
            ResumeLayout(false);
        }
    }
}