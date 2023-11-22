namespace jpwp
{
    partial class EscMenu
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
            pauzaLabel = new Label();
            wyjscie = new Button();
            slownik = new Button();
            nowagra = new Button();
            kontynuuj = new Button();
            SuspendLayout();
            // 
            // pauzaLabel
            // 
            pauzaLabel.AutoSize = true;
            pauzaLabel.Font = new Font("OCR A Extended", 29F, FontStyle.Regular, GraphicsUnit.Point);
            pauzaLabel.Location = new Point(131, 49);
            pauzaLabel.Name = "pauzaLabel";
            pauzaLabel.Size = new Size(172, 51);
            pauzaLabel.TabIndex = 0;
            pauzaLabel.Text = "pauza";
            pauzaLabel.Click += label1_Click;
            // 
            // wyjscie
            // 
            wyjscie.Font = new Font("OCR A Extended", 20F, FontStyle.Regular, GraphicsUnit.Point);
            wyjscie.Location = new Point(75, 379);
            wyjscie.Name = "wyjscie";
            wyjscie.Size = new Size(283, 63);
            wyjscie.TabIndex = 6;
            wyjscie.Text = "wyjście";
            wyjscie.UseVisualStyleBackColor = true;
            wyjscie.Click += wyjscie_Click;
            // 
            // slownik
            // 
            slownik.Font = new Font("OCR A Extended", 20F, FontStyle.Regular, GraphicsUnit.Point);
            slownik.Location = new Point(75, 293);
            slownik.Name = "slownik";
            slownik.Size = new Size(283, 63);
            slownik.TabIndex = 5;
            slownik.Text = "słownik";
            slownik.UseVisualStyleBackColor = true;
            // 
            // nowagra
            // 
            nowagra.Font = new Font("OCR A Extended", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nowagra.Location = new Point(75, 211);
            nowagra.Name = "nowagra";
            nowagra.Size = new Size(283, 63);
            nowagra.TabIndex = 4;
            nowagra.Text = "nowa gra";
            nowagra.UseVisualStyleBackColor = true;
            nowagra.Click += nowagra_Click;
            // 
            // kontynuuj
            // 
            kontynuuj.Font = new Font("OCR A Extended", 20F, FontStyle.Regular, GraphicsUnit.Point);
            kontynuuj.Location = new Point(75, 129);
            kontynuuj.Name = "kontynuuj";
            kontynuuj.Size = new Size(283, 63);
            kontynuuj.TabIndex = 7;
            kontynuuj.Text = "kontynuuj";
            kontynuuj.UseVisualStyleBackColor = true;
            kontynuuj.Click += kontynuuj_Click;
            // 
            // EscMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(kontynuuj);
            Controls.Add(wyjscie);
            Controls.Add(slownik);
            Controls.Add(nowagra);
            Controls.Add(pauzaLabel);
            Name = "EscMenu";
            Size = new Size(427, 480);
            KeyDown += EscMenu_KeyDown;
            KeyUp += EscMenu_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pauzaLabel;
        private Button wyjscie;
        private Button slownik;
        private Button nowagra;
        private Button kontynuuj;
    }
}
