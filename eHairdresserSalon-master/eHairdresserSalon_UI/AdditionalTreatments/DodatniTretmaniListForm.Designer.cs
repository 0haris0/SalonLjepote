namespace eHairdresserSalon_UI.AdditionalTreatments
{
    partial class DodatniTretmaniListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dodatniTretmaniGridView = new System.Windows.Forms.DataGridView();
            this.NazivTretmanaLbl = new System.Windows.Forms.Label();
            this.NazivTretmanaInput = new System.Windows.Forms.TextBox();
            this.TraziBtn = new System.Windows.Forms.Button();
            this.DodajDodatniTretmanBtn = new System.Windows.Forms.Button();
            this.IzmijeniBtn = new System.Windows.Forms.Button();
            this.TretmanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivTretmana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaTretmana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaUslugeLbl = new System.Windows.Forms.Label();
            this.vrstaUslugeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dodatniTretmaniGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dodatniTretmaniGridView
            // 
            this.dodatniTretmaniGridView.AllowUserToAddRows = false;
            this.dodatniTretmaniGridView.AllowUserToDeleteRows = false;
            this.dodatniTretmaniGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dodatniTretmaniGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dodatniTretmaniGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dodatniTretmaniGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TretmanID,
            this.NazivTretmana,
            this.VrstaUsluge,
            this.CijenaTretmana});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dodatniTretmaniGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dodatniTretmaniGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dodatniTretmaniGridView.Location = new System.Drawing.Point(0, 123);
            this.dodatniTretmaniGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dodatniTretmaniGridView.Name = "dodatniTretmaniGridView";
            this.dodatniTretmaniGridView.ReadOnly = true;
            this.dodatniTretmaniGridView.RowHeadersWidth = 51;
            this.dodatniTretmaniGridView.Size = new System.Drawing.Size(828, 431);
            this.dodatniTretmaniGridView.TabIndex = 0;
            // 
            // NazivTretmanaLbl
            // 
            this.NazivTretmanaLbl.AutoSize = true;
            this.NazivTretmanaLbl.Location = new System.Drawing.Point(17, 71);
            this.NazivTretmanaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NazivTretmanaLbl.Name = "NazivTretmanaLbl";
            this.NazivTretmanaLbl.Size = new System.Drawing.Size(47, 17);
            this.NazivTretmanaLbl.TabIndex = 1;
            this.NazivTretmanaLbl.Text = "Naziv:";
            // 
            // NazivTretmanaInput
            // 
            this.NazivTretmanaInput.Location = new System.Drawing.Point(75, 67);
            this.NazivTretmanaInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NazivTretmanaInput.Name = "NazivTretmanaInput";
            this.NazivTretmanaInput.Size = new System.Drawing.Size(353, 22);
            this.NazivTretmanaInput.TabIndex = 2;
            // 
            // TraziBtn
            // 
            this.TraziBtn.Location = new System.Drawing.Point(448, 65);
            this.TraziBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TraziBtn.Name = "TraziBtn";
            this.TraziBtn.Size = new System.Drawing.Size(121, 28);
            this.TraziBtn.TabIndex = 3;
            this.TraziBtn.Text = "Traži";
            this.TraziBtn.UseVisualStyleBackColor = true;
            this.TraziBtn.Click += new System.EventHandler(this.TraziBtn_Click);
            // 
            // DodajDodatniTretmanBtn
            // 
            this.DodajDodatniTretmanBtn.Location = new System.Drawing.Point(542, 16);
            this.DodajDodatniTretmanBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajDodatniTretmanBtn.Name = "DodajDodatniTretmanBtn";
            this.DodajDodatniTretmanBtn.Size = new System.Drawing.Size(121, 28);
            this.DodajDodatniTretmanBtn.TabIndex = 4;
            this.DodajDodatniTretmanBtn.Text = "Novi tretman";
            this.DodajDodatniTretmanBtn.UseVisualStyleBackColor = true;
            this.DodajDodatniTretmanBtn.Click += new System.EventHandler(this.DodajDodatniTretmanBtn_Click);
            // 
            // IzmijeniBtn
            // 
            this.IzmijeniBtn.Location = new System.Drawing.Point(694, 16);
            this.IzmijeniBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IzmijeniBtn.Name = "IzmijeniBtn";
            this.IzmijeniBtn.Size = new System.Drawing.Size(121, 28);
            this.IzmijeniBtn.TabIndex = 5;
            this.IzmijeniBtn.Text = "Izmijeni tretman";
            this.IzmijeniBtn.UseVisualStyleBackColor = true;
            this.IzmijeniBtn.Click += new System.EventHandler(this.IzmijeniBtn_Click);
            // 
            // TretmanID
            // 
            this.TretmanID.DataPropertyName = "TretmanID";
            this.TretmanID.HeaderText = "TretmanID";
            this.TretmanID.MinimumWidth = 6;
            this.TretmanID.Name = "TretmanID";
            this.TretmanID.ReadOnly = true;
            this.TretmanID.Visible = false;
            this.TretmanID.Width = 103;
            // 
            // NazivTretmana
            // 
            this.NazivTretmana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NazivTretmana.DataPropertyName = "NazivTretmana";
            this.NazivTretmana.HeaderText = "Naziv";
            this.NazivTretmana.MinimumWidth = 6;
            this.NazivTretmana.Name = "NazivTretmana";
            this.NazivTretmana.ReadOnly = true;
            this.NazivTretmana.Width = 500;
            // 
            // VrstaUsluge
            // 
            this.VrstaUsluge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VrstaUsluge.DataPropertyName = "VrstaUsluge";
            this.VrstaUsluge.HeaderText = "Vrsta usluge";
            this.VrstaUsluge.MinimumWidth = 6;
            this.VrstaUsluge.Name = "VrstaUsluge";
            this.VrstaUsluge.ReadOnly = true;
            this.VrstaUsluge.Width = 199;
            // 
            // CijenaTretmana
            // 
            this.CijenaTretmana.DataPropertyName = "Cijena";
            this.CijenaTretmana.HeaderText = "Cijena";
            this.CijenaTretmana.MinimumWidth = 6;
            this.CijenaTretmana.Name = "CijenaTretmana";
            this.CijenaTretmana.ReadOnly = true;
            this.CijenaTretmana.Width = 76;
            // 
            // VrstaUslugeLbl
            // 
            this.VrstaUslugeLbl.AutoSize = true;
            this.VrstaUslugeLbl.Location = new System.Drawing.Point(14, 23);
            this.VrstaUslugeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VrstaUslugeLbl.Name = "VrstaUslugeLbl";
            this.VrstaUslugeLbl.Size = new System.Drawing.Size(91, 17);
            this.VrstaUslugeLbl.TabIndex = 9;
            this.VrstaUslugeLbl.Text = "Vrsta usluge:";
            // 
            // vrstaUslugeComboBox
            // 
            this.vrstaUslugeComboBox.FormattingEnabled = true;
            this.vrstaUslugeComboBox.Location = new System.Drawing.Point(112, 20);
            this.vrstaUslugeComboBox.Name = "vrstaUslugeComboBox";
            this.vrstaUslugeComboBox.Size = new System.Drawing.Size(292, 24);
            this.vrstaUslugeComboBox.TabIndex = 8;
            // 
            // DodatniTretmaniListForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(828, 554);
            this.Controls.Add(this.VrstaUslugeLbl);
            this.Controls.Add(this.vrstaUslugeComboBox);
            this.Controls.Add(this.IzmijeniBtn);
            this.Controls.Add(this.DodajDodatniTretmanBtn);
            this.Controls.Add(this.TraziBtn);
            this.Controls.Add(this.NazivTretmanaInput);
            this.Controls.Add(this.NazivTretmanaLbl);
            this.Controls.Add(this.dodatniTretmaniGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DodatniTretmaniListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija dodatnih tretmana";
            this.Load += new System.EventHandler(this.DodatniTretmaniListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dodatniTretmaniGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dodatniTretmaniGridView;
        private System.Windows.Forms.Label NazivTretmanaLbl;
        private System.Windows.Forms.TextBox NazivTretmanaInput;
        private System.Windows.Forms.Button TraziBtn;
        private System.Windows.Forms.Button DodajDodatniTretmanBtn;
        private System.Windows.Forms.Button IzmijeniBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TretmanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivTretmana;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaTretmana;
        private System.Windows.Forms.Label VrstaUslugeLbl;
        private System.Windows.Forms.ComboBox vrstaUslugeComboBox;
    }
}