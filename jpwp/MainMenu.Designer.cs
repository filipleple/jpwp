namespace jpwp
{
    partial class MainMenu
    {

        private System.ComponentModel.IContainer components = null;

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
            tytul = new Label();
            nowagra = new Button();
            slownik = new Button();
            wyjscie = new Button();
            SuspendLayout();
            // 
            // tytul
            // 
            tytul.AutoSize = true;
            tytul.Font = new Font("OCR A Extended", 38F, FontStyle.Regular, GraphicsUnit.Point);
            tytul.Location = new Point(344, 219);
            tytul.Name = "tytul";
            tytul.Size = new Size(613, 66);
            tytul.TabIndex = 0;
            tytul.Text = "RZUTKI GRZEGORZ";
            // 
            // nowagra
            // 
            nowagra.Font = new Font("OCR A Extended", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nowagra.Location = new Point(452, 296);
            nowagra.Name = "nowagra";
            nowagra.Size = new Size(283, 63);
            nowagra.TabIndex = 1;
            nowagra.Text = "nowa gra";
            nowagra.UseVisualStyleBackColor = true;
            nowagra.MouseClick += nowagra_MouseClick;
            // 
            // slownik
            // 
            slownik.Font = new Font("OCR A Extended", 20F, FontStyle.Regular, GraphicsUnit.Point);
            slownik.Location = new Point(452, 388);
            slownik.Name = "slownik";
            slownik.Size = new Size(283, 63);
            slownik.TabIndex = 2;
            slownik.Text = "słownik";
            slownik.UseVisualStyleBackColor = true;
            // 
            // wyjscie
            // 
            wyjscie.Font = new Font("OCR A Extended", 20F, FontStyle.Regular, GraphicsUnit.Point);
            wyjscie.Location = new Point(452, 484);
            wyjscie.Name = "wyjscie";
            wyjscie.Size = new Size(283, 63);
            wyjscie.TabIndex = 3;
            wyjscie.Text = "wyjście";
            wyjscie.UseVisualStyleBackColor = true;
            wyjscie.Click += wyjscie_Click;
            // 
            // Okno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(wyjscie);
            Controls.Add(slownik);
            Controls.Add(nowagra);
            Controls.Add(tytul);
            Name = "MainMenu";
            Size = new Size(1280, 760);
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tytul;

        private Button nowagra;
        private Button slownik;
        private Button wyjscie;
    }
}
