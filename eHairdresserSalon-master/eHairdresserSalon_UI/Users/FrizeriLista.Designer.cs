namespace eHairdresserSalon_UI.Users
{
    partial class FrizeriLista
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
            this.frizeriDataGridView = new System.Windows.Forms.DataGridView();
            this.DodajFrizeraBtn = new System.Windows.Forms.Button();
            this.IzmijeniFrizeraBtn = new System.Windows.Forms.Button();
            this.FrizerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProsjecnaOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TretmanOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UslugaOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfilnaSlika = new System.Windows.Forms.DataGridViewImageColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.frizeriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // frizeriDataGridView
            // 
            this.frizeriDataGridView.AllowUserToAddRows = false;
            this.frizeriDataGridView.AllowUserToDeleteRows = false;
            this.frizeriDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.frizeriDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.frizeriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frizeriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FrizerID,
            this.ImePrezime,
            this.VrstaUsluge,
            this.Opis,
            this.SlikaThumb,
            this.ProsjecnaOcjena,
            this.TretmanOcjena,
            this.UslugaOcjena,
            this.ProfilnaSlika,
            this.KorisnickoIme});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.frizeriDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.frizeriDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.frizeriDataGridView.Location = new System.Drawing.Point(0, 64);
            this.frizeriDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.frizeriDataGridView.Name = "frizeriDataGridView";
            this.frizeriDataGridView.ReadOnly = true;
            this.frizeriDataGridView.RowHeadersWidth = 51;
            this.frizeriDataGridView.RowTemplate.Height = 80;
            this.frizeriDataGridView.Size = new System.Drawing.Size(925, 496);
            this.frizeriDataGridView.TabIndex = 0;
            // 
            // DodajFrizeraBtn
            // 
            this.DodajFrizeraBtn.Location = new System.Drawing.Point(632, 13);
            this.DodajFrizeraBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DodajFrizeraBtn.Name = "DodajFrizeraBtn";
            this.DodajFrizeraBtn.Size = new System.Drawing.Size(117, 28);
            this.DodajFrizeraBtn.TabIndex = 1;
            this.DodajFrizeraBtn.Text = "Novi uposlenik";
            this.DodajFrizeraBtn.UseVisualStyleBackColor = true;
            this.DodajFrizeraBtn.Click += new System.EventHandler(this.DodajFrizeraBtn_Click);
            // 
            // IzmijeniFrizeraBtn
            // 
            this.IzmijeniFrizeraBtn.Location = new System.Drawing.Point(770, 13);
            this.IzmijeniFrizeraBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzmijeniFrizeraBtn.Name = "IzmijeniFrizeraBtn";
            this.IzmijeniFrizeraBtn.Size = new System.Drawing.Size(142, 28);
            this.IzmijeniFrizeraBtn.TabIndex = 2;
            this.IzmijeniFrizeraBtn.Text = "Izmijeni uposlenika";
            this.IzmijeniFrizeraBtn.UseVisualStyleBackColor = true;
            this.IzmijeniFrizeraBtn.Click += new System.EventHandler(this.IzmijeniFrizeraBtn_Click);
            // 
            // FrizerID
            // 
            this.FrizerID.DataPropertyName = "FrizerID";
            this.FrizerID.HeaderText = "FrizerID";
            this.FrizerID.MinimumWidth = 6;
            this.FrizerID.Name = "FrizerID";
            this.FrizerID.ReadOnly = true;
            this.FrizerID.Visible = false;
            this.FrizerID.Width = 86;
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.MinimumWidth = 6;
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Width = 150;
            // 
            // VrstaUsluge
            // 
            this.VrstaUsluge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VrstaUsluge.DataPropertyName = "VrstaUsluge";
            this.VrstaUsluge.HeaderText = "Vrsta usluge";
            this.VrstaUsluge.MinimumWidth = 6;
            this.VrstaUsluge.Name = "VrstaUsluge";
            this.VrstaUsluge.ReadOnly = true;
            this.VrstaUsluge.Width = 160;
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 400;
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "Slika";
            this.SlikaThumb.MinimumWidth = 6;
            this.SlikaThumb.Name = "SlikaThumb";
            this.SlikaThumb.ReadOnly = true;
            this.SlikaThumb.Width = 160;
            // 
            // ProsjecnaOcjena
            // 
            this.ProsjecnaOcjena.DataPropertyName = "ProsjecnaOcjena";
            this.ProsjecnaOcjena.HeaderText = "Prosječna ocjena";
            this.ProsjecnaOcjena.MinimumWidth = 6;
            this.ProsjecnaOcjena.Name = "ProsjecnaOcjena";
            this.ProsjecnaOcjena.ReadOnly = true;
            this.ProsjecnaOcjena.Visible = false;
            this.ProsjecnaOcjena.Width = 146;
            // 
            // TretmanOcjena
            // 
            this.TretmanOcjena.DataPropertyName = "TretmanOcjena";
            this.TretmanOcjena.HeaderText = "TretmanOcjena";
            this.TretmanOcjena.MinimumWidth = 6;
            this.TretmanOcjena.Name = "TretmanOcjena";
            this.TretmanOcjena.ReadOnly = true;
            this.TretmanOcjena.Visible = false;
            this.TretmanOcjena.Width = 135;
            // 
            // UslugaOcjena
            // 
            this.UslugaOcjena.DataPropertyName = "UslugaOcjena";
            this.UslugaOcjena.HeaderText = "UslugaOcjena";
            this.UslugaOcjena.MinimumWidth = 6;
            this.UslugaOcjena.Name = "UslugaOcjena";
            this.UslugaOcjena.ReadOnly = true;
            this.UslugaOcjena.Visible = false;
            this.UslugaOcjena.Width = 126;
            // 
            // ProfilnaSlika
            // 
            this.ProfilnaSlika.DataPropertyName = "ProfilnaSlika";
            this.ProfilnaSlika.HeaderText = "ProfilnaSlika";
            this.ProfilnaSlika.MinimumWidth = 6;
            this.ProfilnaSlika.Name = "ProfilnaSlika";
            this.ProfilnaSlika.ReadOnly = true;
            this.ProfilnaSlika.Visible = false;
            this.ProfilnaSlika.Width = 92;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "KorisnickoIme";
            this.KorisnickoIme.MinimumWidth = 6;
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            this.KorisnickoIme.Visible = false;
            this.KorisnickoIme.Width = 124;
            // 
            // FrizeriLista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(925, 560);
            this.Controls.Add(this.IzmijeniFrizeraBtn);
            this.Controls.Add(this.DodajFrizeraBtn);
            this.Controls.Add(this.frizeriDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrizeriLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija uposlenika";
            this.Load += new System.EventHandler(this.FrizeriLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frizeriDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView frizeriDataGridView;
        private System.Windows.Forms.Button DodajFrizeraBtn;
        private System.Windows.Forms.Button IzmijeniFrizeraBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrizerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProsjecnaOcjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn TretmanOcjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn UslugaOcjena;
        private System.Windows.Forms.DataGridViewImageColumn ProfilnaSlika;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
    }
}