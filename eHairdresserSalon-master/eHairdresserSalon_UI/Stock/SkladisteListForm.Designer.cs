namespace eHairdresserSalon_UI.Stock
{
    partial class SkladisteListForm
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
            this.SkladisteGridView = new System.Windows.Forms.DataGridView();
            this.IzmijeniProizvodBtn = new System.Windows.Forms.Button();
            this.SifraNazivLbl = new System.Windows.Forms.Label();
            this.pretragaInput = new System.Windows.Forms.TextBox();
            this.TraziBtn = new System.Windows.Forms.Button();
            this.SkladisteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivTretmana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SkladisteGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SkladisteGridView
            // 
            this.SkladisteGridView.AllowUserToAddRows = false;
            this.SkladisteGridView.AllowUserToDeleteRows = false;
            this.SkladisteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SkladisteGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkladisteID,
            this.NazivTretmana,
            this.Kolicina});
            this.SkladisteGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SkladisteGridView.Location = new System.Drawing.Point(0, 94);
            this.SkladisteGridView.Name = "SkladisteGridView";
            this.SkladisteGridView.ReadOnly = true;
            this.SkladisteGridView.Size = new System.Drawing.Size(393, 370);
            this.SkladisteGridView.TabIndex = 0;
            // 
            // IzmijeniProizvodBtn
            // 
            this.IzmijeniProizvodBtn.Location = new System.Drawing.Point(282, 53);
            this.IzmijeniProizvodBtn.Name = "IzmijeniProizvodBtn";
            this.IzmijeniProizvodBtn.Size = new System.Drawing.Size(99, 23);
            this.IzmijeniProizvodBtn.TabIndex = 5;
            this.IzmijeniProizvodBtn.Text = "Izmijeni količinu";
            this.IzmijeniProizvodBtn.UseVisualStyleBackColor = true;
            this.IzmijeniProizvodBtn.Click += new System.EventHandler(this.IzmijeniProizvodBtn_Click);
            // 
            // SifraNazivLbl
            // 
            this.SifraNazivLbl.AutoSize = true;
            this.SifraNazivLbl.Location = new System.Drawing.Point(12, 15);
            this.SifraNazivLbl.Name = "SifraNazivLbl";
            this.SifraNazivLbl.Size = new System.Drawing.Size(49, 13);
            this.SifraNazivLbl.TabIndex = 1;
            this.SifraNazivLbl.Text = "Tretman:";
            // 
            // pretragaInput
            // 
            this.pretragaInput.Location = new System.Drawing.Point(67, 12);
            this.pretragaInput.Name = "pretragaInput";
            this.pretragaInput.Size = new System.Drawing.Size(196, 20);
            this.pretragaInput.TabIndex = 2;
            // 
            // TraziBtn
            // 
            this.TraziBtn.Location = new System.Drawing.Point(282, 10);
            this.TraziBtn.Name = "TraziBtn";
            this.TraziBtn.Size = new System.Drawing.Size(99, 23);
            this.TraziBtn.TabIndex = 3;
            this.TraziBtn.Text = "Traži";
            this.TraziBtn.UseVisualStyleBackColor = true;
            this.TraziBtn.Click += new System.EventHandler(this.TraziBtn_Click);
            // 
            // SkladisteID
            // 
            this.SkladisteID.DataPropertyName = "SkladisteID";
            this.SkladisteID.HeaderText = "SkladisteID";
            this.SkladisteID.Name = "SkladisteID";
            this.SkladisteID.ReadOnly = true;
            this.SkladisteID.Visible = false;
            this.SkladisteID.Width = 180;
            // 
            // NazivTretmana
            // 
            this.NazivTretmana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivTretmana.DataPropertyName = "NazivTretmana";
            this.NazivTretmana.HeaderText = "Naziv tretmana";
            this.NazivTretmana.Name = "NazivTretmana";
            this.NazivTretmana.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            this.Kolicina.Width = 50;
            // 
            // SkladisteListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 464);
            this.Controls.Add(this.IzmijeniProizvodBtn);
            this.Controls.Add(this.TraziBtn);
            this.Controls.Add(this.pretragaInput);
            this.Controls.Add(this.SifraNazivLbl);
            this.Controls.Add(this.SkladisteGridView);
            this.Name = "SkladisteListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija skladišta";
            this.Load += new System.EventHandler(this.SkladisteListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SkladisteGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SkladisteGridView;
        private System.Windows.Forms.Button IzmijeniProizvodBtn;
        private System.Windows.Forms.Label SifraNazivLbl;
        private System.Windows.Forms.TextBox pretragaInput;
        private System.Windows.Forms.Button TraziBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkladisteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivTretmana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
    }
}