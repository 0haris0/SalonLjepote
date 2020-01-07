namespace eHairdresserSalon_UI.Services
{
    partial class UslugeListForm
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
            this.uslugeGridView = new System.Windows.Forms.DataGridView();
            this.UslugaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrajanjeMinute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivUslugeLbl = new System.Windows.Forms.Label();
            this.NazivUslugeInput = new System.Windows.Forms.TextBox();
            this.TraziBtn = new System.Windows.Forms.Button();
            this.DodajUsluguBtn = new System.Windows.Forms.Button();
            this.IzmijeniUsluguBtn = new System.Windows.Forms.Button();
            this.vrstaUslugeComboBox = new System.Windows.Forms.ComboBox();
            this.VrstaUslugeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uslugeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uslugeGridView
            // 
            this.uslugeGridView.AllowUserToAddRows = false;
            this.uslugeGridView.AllowUserToDeleteRows = false;
            this.uslugeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uslugeGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uslugeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uslugeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UslugaID,
            this.NazivUsluge,
            this.VrstaUsluge,
            this.TrajanjeMinute,
            this.CijenaUsluge});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uslugeGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.uslugeGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uslugeGridView.Location = new System.Drawing.Point(0, 126);
            this.uslugeGridView.Margin = new System.Windows.Forms.Padding(4);
            this.uslugeGridView.Name = "uslugeGridView";
            this.uslugeGridView.ReadOnly = true;
            this.uslugeGridView.RowHeadersWidth = 51;
            this.uslugeGridView.Size = new System.Drawing.Size(664, 419);
            this.uslugeGridView.TabIndex = 0;
            // 
            // UslugaID
            // 
            this.UslugaID.DataPropertyName = "UslugaID";
            this.UslugaID.HeaderText = "UslugaID";
            this.UslugaID.MinimumWidth = 6;
            this.UslugaID.Name = "UslugaID";
            this.UslugaID.ReadOnly = true;
            this.UslugaID.Visible = false;
            this.UslugaID.Width = 94;
            // 
            // NazivUsluge
            // 
            this.NazivUsluge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NazivUsluge.DataPropertyName = "NazivUsluge";
            this.NazivUsluge.FillWeight = 244.0486F;
            this.NazivUsluge.HeaderText = "Naziv usluge";
            this.NazivUsluge.MinimumWidth = 6;
            this.NazivUsluge.Name = "NazivUsluge";
            this.NazivUsluge.ReadOnly = true;
            this.NazivUsluge.Width = 300;
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
            // TrajanjeMinute
            // 
            this.TrajanjeMinute.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TrajanjeMinute.DataPropertyName = "TrajanjeMinute";
            this.TrajanjeMinute.FillWeight = 26.84527F;
            this.TrajanjeMinute.HeaderText = "Trajanje (minute)";
            this.TrajanjeMinute.MinimumWidth = 6;
            this.TrajanjeMinute.Name = "TrajanjeMinute";
            this.TrajanjeMinute.ReadOnly = true;
            this.TrajanjeMinute.Width = 75;
            // 
            // CijenaUsluge
            // 
            this.CijenaUsluge.DataPropertyName = "CijenaUsluge";
            this.CijenaUsluge.HeaderText = "Cijena";
            this.CijenaUsluge.MinimumWidth = 6;
            this.CijenaUsluge.Name = "CijenaUsluge";
            this.CijenaUsluge.ReadOnly = true;
            this.CijenaUsluge.Width = 76;
            // 
            // NazivUslugeLbl
            // 
            this.NazivUslugeLbl.AutoSize = true;
            this.NazivUslugeLbl.Location = new System.Drawing.Point(8, 22);
            this.NazivUslugeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NazivUslugeLbl.Name = "NazivUslugeLbl";
            this.NazivUslugeLbl.Size = new System.Drawing.Size(47, 17);
            this.NazivUslugeLbl.TabIndex = 1;
            this.NazivUslugeLbl.Text = "Naziv:";
            // 
            // NazivUslugeInput
            // 
            this.NazivUslugeInput.Location = new System.Drawing.Point(106, 17);
            this.NazivUslugeInput.Margin = new System.Windows.Forms.Padding(4);
            this.NazivUslugeInput.Name = "NazivUslugeInput";
            this.NazivUslugeInput.Size = new System.Drawing.Size(292, 22);
            this.NazivUslugeInput.TabIndex = 2;
            // 
            // TraziBtn
            // 
            this.TraziBtn.Location = new System.Drawing.Point(431, 16);
            this.TraziBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TraziBtn.Name = "TraziBtn";
            this.TraziBtn.Size = new System.Drawing.Size(113, 28);
            this.TraziBtn.TabIndex = 3;
            this.TraziBtn.Text = "Traži";
            this.TraziBtn.UseVisualStyleBackColor = true;
            this.TraziBtn.Click += new System.EventHandler(this.TraziBtn_Click);
            // 
            // DodajUsluguBtn
            // 
            this.DodajUsluguBtn.Location = new System.Drawing.Point(425, 68);
            this.DodajUsluguBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DodajUsluguBtn.Name = "DodajUsluguBtn";
            this.DodajUsluguBtn.Size = new System.Drawing.Size(113, 28);
            this.DodajUsluguBtn.TabIndex = 4;
            this.DodajUsluguBtn.Text = "Nova usluga";
            this.DodajUsluguBtn.UseVisualStyleBackColor = true;
            this.DodajUsluguBtn.Click += new System.EventHandler(this.DodajUsluguBtn_Click);
            // 
            // IzmijeniUsluguBtn
            // 
            this.IzmijeniUsluguBtn.Location = new System.Drawing.Point(546, 69);
            this.IzmijeniUsluguBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzmijeniUsluguBtn.Name = "IzmijeniUsluguBtn";
            this.IzmijeniUsluguBtn.Size = new System.Drawing.Size(113, 28);
            this.IzmijeniUsluguBtn.TabIndex = 5;
            this.IzmijeniUsluguBtn.Text = "Izmijeni uslugu";
            this.IzmijeniUsluguBtn.UseVisualStyleBackColor = true;
            this.IzmijeniUsluguBtn.Click += new System.EventHandler(this.IzmijeniUsluguBtn_Click);
            // 
            // vrstaUslugeComboBox
            // 
            this.vrstaUslugeComboBox.FormattingEnabled = true;
            this.vrstaUslugeComboBox.Location = new System.Drawing.Point(106, 66);
            this.vrstaUslugeComboBox.Name = "vrstaUslugeComboBox";
            this.vrstaUslugeComboBox.Size = new System.Drawing.Size(292, 24);
            this.vrstaUslugeComboBox.TabIndex = 6;
            this.vrstaUslugeComboBox.SelectedIndexChanged += new System.EventHandler(this.vrstaUslugeComboBox_SelectedIndexChanged);
            // 
            // VrstaUslugeLbl
            // 
            this.VrstaUslugeLbl.AutoSize = true;
            this.VrstaUslugeLbl.Location = new System.Drawing.Point(8, 69);
            this.VrstaUslugeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VrstaUslugeLbl.Name = "VrstaUslugeLbl";
            this.VrstaUslugeLbl.Size = new System.Drawing.Size(91, 17);
            this.VrstaUslugeLbl.TabIndex = 7;
            this.VrstaUslugeLbl.Text = "Vrsta usluge:";
            // 
            // UslugeListForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(664, 545);
            this.Controls.Add(this.VrstaUslugeLbl);
            this.Controls.Add(this.vrstaUslugeComboBox);
            this.Controls.Add(this.IzmijeniUsluguBtn);
            this.Controls.Add(this.DodajUsluguBtn);
            this.Controls.Add(this.TraziBtn);
            this.Controls.Add(this.NazivUslugeInput);
            this.Controls.Add(this.NazivUslugeLbl);
            this.Controls.Add(this.uslugeGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UslugeListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija usluge";
            this.Load += new System.EventHandler(this.UslugeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uslugeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uslugeGridView;
        private System.Windows.Forms.Label NazivUslugeLbl;
        private System.Windows.Forms.TextBox NazivUslugeInput;
        private System.Windows.Forms.Button TraziBtn;
        private System.Windows.Forms.Button DodajUsluguBtn;
        private System.Windows.Forms.Button IzmijeniUsluguBtn;
        private System.Windows.Forms.ComboBox vrstaUslugeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn UslugaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrajanjeMinute;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaUsluge;
        private System.Windows.Forms.Label VrstaUslugeLbl;
    }
}