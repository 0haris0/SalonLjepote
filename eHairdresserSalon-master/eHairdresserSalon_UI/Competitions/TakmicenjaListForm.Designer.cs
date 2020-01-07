namespace eHairdresserSalon_UI.Competitions
{
    partial class TakmicenjaListForm
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
            this.TakmicenjaGridView = new System.Windows.Forms.DataGridView();
            this.TakmicenjeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mjesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrizerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjestoLbl = new System.Windows.Forms.Label();
            this.MjestoInput = new System.Windows.Forms.TextBox();
            this.TraziButton = new System.Windows.Forms.Button();
            this.DodajTakmicenjeBtn = new System.Windows.Forms.Button();
            this.IzmijeniTakmicenjeBtn = new System.Windows.Forms.Button();
            this.printajBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TakmicenjaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TakmicenjaGridView
            // 
            this.TakmicenjaGridView.AllowUserToAddRows = false;
            this.TakmicenjaGridView.AllowUserToDeleteRows = false;
            this.TakmicenjaGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TakmicenjaGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TakmicenjaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TakmicenjaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TakmicenjeID,
            this.Naziv,
            this.Datum,
            this.Mjesto,
            this.FrizerID,
            this.Opis});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TakmicenjaGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.TakmicenjaGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TakmicenjaGridView.Location = new System.Drawing.Point(0, 68);
            this.TakmicenjaGridView.Name = "TakmicenjaGridView";
            this.TakmicenjaGridView.ReadOnly = true;
            this.TakmicenjaGridView.Size = new System.Drawing.Size(991, 382);
            this.TakmicenjaGridView.TabIndex = 0;
            // 
            // TakmicenjeID
            // 
            this.TakmicenjeID.DataPropertyName = "TakmicenjeID";
            this.TakmicenjeID.HeaderText = "TakmicenjeID";
            this.TakmicenjeID.Name = "TakmicenjeID";
            this.TakmicenjeID.ReadOnly = true;
            this.TakmicenjeID.Visible = false;
            this.TakmicenjeID.Width = 98;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 59;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 63;
            // 
            // Mjesto
            // 
            this.Mjesto.DataPropertyName = "Mjesto";
            this.Mjesto.HeaderText = "Mjesto";
            this.Mjesto.Name = "Mjesto";
            this.Mjesto.ReadOnly = true;
            this.Mjesto.Width = 63;
            // 
            // FrizerID
            // 
            this.FrizerID.DataPropertyName = "FrizerImePrezime";
            this.FrizerID.HeaderText = "Frizer";
            this.FrizerID.Name = "FrizerID";
            this.FrizerID.ReadOnly = true;
            this.FrizerID.Width = 57;
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // MjestoLbl
            // 
            this.MjestoLbl.AutoSize = true;
            this.MjestoLbl.Location = new System.Drawing.Point(4, 26);
            this.MjestoLbl.Name = "MjestoLbl";
            this.MjestoLbl.Size = new System.Drawing.Size(41, 13);
            this.MjestoLbl.TabIndex = 1;
            this.MjestoLbl.Text = "Mjesto:";
            // 
            // MjestoInput
            // 
            this.MjestoInput.Location = new System.Drawing.Point(51, 23);
            this.MjestoInput.Name = "MjestoInput";
            this.MjestoInput.Size = new System.Drawing.Size(143, 20);
            this.MjestoInput.TabIndex = 2;
            // 
            // TraziButton
            // 
            this.TraziButton.Location = new System.Drawing.Point(213, 21);
            this.TraziButton.Name = "TraziButton";
            this.TraziButton.Size = new System.Drawing.Size(144, 23);
            this.TraziButton.TabIndex = 3;
            this.TraziButton.Text = "Traži";
            this.TraziButton.UseVisualStyleBackColor = true;
            this.TraziButton.Click += new System.EventHandler(this.TraziButton_Click);
            // 
            // DodajTakmicenjeBtn
            // 
            this.DodajTakmicenjeBtn.Location = new System.Drawing.Point(668, 21);
            this.DodajTakmicenjeBtn.Name = "DodajTakmicenjeBtn";
            this.DodajTakmicenjeBtn.Size = new System.Drawing.Size(144, 23);
            this.DodajTakmicenjeBtn.TabIndex = 4;
            this.DodajTakmicenjeBtn.Text = "Novo takmičenje";
            this.DodajTakmicenjeBtn.UseVisualStyleBackColor = true;
            this.DodajTakmicenjeBtn.Click += new System.EventHandler(this.DodajTakmicenjeBtn_Click);
            // 
            // IzmijeniTakmicenjeBtn
            // 
            this.IzmijeniTakmicenjeBtn.Location = new System.Drawing.Point(831, 21);
            this.IzmijeniTakmicenjeBtn.Name = "IzmijeniTakmicenjeBtn";
            this.IzmijeniTakmicenjeBtn.Size = new System.Drawing.Size(144, 23);
            this.IzmijeniTakmicenjeBtn.TabIndex = 5;
            this.IzmijeniTakmicenjeBtn.Text = "Izmijeni takmičenje";
            this.IzmijeniTakmicenjeBtn.UseVisualStyleBackColor = true;
            this.IzmijeniTakmicenjeBtn.Click += new System.EventHandler(this.IzmijeniTakmicenjeBtn_Click);
            // 
            // printajBtn
            // 
            this.printajBtn.Location = new System.Drawing.Point(445, 21);
            this.printajBtn.Name = "printajBtn";
            this.printajBtn.Size = new System.Drawing.Size(144, 23);
            this.printajBtn.TabIndex = 6;
            this.printajBtn.Text = "Spisak prijavljenih klijenata";
            this.printajBtn.UseVisualStyleBackColor = true;
            this.printajBtn.Click += new System.EventHandler(this.printajBtn_Click);
            // 
            // TakmicenjaListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.printajBtn);
            this.Controls.Add(this.IzmijeniTakmicenjeBtn);
            this.Controls.Add(this.DodajTakmicenjeBtn);
            this.Controls.Add(this.TraziButton);
            this.Controls.Add(this.MjestoInput);
            this.Controls.Add(this.MjestoLbl);
            this.Controls.Add(this.TakmicenjaGridView);
            this.Name = "TakmicenjaListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija takmičenja";
            this.Load += new System.EventHandler(this.TakmicenjaListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TakmicenjaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TakmicenjaGridView;
        private System.Windows.Forms.Label MjestoLbl;
        private System.Windows.Forms.TextBox MjestoInput;
        private System.Windows.Forms.Button TraziButton;
        private System.Windows.Forms.Button DodajTakmicenjeBtn;
        private System.Windows.Forms.Button IzmijeniTakmicenjeBtn;
        private System.Windows.Forms.Button printajBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakmicenjeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mjesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrizerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}