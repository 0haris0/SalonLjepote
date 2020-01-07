namespace eHairdresserSalon_UI.Appointments
{
    partial class AppointmentsListForm
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
            this.TerminiGridView = new System.Windows.Forms.DataGridView();
            this.datumTerminaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.traziTerminBtn = new System.Windows.Forms.Button();
            this.DodajNoviTerminBtn = new System.Windows.Forms.Button();
            this.IzmijeniTerminBtn = new System.Windows.Forms.Button();
            this.PrintajAktivneTermineBtn = new System.Windows.Forms.Button();
            this.TerminID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zauzeto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlijentImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrizerImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivTretmana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OcijenjenaUsluga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OcijenjenTretman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TerminiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TerminiGridView
            // 
            this.TerminiGridView.AllowUserToAddRows = false;
            this.TerminiGridView.AllowUserToDeleteRows = false;
            this.TerminiGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TerminiGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TerminiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TerminiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TerminID,
            this.Zauzeto,
            this.Datum,
            this.Vrijeme,
            this.KlijentImePrezime,
            this.FrizerImePrezime,
            this.NazivUsluge,
            this.NazivTretmana,
            this.OcijenjenaUsluga,
            this.OcijenjenTretman});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TerminiGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.TerminiGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TerminiGridView.Location = new System.Drawing.Point(0, 69);
            this.TerminiGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TerminiGridView.Name = "TerminiGridView";
            this.TerminiGridView.ReadOnly = true;
            this.TerminiGridView.RowHeadersWidth = 51;
            this.TerminiGridView.Size = new System.Drawing.Size(1013, 485);
            this.TerminiGridView.TabIndex = 0;
            // 
            // datumTerminaDateTimePicker
            // 
            this.datumTerminaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumTerminaDateTimePicker.Location = new System.Drawing.Point(16, 18);
            this.datumTerminaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datumTerminaDateTimePicker.Name = "datumTerminaDateTimePicker";
            this.datumTerminaDateTimePicker.Size = new System.Drawing.Size(128, 22);
            this.datumTerminaDateTimePicker.TabIndex = 1;
            // 
            // traziTerminBtn
            // 
            this.traziTerminBtn.Location = new System.Drawing.Point(179, 15);
            this.traziTerminBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.traziTerminBtn.Name = "traziTerminBtn";
            this.traziTerminBtn.Size = new System.Drawing.Size(100, 28);
            this.traziTerminBtn.TabIndex = 2;
            this.traziTerminBtn.Text = "Traži";
            this.traziTerminBtn.UseVisualStyleBackColor = true;
            this.traziTerminBtn.Click += new System.EventHandler(this.traziTerminBtn_Click);
            // 
            // DodajNoviTerminBtn
            // 
            this.DodajNoviTerminBtn.Location = new System.Drawing.Point(739, 15);
            this.DodajNoviTerminBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajNoviTerminBtn.Name = "DodajNoviTerminBtn";
            this.DodajNoviTerminBtn.Size = new System.Drawing.Size(119, 28);
            this.DodajNoviTerminBtn.TabIndex = 3;
            this.DodajNoviTerminBtn.Text = "Novi termin";
            this.DodajNoviTerminBtn.UseVisualStyleBackColor = true;
            this.DodajNoviTerminBtn.Click += new System.EventHandler(this.DodajNoviTerminBtn_Click);
            // 
            // IzmijeniTerminBtn
            // 
            this.IzmijeniTerminBtn.Location = new System.Drawing.Point(879, 15);
            this.IzmijeniTerminBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IzmijeniTerminBtn.Name = "IzmijeniTerminBtn";
            this.IzmijeniTerminBtn.Size = new System.Drawing.Size(119, 28);
            this.IzmijeniTerminBtn.TabIndex = 4;
            this.IzmijeniTerminBtn.Text = "Izmijeni termin";
            this.IzmijeniTerminBtn.UseVisualStyleBackColor = true;
            this.IzmijeniTerminBtn.Click += new System.EventHandler(this.IzmijeniTerminBtn_Click);
            // 
            // PrintajAktivneTermineBtn
            // 
            this.PrintajAktivneTermineBtn.Location = new System.Drawing.Point(472, 15);
            this.PrintajAktivneTermineBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintajAktivneTermineBtn.Name = "PrintajAktivneTermineBtn";
            this.PrintajAktivneTermineBtn.Size = new System.Drawing.Size(119, 28);
            this.PrintajAktivneTermineBtn.TabIndex = 5;
            this.PrintajAktivneTermineBtn.Text = "Aktivni termini";
            this.PrintajAktivneTermineBtn.UseVisualStyleBackColor = true;
            this.PrintajAktivneTermineBtn.Click += new System.EventHandler(this.PrintajAktivneTermineBtn_Click);
            // 
            // TerminID
            // 
            this.TerminID.DataPropertyName = "TerminID";
            this.TerminID.HeaderText = "TerminID";
            this.TerminID.MinimumWidth = 6;
            this.TerminID.Name = "TerminID";
            this.TerminID.ReadOnly = true;
            this.TerminID.Visible = false;
            this.TerminID.Width = 94;
            // 
            // Zauzeto
            // 
            this.Zauzeto.DataPropertyName = "Zauzeto";
            this.Zauzeto.HeaderText = "Zauzeto";
            this.Zauzeto.MinimumWidth = 6;
            this.Zauzeto.Name = "Zauzeto";
            this.Zauzeto.ReadOnly = true;
            this.Zauzeto.Width = 66;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 78;
            // 
            // Vrijeme
            // 
            this.Vrijeme.DataPropertyName = "Vrijeme";
            this.Vrijeme.HeaderText = "Vrijeme";
            this.Vrijeme.MinimumWidth = 6;
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.ReadOnly = true;
            this.Vrijeme.Width = 84;
            // 
            // KlijentImePrezime
            // 
            this.KlijentImePrezime.DataPropertyName = "KlijentImePrezime";
            this.KlijentImePrezime.HeaderText = "Klijent";
            this.KlijentImePrezime.MinimumWidth = 6;
            this.KlijentImePrezime.Name = "KlijentImePrezime";
            this.KlijentImePrezime.ReadOnly = true;
            this.KlijentImePrezime.Width = 75;
            // 
            // FrizerImePrezime
            // 
            this.FrizerImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FrizerImePrezime.DataPropertyName = "FrizerImePrezime";
            this.FrizerImePrezime.HeaderText = "Uposlenik";
            this.FrizerImePrezime.MinimumWidth = 6;
            this.FrizerImePrezime.Name = "FrizerImePrezime";
            this.FrizerImePrezime.ReadOnly = true;
            // 
            // NazivUsluge
            // 
            this.NazivUsluge.DataPropertyName = "NazivUsluge";
            this.NazivUsluge.HeaderText = "Usluga";
            this.NazivUsluge.MinimumWidth = 6;
            this.NazivUsluge.Name = "NazivUsluge";
            this.NazivUsluge.ReadOnly = true;
            this.NazivUsluge.Width = 81;
            // 
            // NazivTretmana
            // 
            this.NazivTretmana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivTretmana.DataPropertyName = "NazivTretmana";
            this.NazivTretmana.HeaderText = "Tretman";
            this.NazivTretmana.MinimumWidth = 6;
            this.NazivTretmana.Name = "NazivTretmana";
            this.NazivTretmana.ReadOnly = true;
            // 
            // OcijenjenaUsluga
            // 
            this.OcijenjenaUsluga.DataPropertyName = "OcijenjenaUsluga";
            this.OcijenjenaUsluga.HeaderText = "OcijenjenaUsluga";
            this.OcijenjenaUsluga.MinimumWidth = 6;
            this.OcijenjenaUsluga.Name = "OcijenjenaUsluga";
            this.OcijenjenaUsluga.ReadOnly = true;
            this.OcijenjenaUsluga.Visible = false;
            this.OcijenjenaUsluga.Width = 148;
            // 
            // OcijenjenTretman
            // 
            this.OcijenjenTretman.DataPropertyName = "OcijenjenTretman";
            this.OcijenjenTretman.HeaderText = "OcijenjenTretman";
            this.OcijenjenTretman.MinimumWidth = 6;
            this.OcijenjenTretman.Name = "OcijenjenTretman";
            this.OcijenjenTretman.ReadOnly = true;
            this.OcijenjenTretman.Visible = false;
            this.OcijenjenTretman.Width = 149;
            // 
            // AppointmentsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 554);
            this.Controls.Add(this.PrintajAktivneTermineBtn);
            this.Controls.Add(this.IzmijeniTerminBtn);
            this.Controls.Add(this.DodajNoviTerminBtn);
            this.Controls.Add(this.traziTerminBtn);
            this.Controls.Add(this.datumTerminaDateTimePicker);
            this.Controls.Add(this.TerminiGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AppointmentsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija termina";
            this.Load += new System.EventHandler(this.AppointmentsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TerminiGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TerminiGridView;
        private System.Windows.Forms.DateTimePicker datumTerminaDateTimePicker;
        private System.Windows.Forms.Button traziTerminBtn;
        private System.Windows.Forms.Button DodajNoviTerminBtn;
        private System.Windows.Forms.Button IzmijeniTerminBtn;
        private System.Windows.Forms.Button PrintajAktivneTermineBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Zauzeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrizerImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivTretmana;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcijenjenaUsluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcijenjenTretman;
    }
}