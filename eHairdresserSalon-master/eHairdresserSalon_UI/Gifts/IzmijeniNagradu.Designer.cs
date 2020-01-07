namespace eHairdresserSalon_UI.Gifts
{
    partial class IzmijeniNagradu
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
            this.datumDoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumDoLbl = new System.Windows.Forms.Label();
            this.NazivNagradeInput = new System.Windows.Forms.TextBox();
            this.NazivNagradeLbl = new System.Windows.Forms.Label();
            this.izmijeniNagraduBtn = new System.Windows.Forms.Button();
            this.datumOdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumOdLbl = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // datumDoDateTimePicker
            // 
            this.datumDoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDoDateTimePicker.Location = new System.Drawing.Point(89, 105);
            this.datumDoDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datumDoDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.datumDoDateTimePicker.MinDate = new System.DateTime(2019, 2, 4, 0, 0, 0, 0);
            this.datumDoDateTimePicker.Name = "datumDoDateTimePicker";
            this.datumDoDateTimePicker.Size = new System.Drawing.Size(131, 22);
            this.datumDoDateTimePicker.TabIndex = 23;
            // 
            // datumDoLbl
            // 
            this.datumDoLbl.AutoSize = true;
            this.datumDoLbl.Location = new System.Drawing.Point(25, 105);
            this.datumDoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datumDoLbl.Name = "datumDoLbl";
            this.datumDoLbl.Size = new System.Drawing.Size(26, 17);
            this.datumDoLbl.TabIndex = 24;
            this.datumDoLbl.Text = "Do";
            // 
            // NazivNagradeInput
            // 
            this.NazivNagradeInput.Location = new System.Drawing.Point(89, 26);
            this.NazivNagradeInput.Margin = new System.Windows.Forms.Padding(4);
            this.NazivNagradeInput.Name = "NazivNagradeInput";
            this.NazivNagradeInput.Size = new System.Drawing.Size(283, 22);
            this.NazivNagradeInput.TabIndex = 21;
            this.NazivNagradeInput.Validating += new System.ComponentModel.CancelEventHandler(this.NazivNagradeInput_Validating);
            // 
            // NazivNagradeLbl
            // 
            this.NazivNagradeLbl.AutoSize = true;
            this.NazivNagradeLbl.Location = new System.Drawing.Point(24, 29);
            this.NazivNagradeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NazivNagradeLbl.Name = "NazivNagradeLbl";
            this.NazivNagradeLbl.Size = new System.Drawing.Size(47, 17);
            this.NazivNagradeLbl.TabIndex = 22;
            this.NazivNagradeLbl.Text = "Naziv ";
            // 
            // izmijeniNagraduBtn
            // 
            this.izmijeniNagraduBtn.Location = new System.Drawing.Point(272, 178);
            this.izmijeniNagraduBtn.Margin = new System.Windows.Forms.Padding(4);
            this.izmijeniNagraduBtn.Name = "izmijeniNagraduBtn";
            this.izmijeniNagraduBtn.Size = new System.Drawing.Size(100, 28);
            this.izmijeniNagraduBtn.TabIndex = 19;
            this.izmijeniNagraduBtn.Text = "Sacuvaj";
            this.izmijeniNagraduBtn.UseVisualStyleBackColor = true;
            this.izmijeniNagraduBtn.Click += new System.EventHandler(this.izmijeniNagraduBtn_Click);
            // 
            // datumOdDateTimePicker
            // 
            this.datumOdDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumOdDateTimePicker.Location = new System.Drawing.Point(89, 68);
            this.datumOdDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datumOdDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.datumOdDateTimePicker.MinDate = new System.DateTime(2019, 2, 4, 0, 0, 0, 0);
            this.datumOdDateTimePicker.Name = "datumOdDateTimePicker";
            this.datumOdDateTimePicker.Size = new System.Drawing.Size(131, 22);
            this.datumOdDateTimePicker.TabIndex = 18;
            // 
            // datumOdLbl
            // 
            this.datumOdLbl.AutoSize = true;
            this.datumOdLbl.Location = new System.Drawing.Point(24, 73);
            this.datumOdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datumOdLbl.Name = "datumOdLbl";
            this.datumOdLbl.Size = new System.Drawing.Size(27, 17);
            this.datumOdLbl.TabIndex = 20;
            this.datumOdLbl.Text = "Od";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // IzmijeniNagradu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 228);
            this.Controls.Add(this.datumDoDateTimePicker);
            this.Controls.Add(this.datumDoLbl);
            this.Controls.Add(this.NazivNagradeInput);
            this.Controls.Add(this.NazivNagradeLbl);
            this.Controls.Add(this.izmijeniNagraduBtn);
            this.Controls.Add(this.datumOdDateTimePicker);
            this.Controls.Add(this.datumOdLbl);
            this.Name = "IzmijeniNagradu";
            this.Text = "Izmijeni nagradu";
            this.Load += new System.EventHandler(this.IzmijeniNagradu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datumDoDateTimePicker;
        private System.Windows.Forms.Label datumDoLbl;
        private System.Windows.Forms.TextBox NazivNagradeInput;
        private System.Windows.Forms.Label NazivNagradeLbl;
        private System.Windows.Forms.Button izmijeniNagraduBtn;
        private System.Windows.Forms.DateTimePicker datumOdDateTimePicker;
        private System.Windows.Forms.Label datumOdLbl;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}