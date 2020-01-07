namespace eHairdresserSalon_UI
{
    partial class LoginHairdresser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.odustaniButton = new System.Windows.Forms.Button();
            this.potvrdiButton = new System.Windows.Forms.Button();
            this.LozinkaLbl = new System.Windows.Forms.Label();
            this.KorisnickoImeLbl = new System.Windows.Forms.Label();
            this.KorisnickoImeInput = new System.Windows.Forms.TextBox();
            this.LozinkaInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(44, 88);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 3;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // potvrdiButton
            // 
            this.potvrdiButton.Location = new System.Drawing.Point(142, 88);
            this.potvrdiButton.Name = "potvrdiButton";
            this.potvrdiButton.Size = new System.Drawing.Size(75, 23);
            this.potvrdiButton.TabIndex = 2;
            this.potvrdiButton.Text = "Potvrdi";
            this.potvrdiButton.UseVisualStyleBackColor = true;
            this.potvrdiButton.Click += new System.EventHandler(this.potvrdiButton_Click);
            // 
            // LozinkaLbl
            // 
            this.LozinkaLbl.AutoSize = true;
            this.LozinkaLbl.Location = new System.Drawing.Point(18, 49);
            this.LozinkaLbl.Name = "LozinkaLbl";
            this.LozinkaLbl.Size = new System.Drawing.Size(44, 13);
            this.LozinkaLbl.TabIndex = 5;
            this.LozinkaLbl.Text = "Lozinka";
            // 
            // KorisnickoImeLbl
            // 
            this.KorisnickoImeLbl.AutoSize = true;
            this.KorisnickoImeLbl.Location = new System.Drawing.Point(18, 19);
            this.KorisnickoImeLbl.Name = "KorisnickoImeLbl";
            this.KorisnickoImeLbl.Size = new System.Drawing.Size(75, 13);
            this.KorisnickoImeLbl.TabIndex = 4;
            this.KorisnickoImeLbl.Text = "Korisničko ime";
            // 
            // KorisnickoImeInput
            // 
            this.KorisnickoImeInput.Location = new System.Drawing.Point(99, 12);
            this.KorisnickoImeInput.Name = "KorisnickoImeInput";
            this.KorisnickoImeInput.Size = new System.Drawing.Size(134, 20);
            this.KorisnickoImeInput.TabIndex = 0;
            // 
            // LozinkaInput
            // 
            this.LozinkaInput.Location = new System.Drawing.Point(99, 49);
            this.LozinkaInput.Name = "LozinkaInput";
            this.LozinkaInput.PasswordChar = '*';
            this.LozinkaInput.Size = new System.Drawing.Size(134, 20);
            this.LozinkaInput.TabIndex = 1;
            this.LozinkaInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LozinkaInput_KeyDown);
            // 
            // LoginHairdresser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 137);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.potvrdiButton);
            this.Controls.Add(this.LozinkaLbl);
            this.Controls.Add(this.KorisnickoImeLbl);
            this.Controls.Add(this.KorisnickoImeInput);
            this.Controls.Add(this.LozinkaInput);
            this.Name = "LoginHairdresser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava na sistem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button potvrdiButton;
        private System.Windows.Forms.Label LozinkaLbl;
        private System.Windows.Forms.Label KorisnickoImeLbl;
        private System.Windows.Forms.TextBox KorisnickoImeInput;
        private System.Windows.Forms.TextBox LozinkaInput;
    }
}