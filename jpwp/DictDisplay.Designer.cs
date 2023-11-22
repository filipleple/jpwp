namespace jpwp
{
    partial class DictDisplay
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            wyjscie = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(26, 51);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(470, 447);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(181, 18);
            label1.Name = "label1";
            label1.Size = new Size(139, 30);
            label1.TabIndex = 1;
            label1.Text = "SŁOWNIK";
            label1.Click += label1_Click;
            // 
            // wyjscie
            // 
            wyjscie.Font = new Font("OCR A Extended", 20F, FontStyle.Regular, GraphicsUnit.Point);
            wyjscie.Location = new Point(105, 504);
            wyjscie.Name = "wyjscie";
            wyjscie.Size = new Size(283, 63);
            wyjscie.TabIndex = 4;
            wyjscie.Text = "wyjście";
            wyjscie.UseVisualStyleBackColor = true;
            // 
            // DictDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(wyjscie);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "DictDisplay";
            Size = new Size(526, 579);
            Load += DictDisplay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Button wyjscie;
    }
}
