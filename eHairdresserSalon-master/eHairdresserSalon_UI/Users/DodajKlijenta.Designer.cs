using System;

namespace eHairdresserSalon_UI.Users
{
    partial class DodajKlijenta
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
            this.components = new System.ComponentModel.Container();
            this.ImeLbl = new System.Windows.Forms.Label();
            this.ImeInput = new System.Windows.Forms.TextBox();
            this.PrezimeInput = new System.Windows.Forms.TextBox();
            this.AdresaInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.LozinkaInput = new System.Windows.Forms.TextBox();
            this.KorisnickoImeInput = new System.Windows.Forms.TextBox();
            this.NapomenaInput = new System.Windows.Forms.TextBox();
            this.PrezimeLbl = new System.Windows.Forms.Label();
            this.DatumRodjenjaLbl = new System.Windows.Forms.Label();
            this.AdresaLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.BrojTelefonaLbl = new System.Windows.Forms.Label();
            this.NapomenaLbl = new System.Windows.Forms.Label();
            this.KorisnickoImeLbl = new System.Windows.Forms.Label();
            this.LozinkaLbl = new System.Windows.Forms.Label();
            this.DodajKlijentaBtn = new System.Windows.Forms.Button();
            this.BrojTelefonaInput = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ImeLbl
            // 
            this.ImeLbl.AutoSize = true;
            this.ImeLbl.Location = new System.Drawing.Point(12, 25);
            this.ImeLbl.Name = "ImeLbl";
            this.ImeLbl.Size = new System.Drawing.Size(24, 13);
            this.ImeLbl.TabIndex = 10;
            this.ImeLbl.Text = "Ime";
            this.ImeLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ImeInput
            // 
            this.ImeInput.Location = new System.Drawing.Point(106, 25);
            this.ImeInput.Name = "ImeInput";
            this.ImeInput.Size = new System.Drawing.Size(100, 20);
            this.ImeInput.TabIndex = 0;
            this.ImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.ImeInput_Validating);
            // 
            // PrezimeInput
            // 
            this.PrezimeInput.Location = new System.Drawing.Point(106, 66);
            this.PrezimeInput.Name = "PrezimeInput";
            this.PrezimeInput.Size = new System.Drawing.Size(100, 20);
            this.PrezimeInput.TabIndex = 1;
            this.PrezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.PrezimeInput_Validating);
            // 
            // AdresaInput
            // 
            this.AdresaInput.Location = new System.Drawing.Point(106, 141);
            this.AdresaInput.Name = "AdresaInput";
            this.AdresaInput.Size = new System.Drawing.Size(100, 20);
            this.AdresaInput.TabIndex = 3;
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(106, 186);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(100, 20);
            this.EmailInput.TabIndex = 4;
            this.EmailInput.Validating += new System.ComponentModel.CancelEventHandler(this.EmailInput_Validating);
            // 
            // LozinkaInput
            // 
            this.LozinkaInput.Location = new System.Drawing.Point(106, 344);
            this.LozinkaInput.Name = "LozinkaInput";
            this.LozinkaInput.PasswordChar = '*';
            this.LozinkaInput.Size = new System.Drawing.Size(100, 20);
            this.LozinkaInput.TabIndex = 8;
            this.LozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.LozinkaInput_Validating);
            // 
            // KorisnickoImeInput
            // 
            this.KorisnickoImeInput.Location = new System.Drawing.Point(106, 307);
            this.KorisnickoImeInput.Name = "KorisnickoImeInput";
            this.KorisnickoImeInput.Size = new System.Drawing.Size(100, 20);
            this.KorisnickoImeInput.TabIndex = 7;
            this.KorisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.KorisnickoImeInput_Validating);
            // 
            // NapomenaInput
            // 
            this.NapomenaInput.Location = new System.Drawing.Point(106, 265);
            this.NapomenaInput.Name = "NapomenaInput";
            this.NapomenaInput.Size = new System.Drawing.Size(100, 20);
            this.NapomenaInput.TabIndex = 6;
            // 
            // PrezimeLbl
            // 
            this.PrezimeLbl.AutoSize = true;
            this.PrezimeLbl.Location = new System.Drawing.Point(12, 66);
            this.PrezimeLbl.Name = "PrezimeLbl";
            this.PrezimeLbl.Size = new System.Drawing.Size(44, 13);
            this.PrezimeLbl.TabIndex = 11;
            this.PrezimeLbl.Text = "Prezime";
            // 
            // DatumRodjenjaLbl
            // 
            this.DatumRodjenjaLbl.AutoSize = true;
            this.DatumRodjenjaLbl.Location = new System.Drawing.Point(12, 107);
            this.DatumRodjenjaLbl.Name = "DatumRodjenjaLbl";
            this.DatumRodjenjaLbl.Size = new System.Drawing.Size(77, 13);
            this.DatumRodjenjaLbl.TabIndex = 12;
            this.DatumRodjenjaLbl.Text = "Datum rođenja";
            // 
            // AdresaLbl
            // 
            this.AdresaLbl.AutoSize = true;
            this.AdresaLbl.Location = new System.Drawing.Point(12, 148);
            this.AdresaLbl.Name = "AdresaLbl";
            this.AdresaLbl.Size = new System.Drawing.Size(40, 13);
            this.AdresaLbl.TabIndex = 13;
            this.AdresaLbl.Text = "Adresa";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(12, 189);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(32, 13);
            this.EmailLbl.TabIndex = 14;
            this.EmailLbl.Text = "Email";
            // 
            // BrojTelefonaLbl
            // 
            this.BrojTelefonaLbl.AutoSize = true;
            this.BrojTelefonaLbl.Location = new System.Drawing.Point(12, 229);
            this.BrojTelefonaLbl.Name = "BrojTelefonaLbl";
            this.BrojTelefonaLbl.Size = new System.Drawing.Size(66, 13);
            this.BrojTelefonaLbl.TabIndex = 15;
            this.BrojTelefonaLbl.Text = "Broj telefona";
            // 
            // NapomenaLbl
            // 
            this.NapomenaLbl.AutoSize = true;
            this.NapomenaLbl.Location = new System.Drawing.Point(12, 272);
            this.NapomenaLbl.Name = "NapomenaLbl";
            this.NapomenaLbl.Size = new System.Drawing.Size(59, 13);
            this.NapomenaLbl.TabIndex = 16;
            this.NapomenaLbl.Text = "Napomena";
            // 
            // KorisnickoImeLbl
            // 
            this.KorisnickoImeLbl.AutoSize = true;
            this.KorisnickoImeLbl.Location = new System.Drawing.Point(12, 314);
            this.KorisnickoImeLbl.Name = "KorisnickoImeLbl";
            this.KorisnickoImeLbl.Size = new System.Drawing.Size(75, 13);
            this.KorisnickoImeLbl.TabIndex = 17;
            this.KorisnickoImeLbl.Text = "Korisničko ime";
            // 
            // LozinkaLbl
            // 
            this.LozinkaLbl.AutoSize = true;
            this.LozinkaLbl.Location = new System.Drawing.Point(12, 351);
            this.LozinkaLbl.Name = "LozinkaLbl";
            this.LozinkaLbl.Size = new System.Drawing.Size(44, 13);
            this.LozinkaLbl.TabIndex = 18;
            this.LozinkaLbl.Text = "Lozinka";
            // 
            // DodajKlijentaBtn
            // 
            this.DodajKlijentaBtn.Location = new System.Drawing.Point(131, 396);
            this.DodajKlijentaBtn.Name = "DodajKlijentaBtn";
            this.DodajKlijentaBtn.Size = new System.Drawing.Size(75, 23);
            this.DodajKlijentaBtn.TabIndex = 9;
            this.DodajKlijentaBtn.Text = "Dodaj";
            this.DodajKlijentaBtn.UseVisualStyleBackColor = true;
            this.DodajKlijentaBtn.Click += new System.EventHandler(this.DodajKlijentaBtn_Click);
            // 
            // BrojTelefonaInput
            // 
            this.BrojTelefonaInput.Location = new System.Drawing.Point(106, 229);
            this.BrojTelefonaInput.Mask = "(999) 000-000";
            this.BrojTelefonaInput.Name = "BrojTelefonaInput";
            this.BrojTelefonaInput.Size = new System.Drawing.Size(100, 20);
            this.BrojTelefonaInput.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 107);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 1, 28, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2019, 1, 28, 0, 0, 0, 0);
            // 
            // DodajKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 444);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BrojTelefonaInput);
            this.Controls.Add(this.DodajKlijentaBtn);
            this.Controls.Add(this.LozinkaLbl);
            this.Controls.Add(this.KorisnickoImeLbl);
            this.Controls.Add(this.NapomenaLbl);
            this.Controls.Add(this.BrojTelefonaLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.AdresaLbl);
            this.Controls.Add(this.DatumRodjenjaLbl);
            this.Controls.Add(this.PrezimeLbl);
            this.Controls.Add(this.NapomenaInput);
            this.Controls.Add(this.KorisnickoImeInput);
            this.Controls.Add(this.LozinkaInput);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.AdresaInput);
            this.Controls.Add(this.PrezimeInput);
            this.Controls.Add(this.ImeInput);
            this.Controls.Add(this.ImeLbl);
            this.Name = "DodajKlijenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj klijenta";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label ImeLbl;
        private System.Windows.Forms.TextBox ImeInput;
        private System.Windows.Forms.TextBox PrezimeInput;
        private System.Windows.Forms.TextBox AdresaInput;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.TextBox LozinkaInput;
        private System.Windows.Forms.TextBox KorisnickoImeInput;
        private System.Windows.Forms.TextBox NapomenaInput;
        private System.Windows.Forms.Label PrezimeLbl;
        private System.Windows.Forms.Label DatumRodjenjaLbl;
        private System.Windows.Forms.Label AdresaLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label BrojTelefonaLbl;
        private System.Windows.Forms.Label NapomenaLbl;
        private System.Windows.Forms.Label KorisnickoImeLbl;
        private System.Windows.Forms.Label LozinkaLbl;
        private System.Windows.Forms.Button DodajKlijentaBtn;
        private System.Windows.Forms.MaskedTextBox BrojTelefonaInput;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}