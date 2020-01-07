namespace eHairdresserSalon_UI.Appointments
{
    partial class AktivniTermini
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
            this.ProcesirajBtn = new System.Windows.Forms.Button();
            this.TerminiGridView = new System.Windows.Forms.DataGridView();
            this.TerminID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zauzeto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlijentImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrizerImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TerminiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcesirajBtn
            // 
            this.ProcesirajBtn.Location = new System.Drawing.Point(694, 12);
            this.ProcesirajBtn.Name = "ProcesirajBtn";
            this.ProcesirajBtn.Size = new System.Drawing.Size(75, 23);
            this.ProcesirajBtn.TabIndex = 9;
            this.ProcesirajBtn.Text = "Procesiraj";
            this.ProcesirajBtn.UseVisualStyleBackColor = true;
            this.ProcesirajBtn.Click += new System.EventHandler(this.ProcesirajBtn_Click);
            // 
            // TerminiGridView
            // 
            this.TerminiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TerminiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TerminID,
            this.Zauzeto,
            this.Datum,
            this.Vrijeme,
            this.KlijentImePrezime,
            this.FrizerImePrezime,
            this.NazivUsluge});
            this.TerminiGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TerminiGridView.Location = new System.Drawing.Point(0, 56);
            this.TerminiGridView.Name = "TerminiGridView";
            this.TerminiGridView.Size = new System.Drawing.Size(790, 394);
            this.TerminiGridView.TabIndex = 5;
            // 
            // TerminID
            // 
            this.TerminID.DataPropertyName = "TerminID";
            this.TerminID.HeaderText = "TerminID";
            this.TerminID.Name = "TerminID";
            this.TerminID.Visible = false;
            // 
            // Zauzeto
            // 
            this.Zauzeto.DataPropertyName = "Zauzeto";
            this.Zauzeto.HeaderText = "Zauzeto";
            this.Zauzeto.Name = "Zauzeto";
            this.Zauzeto.Width = 50;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Vrijeme
            // 
            this.Vrijeme.DataPropertyName = "Vrijeme";
            this.Vrijeme.HeaderText = "Vrijeme";
            this.Vrijeme.Name = "Vrijeme";
            // 
            // KlijentImePrezime
            // 
            this.KlijentImePrezime.DataPropertyName = "KlijentImePrezime";
            this.KlijentImePrezime.HeaderText = "Klijent";
            this.KlijentImePrezime.Name = "KlijentImePrezime";
            this.KlijentImePrezime.Width = 150;
            // 
            // FrizerImePrezime
            // 
            this.FrizerImePrezime.DataPropertyName = "FrizerImePrezime";
            this.FrizerImePrezime.HeaderText = "Frizer";
            this.FrizerImePrezime.Name = "FrizerImePrezime";
            this.FrizerImePrezime.Width = 150;
            // 
            // NazivUsluge
            // 
            this.NazivUsluge.DataPropertyName = "NazivUsluge";
            this.NazivUsluge.HeaderText = "Usluga";
            this.NazivUsluge.Name = "NazivUsluge";
            this.NazivUsluge.Width = 200;
            // 
            // AktivniTermini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.ProcesirajBtn);
            this.Controls.Add(this.TerminiGridView);
            this.Name = "AktivniTermini";
            this.Text = "Aktivni termini";
            this.Load += new System.EventHandler(this.AktivniTermini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TerminiGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProcesirajBtn;
        private System.Windows.Forms.DataGridView TerminiGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Zauzeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrizerImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivUsluge;
    }
}