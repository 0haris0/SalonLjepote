namespace eHairdresserSalon_UI.Gifts
{
    partial class DodajNagradu
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
            this.components = new System.ComponentModel.Container();
            this.dodajNagraduBtn = new System.Windows.Forms.Button();
            this.datumOdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumOdLbl = new System.Windows.Forms.Label();
            this.NazivNagradeInput = new System.Windows.Forms.TextBox();
            this.NazivNagradeLbl = new System.Windows.Forms.Label();
            this.datumDoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumDoLbl = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajNagraduBtn
            // 
            this.dodajNagraduBtn.Location = new System.Drawing.Point(262, 181);
            this.dodajNagraduBtn.Margin = new System.Windows.Forms.Padding(4);
            this.dodajNagraduBtn.Name = "dodajNagraduBtn";
            this.dodajNagraduBtn.Size = new System.Drawing.Size(100, 28);
            this.dodajNagraduBtn.TabIndex = 10;
            this.dodajNagraduBtn.Text = "Dodaj";
            this.dodajNagraduBtn.UseVisualStyleBackColor = true;
            this.dodajNagraduBtn.Click += new System.EventHandler(this.dodajNagraduBtn_Click);
            // 
            // datumOdDateTimePicker
            // 
            this.datumOdDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumOdDateTimePicker.Location = new System.Drawing.Point(79, 71);
            this.datumOdDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datumOdDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.datumOdDateTimePicker.MinDate = new System.DateTime(2019, 2, 4, 0, 0, 0, 0);
            this.datumOdDateTimePicker.Name = "datumOdDateTimePicker";
            this.datumOdDateTimePicker.Size = new System.Drawing.Size(131, 22);
            this.datumOdDateTimePicker.TabIndex = 7;
            // 
            // datumOdLbl
            // 
            this.datumOdLbl.AutoSize = true;
            this.datumOdLbl.Location = new System.Drawing.Point(14, 76);
            this.datumOdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datumOdLbl.Name = "datumOdLbl";
            this.datumOdLbl.Size = new System.Drawing.Size(27, 17);
            this.datumOdLbl.TabIndex = 11;
            this.datumOdLbl.Text = "Od";
            // 
            // NazivNagradeInput
            // 
            this.NazivNagradeInput.Location = new System.Drawing.Point(79, 29);
            this.NazivNagradeInput.Margin = new System.Windows.Forms.Padding(4);
            this.NazivNagradeInput.Name = "NazivNagradeInput";
            this.NazivNagradeInput.Size = new System.Drawing.Size(283, 22);
            this.NazivNagradeInput.TabIndex = 14;
            this.NazivNagradeInput.Validating += new System.ComponentModel.CancelEventHandler(this.NazivNagradeInput_Validating);
            // 
            // NazivNagradeLbl
            // 
            this.NazivNagradeLbl.AutoSize = true;
            this.NazivNagradeLbl.Location = new System.Drawing.Point(14, 32);
            this.NazivNagradeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NazivNagradeLbl.Name = "NazivNagradeLbl";
            this.NazivNagradeLbl.Size = new System.Drawing.Size(47, 17);
            this.NazivNagradeLbl.TabIndex = 15;
            this.NazivNagradeLbl.Text = "Naziv ";
            // 
            // datumDoDateTimePicker
            // 
            this.datumDoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDoDateTimePicker.Location = new System.Drawing.Point(79, 108);
            this.datumDoDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datumDoDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.datumDoDateTimePicker.MinDate = new System.DateTime(2019, 2, 4, 0, 0, 0, 0);
            this.datumDoDateTimePicker.Name = "datumDoDateTimePicker";
            this.datumDoDateTimePicker.Size = new System.Drawing.Size(131, 22);
            this.datumDoDateTimePicker.TabIndex = 16;
            // 
            // datumDoLbl
            // 
            this.datumDoLbl.AutoSize = true;
            this.datumDoLbl.Location = new System.Drawing.Point(15, 108);
            this.datumDoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datumDoLbl.Name = "datumDoLbl";
            this.datumDoLbl.Size = new System.Drawing.Size(26, 17);
            this.datumDoLbl.TabIndex = 17;
            this.datumDoLbl.Text = "Do";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DodajNagradu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 237);
            this.Controls.Add(this.datumDoDateTimePicker);
            this.Controls.Add(this.datumDoLbl);
            this.Controls.Add(this.NazivNagradeInput);
            this.Controls.Add(this.NazivNagradeLbl);
            this.Controls.Add(this.dodajNagraduBtn);
            this.Controls.Add(this.datumOdDateTimePicker);
            this.Controls.Add(this.datumOdLbl);
            this.Name = "DodajNagradu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj nagradu";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dodajNagraduBtn;
        private System.Windows.Forms.DateTimePicker datumOdDateTimePicker;
        private System.Windows.Forms.Label datumOdLbl;
        private System.Windows.Forms.TextBox NazivNagradeInput;
        private System.Windows.Forms.Label NazivNagradeLbl;
        private System.Windows.Forms.DateTimePicker datumDoDateTimePicker;
        private System.Windows.Forms.Label datumDoLbl;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}