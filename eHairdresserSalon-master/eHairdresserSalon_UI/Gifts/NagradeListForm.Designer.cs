namespace eHairdresserSalon_UI.Gifts
{
    partial class NagradeListForm
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
            this.printajBtn = new System.Windows.Forms.Button();
            this.IzmijeniNagraduBtn = new System.Windows.Forms.Button();
            this.DodajNagraduBtn = new System.Windows.Forms.Button();
            this.TraziButton = new System.Windows.Forms.Button();
            this.NazivNagradeInput = new System.Windows.Forms.TextBox();
            this.NazivLbl = new System.Windows.Forms.Label();
            this.NagradeDataGridView = new System.Windows.Forms.DataGridView();
            this.NagradaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Od = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Do = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NagradeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // printajBtn
            // 
            this.printajBtn.Location = new System.Drawing.Point(82, 80);
            this.printajBtn.Margin = new System.Windows.Forms.Padding(4);
            this.printajBtn.Name = "printajBtn";
            this.printajBtn.Size = new System.Drawing.Size(192, 28);
            this.printajBtn.TabIndex = 12;
            this.printajBtn.Text = "Spisak prijavljenih klijenata";
            this.printajBtn.UseVisualStyleBackColor = true;
            // 
            // IzmijeniNagraduBtn
            // 
            this.IzmijeniNagraduBtn.Location = new System.Drawing.Point(605, 29);
            this.IzmijeniNagraduBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IzmijeniNagraduBtn.Name = "IzmijeniNagraduBtn";
            this.IzmijeniNagraduBtn.Size = new System.Drawing.Size(129, 28);
            this.IzmijeniNagraduBtn.TabIndex = 11;
            this.IzmijeniNagraduBtn.Text = "Izmijeni nagradu";
            this.IzmijeniNagraduBtn.UseVisualStyleBackColor = true;
            this.IzmijeniNagraduBtn.Click += new System.EventHandler(this.IzmijeniNagraduBtn_Click);
            // 
            // DodajNagraduBtn
            // 
            this.DodajNagraduBtn.Location = new System.Drawing.Point(446, 28);
            this.DodajNagraduBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DodajNagraduBtn.Name = "DodajNagraduBtn";
            this.DodajNagraduBtn.Size = new System.Drawing.Size(133, 28);
            this.DodajNagraduBtn.TabIndex = 10;
            this.DodajNagraduBtn.Text = "Nova nagrada";
            this.DodajNagraduBtn.UseVisualStyleBackColor = true;
            this.DodajNagraduBtn.Click += new System.EventHandler(this.DodajNagraduBtn_Click);
            // 
            // TraziButton
            // 
            this.TraziButton.Location = new System.Drawing.Point(301, 29);
            this.TraziButton.Margin = new System.Windows.Forms.Padding(4);
            this.TraziButton.Name = "TraziButton";
            this.TraziButton.Size = new System.Drawing.Size(94, 28);
            this.TraziButton.TabIndex = 9;
            this.TraziButton.Text = "Traži";
            this.TraziButton.UseVisualStyleBackColor = true;
            this.TraziButton.Click += new System.EventHandler(this.TraziButton_Click);
            // 
            // NazivNagradeInput
            // 
            this.NazivNagradeInput.Location = new System.Drawing.Point(85, 31);
            this.NazivNagradeInput.Margin = new System.Windows.Forms.Padding(4);
            this.NazivNagradeInput.Name = "NazivNagradeInput";
            this.NazivNagradeInput.Size = new System.Drawing.Size(189, 22);
            this.NazivNagradeInput.TabIndex = 8;
            // 
            // NazivLbl
            // 
            this.NazivLbl.AutoSize = true;
            this.NazivLbl.Location = new System.Drawing.Point(22, 35);
            this.NazivLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NazivLbl.Name = "NazivLbl";
            this.NazivLbl.Size = new System.Drawing.Size(47, 17);
            this.NazivLbl.TabIndex = 7;
            this.NazivLbl.Text = "Naziv:";
            // 
            // NagradeDataGridView
            // 
            this.NagradeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NagradeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NagradeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NagradaID,
            this.Naziv,
            this.Od,
            this.Do});
            this.NagradeDataGridView.Location = new System.Drawing.Point(0, 144);
            this.NagradeDataGridView.Name = "NagradeDataGridView";
            this.NagradeDataGridView.RowHeadersWidth = 51;
            this.NagradeDataGridView.RowTemplate.Height = 24;
            this.NagradeDataGridView.Size = new System.Drawing.Size(753, 306);
            this.NagradeDataGridView.TabIndex = 13;
            // 
            // NagradaID
            // 
            this.NagradaID.DataPropertyName = "NagradaID";
            this.NagradaID.HeaderText = "NagradaID";
            this.NagradaID.MinimumWidth = 6;
            this.NagradaID.Name = "NagradaID";
            this.NagradaID.Visible = false;
            this.NagradaID.Width = 125;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 400;
            // 
            // Od
            // 
            this.Od.DataPropertyName = "Od";
            this.Od.HeaderText = "Od";
            this.Od.MinimumWidth = 6;
            this.Od.Name = "Od";
            this.Od.Width = 150;
            // 
            // Do
            // 
            this.Do.DataPropertyName = "Do";
            this.Do.HeaderText = "Do";
            this.Do.MinimumWidth = 6;
            this.Do.Name = "Do";
            this.Do.Width = 150;
            // 
            // NagradeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.NagradeDataGridView);
            this.Controls.Add(this.printajBtn);
            this.Controls.Add(this.IzmijeniNagraduBtn);
            this.Controls.Add(this.DodajNagraduBtn);
            this.Controls.Add(this.TraziButton);
            this.Controls.Add(this.NazivNagradeInput);
            this.Controls.Add(this.NazivLbl);
            this.Name = "NagradeListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija nagrada";
            ((System.ComponentModel.ISupportInitialize)(this.NagradeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printajBtn;
        private System.Windows.Forms.Button IzmijeniNagraduBtn;
        private System.Windows.Forms.Button DodajNagraduBtn;
        private System.Windows.Forms.Button TraziButton;
        private System.Windows.Forms.TextBox NazivNagradeInput;
        private System.Windows.Forms.Label NazivLbl;
        private System.Windows.Forms.DataGridView NagradeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NagradaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Od;
        private System.Windows.Forms.DataGridViewTextBoxColumn Do;
    }
}