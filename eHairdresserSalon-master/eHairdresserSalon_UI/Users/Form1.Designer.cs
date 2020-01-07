using System;

namespace eHairdresserSalon_UI
{
    partial class IndexForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.KlijentiGridView = new System.Windows.Forms.DataGridView();
            this.dodajKlijentaButton = new System.Windows.Forms.Button();
            this.ImePrezimeLbl = new System.Windows.Forms.Label();
            this.imePrezimeInput = new System.Windows.Forms.TextBox();
            this.traziButton = new System.Windows.Forms.Button();
            this.izmijeniKlijentaButton = new System.Windows.Forms.Button();
            this.rodjendaniBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.KlijentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.KlijentiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // KlijentiGridView
            // 
            this.KlijentiGridView.AllowUserToAddRows = false;
            this.KlijentiGridView.AllowUserToDeleteRows = false;
            this.KlijentiGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.KlijentiGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.KlijentiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KlijentiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KlijentID,
            this.Ime,
            this.Prezime,
            this.DatumRodjenja,
            this.Adresa,
            this.Email,
            this.BrojTelefona,
            this.Napomena,
            this.KorisnickoIme});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KlijentiGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.KlijentiGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KlijentiGridView.Location = new System.Drawing.Point(0, 88);
            this.KlijentiGridView.Name = "KlijentiGridView";
            this.KlijentiGridView.ReadOnly = true;
            this.KlijentiGridView.Size = new System.Drawing.Size(1065, 362);
            this.KlijentiGridView.TabIndex = 1;
            // 
            // dodajKlijentaButton
            // 
            this.dodajKlijentaButton.Location = new System.Drawing.Point(785, 12);
            this.dodajKlijentaButton.Name = "dodajKlijentaButton";
            this.dodajKlijentaButton.Size = new System.Drawing.Size(123, 23);
            this.dodajKlijentaButton.TabIndex = 2;
            this.dodajKlijentaButton.Text = "Novi klijent";
            this.dodajKlijentaButton.UseVisualStyleBackColor = true;
            this.dodajKlijentaButton.Click += new System.EventHandler(this.dodajKlijentaButton_Click);
            // 
            // ImePrezimeLbl
            // 
            this.ImePrezimeLbl.AutoSize = true;
            this.ImePrezimeLbl.Location = new System.Drawing.Point(13, 15);
            this.ImePrezimeLbl.Name = "ImePrezimeLbl";
            this.ImePrezimeLbl.Size = new System.Drawing.Size(71, 13);
            this.ImePrezimeLbl.TabIndex = 3;
            this.ImePrezimeLbl.Text = "Ime i prezime:";
            // 
            // imePrezimeInput
            // 
            this.imePrezimeInput.Location = new System.Drawing.Point(99, 12);
            this.imePrezimeInput.Name = "imePrezimeInput";
            this.imePrezimeInput.Size = new System.Drawing.Size(241, 20);
            this.imePrezimeInput.TabIndex = 4;
            // 
            // traziButton
            // 
            this.traziButton.Location = new System.Drawing.Point(370, 12);
            this.traziButton.Name = "traziButton";
            this.traziButton.Size = new System.Drawing.Size(123, 23);
            this.traziButton.TabIndex = 5;
            this.traziButton.Text = "Traži";
            this.traziButton.UseVisualStyleBackColor = true;
            this.traziButton.Click += new System.EventHandler(this.traziButton_Click);
            // 
            // izmijeniKlijentaButton
            // 
            this.izmijeniKlijentaButton.Location = new System.Drawing.Point(930, 12);
            this.izmijeniKlijentaButton.Name = "izmijeniKlijentaButton";
            this.izmijeniKlijentaButton.Size = new System.Drawing.Size(123, 23);
            this.izmijeniKlijentaButton.TabIndex = 6;
            this.izmijeniKlijentaButton.Text = "Izmijeni klijenta";
            this.izmijeniKlijentaButton.UseVisualStyleBackColor = true;
            this.izmijeniKlijentaButton.Click += new System.EventHandler(this.izmijeniKlijentaButton_Click);
            // 
            // rodjendaniBtn
            // 
            this.rodjendaniBtn.Location = new System.Drawing.Point(158, 50);
            this.rodjendaniBtn.Name = "rodjendaniBtn";
            this.rodjendaniBtn.Size = new System.Drawing.Size(123, 23);
            this.rodjendaniBtn.TabIndex = 7;
            this.rodjendaniBtn.Text = "Današnji rođendani";
            this.rodjendaniBtn.UseVisualStyleBackColor = true;
            this.rodjendaniBtn.Click += new System.EventHandler(this.rodjendaniBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aktivacija klijenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KlijentID
            // 
            this.KlijentID.DataPropertyName = "KlijentID";
            this.KlijentID.HeaderText = "KlijentID";
            this.KlijentID.Name = "KlijentID";
            this.KlijentID.ReadOnly = true;
            this.KlijentID.Visible = false;
            this.KlijentID.Width = 71;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rođenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            this.DatumRodjenja.Width = 102;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            this.Adresa.Width = 65;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 57;
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.DataPropertyName = "BrojTelefona";
            this.BrojTelefona.HeaderText = "Broj telefona";
            this.BrojTelefona.Name = "BrojTelefona";
            this.BrojTelefona.ReadOnly = true;
            this.BrojTelefona.Width = 91;
            // 
            // Napomena
            // 
            this.Napomena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "KorisnickoIme";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            this.KorisnickoIme.Visible = false;
            this.KorisnickoIme.Width = 98;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rodjendaniBtn);
            this.Controls.Add(this.izmijeniKlijentaButton);
            this.Controls.Add(this.traziButton);
            this.Controls.Add(this.imePrezimeInput);
            this.Controls.Add(this.ImePrezimeLbl);
            this.Controls.Add(this.dodajKlijentaButton);
            this.Controls.Add(this.KlijentiGridView);
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija klijenta";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KlijentiGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void IndexForm_Load(object sender, EventArgs e)
        //{
        //    //BindForm();
        //}

        #endregion
        private System.Windows.Forms.DataGridView KlijentiGridView;
        private System.Windows.Forms.Button dodajKlijentaButton;
        private System.Windows.Forms.Label ImePrezimeLbl;
        private System.Windows.Forms.TextBox imePrezimeInput;
        private System.Windows.Forms.Button traziButton;
        private System.Windows.Forms.Button izmijeniKlijentaButton;
        private System.Windows.Forms.Button rodjendaniBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojTelefona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
    }
}

