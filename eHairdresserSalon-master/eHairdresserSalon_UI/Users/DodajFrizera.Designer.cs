namespace eHairdresserSalon_UI.Users
{
    partial class DodajFrizera
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
            this.DodajFrizeraBtn = new System.Windows.Forms.Button();
            this.LozinkaLbl = new System.Windows.Forms.Label();
            this.KorisnickoImeLbl = new System.Windows.Forms.Label();
            this.PrezimeLbl = new System.Windows.Forms.Label();
            this.KorisnickoImeInput = new System.Windows.Forms.TextBox();
            this.LozinkaInput = new System.Windows.Forms.TextBox();
            this.PrezimeInput = new System.Windows.Forms.TextBox();
            this.ImeInput = new System.Windows.Forms.TextBox();
            this.ImeLbl = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.ucitajSlikuBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SlikaLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opisInput = new System.Windows.Forms.RichTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MaxVelSlikeLbl = new System.Windows.Forms.Label();
            this.vrstaUslugeLbl = new System.Windows.Forms.Label();
            this.vrstaUslugeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DodajFrizeraBtn
            // 
            this.DodajFrizeraBtn.Location = new System.Drawing.Point(347, 511);
            this.DodajFrizeraBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DodajFrizeraBtn.Name = "DodajFrizeraBtn";
            this.DodajFrizeraBtn.Size = new System.Drawing.Size(100, 28);
            this.DodajFrizeraBtn.TabIndex = 7;
            this.DodajFrizeraBtn.Text = "Dodaj";
            this.DodajFrizeraBtn.UseVisualStyleBackColor = true;
            this.DodajFrizeraBtn.Click += new System.EventHandler(this.DodajFrizeraBtn_Click);
            // 
            // LozinkaLbl
            // 
            this.LozinkaLbl.AutoSize = true;
            this.LozinkaLbl.Location = new System.Drawing.Point(16, 180);
            this.LozinkaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LozinkaLbl.Name = "LozinkaLbl";
            this.LozinkaLbl.Size = new System.Drawing.Size(57, 17);
            this.LozinkaLbl.TabIndex = 12;
            this.LozinkaLbl.Text = "Lozinka";
            // 
            // KorisnickoImeLbl
            // 
            this.KorisnickoImeLbl.AutoSize = true;
            this.KorisnickoImeLbl.Location = new System.Drawing.Point(16, 134);
            this.KorisnickoImeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KorisnickoImeLbl.Name = "KorisnickoImeLbl";
            this.KorisnickoImeLbl.Size = new System.Drawing.Size(99, 17);
            this.KorisnickoImeLbl.TabIndex = 11;
            this.KorisnickoImeLbl.Text = "Korisničko ime";
            // 
            // PrezimeLbl
            // 
            this.PrezimeLbl.AutoSize = true;
            this.PrezimeLbl.Location = new System.Drawing.Point(16, 79);
            this.PrezimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrezimeLbl.Name = "PrezimeLbl";
            this.PrezimeLbl.Size = new System.Drawing.Size(59, 17);
            this.PrezimeLbl.TabIndex = 10;
            this.PrezimeLbl.Text = "Prezime";
            // 
            // KorisnickoImeInput
            // 
            this.KorisnickoImeInput.Location = new System.Drawing.Point(140, 130);
            this.KorisnickoImeInput.Margin = new System.Windows.Forms.Padding(4);
            this.KorisnickoImeInput.Name = "KorisnickoImeInput";
            this.KorisnickoImeInput.Size = new System.Drawing.Size(132, 22);
            this.KorisnickoImeInput.TabIndex = 2;
            this.KorisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.KorisnickoImeInput_Validating);
            // 
            // LozinkaInput
            // 
            this.LozinkaInput.Location = new System.Drawing.Point(140, 176);
            this.LozinkaInput.Margin = new System.Windows.Forms.Padding(4);
            this.LozinkaInput.Name = "LozinkaInput";
            this.LozinkaInput.PasswordChar = '*';
            this.LozinkaInput.Size = new System.Drawing.Size(132, 22);
            this.LozinkaInput.TabIndex = 3;
            this.LozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.LozinkaInput_Validating);
            // 
            // PrezimeInput
            // 
            this.PrezimeInput.Location = new System.Drawing.Point(140, 79);
            this.PrezimeInput.Margin = new System.Windows.Forms.Padding(4);
            this.PrezimeInput.Name = "PrezimeInput";
            this.PrezimeInput.Size = new System.Drawing.Size(132, 22);
            this.PrezimeInput.TabIndex = 1;
            this.PrezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.PrezimeInput_Validating);
            // 
            // ImeInput
            // 
            this.ImeInput.Location = new System.Drawing.Point(140, 25);
            this.ImeInput.Margin = new System.Windows.Forms.Padding(4);
            this.ImeInput.Name = "ImeInput";
            this.ImeInput.Size = new System.Drawing.Size(132, 22);
            this.ImeInput.TabIndex = 0;
            this.ImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.ImeInput_Validating);
            // 
            // ImeLbl
            // 
            this.ImeLbl.AutoSize = true;
            this.ImeLbl.Location = new System.Drawing.Point(16, 28);
            this.ImeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImeLbl.Name = "ImeLbl";
            this.ImeLbl.Size = new System.Drawing.Size(30, 17);
            this.ImeLbl.TabIndex = 9;
            this.ImeLbl.Text = "Ime";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(313, 25);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 88);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // slikaInput
            // 
            this.slikaInput.Location = new System.Drawing.Point(140, 226);
            this.slikaInput.Margin = new System.Windows.Forms.Padding(4);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.PasswordChar = '*';
            this.slikaInput.Size = new System.Drawing.Size(132, 22);
            this.slikaInput.TabIndex = 4;
            // 
            // ucitajSlikuBtn
            // 
            this.ucitajSlikuBtn.Location = new System.Drawing.Point(301, 226);
            this.ucitajSlikuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ucitajSlikuBtn.Name = "ucitajSlikuBtn";
            this.ucitajSlikuBtn.Size = new System.Drawing.Size(100, 28);
            this.ucitajSlikuBtn.TabIndex = 5;
            this.ucitajSlikuBtn.Text = "Učitaj sliku";
            this.ucitajSlikuBtn.UseVisualStyleBackColor = true;
            this.ucitajSlikuBtn.Click += new System.EventHandler(this.ucitajSlikuBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // SlikaLbl
            // 
            this.SlikaLbl.AutoSize = true;
            this.SlikaLbl.Location = new System.Drawing.Point(16, 230);
            this.SlikaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SlikaLbl.Name = "SlikaLbl";
            this.SlikaLbl.Size = new System.Drawing.Size(38, 17);
            this.SlikaLbl.TabIndex = 13;
            this.SlikaLbl.Text = "Slika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 371);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Opis";
            // 
            // opisInput
            // 
            this.opisInput.Location = new System.Drawing.Point(140, 367);
            this.opisInput.Margin = new System.Windows.Forms.Padding(4);
            this.opisInput.Name = "opisInput";
            this.opisInput.Size = new System.Drawing.Size(305, 110);
            this.opisInput.TabIndex = 6;
            this.opisInput.Text = "";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MaxVelSlikeLbl
            // 
            this.MaxVelSlikeLbl.AutoSize = true;
            this.MaxVelSlikeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxVelSlikeLbl.Location = new System.Drawing.Point(43, 265);
            this.MaxVelSlikeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxVelSlikeLbl.Name = "MaxVelSlikeLbl";
            this.MaxVelSlikeLbl.Size = new System.Drawing.Size(227, 17);
            this.MaxVelSlikeLbl.TabIndex = 8;
            this.MaxVelSlikeLbl.Text = "Maksimalna veličina slike: 750x750";
            // 
            // vrstaUslugeLbl
            // 
            this.vrstaUslugeLbl.AutoSize = true;
            this.vrstaUslugeLbl.Location = new System.Drawing.Point(16, 315);
            this.vrstaUslugeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vrstaUslugeLbl.Name = "vrstaUslugeLbl";
            this.vrstaUslugeLbl.Size = new System.Drawing.Size(87, 17);
            this.vrstaUslugeLbl.TabIndex = 15;
            this.vrstaUslugeLbl.Text = "Vrsta usluge";
            // 
            // vrstaUslugeComboBox
            // 
            this.vrstaUslugeComboBox.FormattingEnabled = true;
            this.vrstaUslugeComboBox.Location = new System.Drawing.Point(140, 315);
            this.vrstaUslugeComboBox.Name = "vrstaUslugeComboBox";
            this.vrstaUslugeComboBox.Size = new System.Drawing.Size(184, 24);
            this.vrstaUslugeComboBox.TabIndex = 16;
            this.vrstaUslugeComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.vrstaUslugeComboBox_Validating);
            // 
            // DodajFrizera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 560);
            this.Controls.Add(this.vrstaUslugeComboBox);
            this.Controls.Add(this.vrstaUslugeLbl);
            this.Controls.Add(this.MaxVelSlikeLbl);
            this.Controls.Add(this.opisInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucitajSlikuBtn);
            this.Controls.Add(this.slikaInput);
            this.Controls.Add(this.SlikaLbl);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.DodajFrizeraBtn);
            this.Controls.Add(this.LozinkaLbl);
            this.Controls.Add(this.KorisnickoImeLbl);
            this.Controls.Add(this.PrezimeLbl);
            this.Controls.Add(this.KorisnickoImeInput);
            this.Controls.Add(this.LozinkaInput);
            this.Controls.Add(this.PrezimeInput);
            this.Controls.Add(this.ImeInput);
            this.Controls.Add(this.ImeLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DodajFrizera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj frizera";
            this.Load += new System.EventHandler(this.DodajFrizera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DodajFrizeraBtn;
        private System.Windows.Forms.Label LozinkaLbl;
        private System.Windows.Forms.Label KorisnickoImeLbl;
        private System.Windows.Forms.Label PrezimeLbl;
        private System.Windows.Forms.TextBox KorisnickoImeInput;
        private System.Windows.Forms.TextBox LozinkaInput;
        private System.Windows.Forms.TextBox PrezimeInput;
        private System.Windows.Forms.TextBox ImeInput;
        private System.Windows.Forms.Label ImeLbl;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.Button ucitajSlikuBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label SlikaLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox opisInput;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label MaxVelSlikeLbl;
        private System.Windows.Forms.ComboBox vrstaUslugeComboBox;
        private System.Windows.Forms.Label vrstaUslugeLbl;
    }
}