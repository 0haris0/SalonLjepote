namespace eHairdresserSalon_UI.Users
{
    partial class AktivirajKlijenta
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
            this.dataGridViewKlijenti = new System.Windows.Forms.DataGridView();
            this.btnAktiviraj = new System.Windows.Forms.Button();
            this.KlijentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LozinkaSalt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LozinkaHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerminiCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijenti1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijenti2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Termini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodatniTretmaniOcjene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UslugeOcjene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlijentiTakmicenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKlijenti
            // 
            this.dataGridViewKlijenti.AllowUserToAddRows = false;
            this.dataGridViewKlijenti.AllowUserToDeleteRows = false;
            this.dataGridViewKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KlijentID,
            this.Ime,
            this.Prezime,
            this.DatumRodjenja,
            this.Adresa,
            this.Email,
            this.BrojTelefona,
            this.Napomena,
            this.KorisnickoIme,
            this.LozinkaSalt,
            this.LozinkaHash,
            this.TerminiCount,
            this.Aktivan,
            this.Klijenti1,
            this.Klijenti2,
            this.Termini,
            this.DodatniTretmaniOcjene,
            this.UslugeOcjene,
            this.KlijentiTakmicenja});
            this.dataGridViewKlijenti.Location = new System.Drawing.Point(0, 41);
            this.dataGridViewKlijenti.Name = "dataGridViewKlijenti";
            this.dataGridViewKlijenti.Size = new System.Drawing.Size(645, 303);
            this.dataGridViewKlijenti.TabIndex = 0;
            // 
            // btnAktiviraj
            // 
            this.btnAktiviraj.Location = new System.Drawing.Point(552, 5);
            this.btnAktiviraj.Name = "btnAktiviraj";
            this.btnAktiviraj.Size = new System.Drawing.Size(78, 30);
            this.btnAktiviraj.TabIndex = 1;
            this.btnAktiviraj.Text = "Aktiviraj";
            this.btnAktiviraj.UseVisualStyleBackColor = true;
            this.btnAktiviraj.Click += new System.EventHandler(this.btnAktiviraj_Click);
            // 
            // KlijentID
            // 
            this.KlijentID.DataPropertyName = "KlijentID";
            this.KlijentID.HeaderText = "KlijentID";
            this.KlijentID.Name = "KlijentID";
            this.KlijentID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rođenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.DataPropertyName = "BrojTelefona";
            this.BrojTelefona.HeaderText = "Broj telefona";
            this.BrojTelefona.Name = "BrojTelefona";
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            this.Napomena.Visible = false;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "KorisnickoIme";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.Visible = false;
            // 
            // LozinkaSalt
            // 
            this.LozinkaSalt.DataPropertyName = "LozinkaSalt";
            this.LozinkaSalt.HeaderText = "LozinkaSalt";
            this.LozinkaSalt.Name = "LozinkaSalt";
            this.LozinkaSalt.Visible = false;
            // 
            // LozinkaHash
            // 
            this.LozinkaHash.DataPropertyName = "LozinkaHash";
            this.LozinkaHash.HeaderText = "LozinkaHash";
            this.LozinkaHash.Name = "LozinkaHash";
            this.LozinkaHash.Visible = false;
            // 
            // TerminiCount
            // 
            this.TerminiCount.DataPropertyName = "TerminiCount";
            this.TerminiCount.HeaderText = "TerminiCount";
            this.TerminiCount.Name = "TerminiCount";
            this.TerminiCount.Visible = false;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.Visible = false;
            // 
            // Klijenti1
            // 
            this.Klijenti1.DataPropertyName = "Klijenti1";
            this.Klijenti1.HeaderText = "Klijenti1";
            this.Klijenti1.Name = "Klijenti1";
            this.Klijenti1.Visible = false;
            // 
            // Klijenti2
            // 
            this.Klijenti2.DataPropertyName = "Klijenti2";
            this.Klijenti2.HeaderText = "Klijenti2";
            this.Klijenti2.Name = "Klijenti2";
            this.Klijenti2.Visible = false;
            // 
            // Termini
            // 
            this.Termini.DataPropertyName = "Termini";
            this.Termini.HeaderText = "Termini";
            this.Termini.Name = "Termini";
            this.Termini.Visible = false;
            // 
            // DodatniTretmaniOcjene
            // 
            this.DodatniTretmaniOcjene.DataPropertyName = "DodatniTretmaniOcjene";
            this.DodatniTretmaniOcjene.HeaderText = "DodatniTretmaniOcjene";
            this.DodatniTretmaniOcjene.Name = "DodatniTretmaniOcjene";
            this.DodatniTretmaniOcjene.Visible = false;
            // 
            // UslugeOcjene
            // 
            this.UslugeOcjene.DataPropertyName = "UslugeOcjene";
            this.UslugeOcjene.HeaderText = "UslugeOcjene";
            this.UslugeOcjene.Name = "UslugeOcjene";
            this.UslugeOcjene.Visible = false;
            // 
            // KlijentiTakmicenja
            // 
            this.KlijentiTakmicenja.DataPropertyName = "KlijentiTakmicenja";
            this.KlijentiTakmicenja.HeaderText = "KlijentiTakmicenja";
            this.KlijentiTakmicenja.Name = "KlijentiTakmicenja";
            this.KlijentiTakmicenja.Visible = false;
            // 
            // AktivirajKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 344);
            this.Controls.Add(this.btnAktiviraj);
            this.Controls.Add(this.dataGridViewKlijenti);
            this.Name = "AktivirajKlijenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktivacija klijenta";
            this.Load += new System.EventHandler(this.AktivirajKlijenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlijenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKlijenti;
        private System.Windows.Forms.Button btnAktiviraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojTelefona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn LozinkaSalt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LozinkaHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminiCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijenti1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijenti2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Termini;
        private System.Windows.Forms.DataGridViewTextBoxColumn DodatniTretmaniOcjene;
        private System.Windows.Forms.DataGridViewTextBoxColumn UslugeOcjene;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentiTakmicenja;
    }
}