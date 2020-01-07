namespace eHairdresserSalon_UI.Appointments
{
    partial class DodajTermin
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
            this.datumLbl = new System.Windows.Forms.Label();
            this.vrijemeLbl = new System.Windows.Forms.Label();
            this.frizerLbl = new System.Windows.Forms.Label();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vrijemeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dodajTerminBtn = new System.Windows.Forms.Button();
            this.frizeriComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // datumLbl
            // 
            this.datumLbl.AutoSize = true;
            this.datumLbl.Location = new System.Drawing.Point(7, 25);
            this.datumLbl.Name = "datumLbl";
            this.datumLbl.Size = new System.Drawing.Size(38, 13);
            this.datumLbl.TabIndex = 4;
            this.datumLbl.Text = "Datum";
            // 
            // vrijemeLbl
            // 
            this.vrijemeLbl.AutoSize = true;
            this.vrijemeLbl.Location = new System.Drawing.Point(7, 68);
            this.vrijemeLbl.Name = "vrijemeLbl";
            this.vrijemeLbl.Size = new System.Drawing.Size(41, 13);
            this.vrijemeLbl.TabIndex = 5;
            this.vrijemeLbl.Text = "Vrijeme";
            // 
            // frizerLbl
            // 
            this.frizerLbl.AutoSize = true;
            this.frizerLbl.Location = new System.Drawing.Point(7, 110);
            this.frizerLbl.Name = "frizerLbl";
            this.frizerLbl.Size = new System.Drawing.Size(32, 13);
            this.frizerLbl.TabIndex = 6;
            this.frizerLbl.Text = "Frizer";
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDateTimePicker.Location = new System.Drawing.Point(85, 19);
            this.datumDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.datumDateTimePicker.MinDate = new System.DateTime(2019, 2, 4, 0, 0, 0, 0);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.datumDateTimePicker.TabIndex = 0;
            // 
            // vrijemeDateTimePicker
            // 
            this.vrijemeDateTimePicker.CustomFormat = "hh:mm";
            this.vrijemeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vrijemeDateTimePicker.Location = new System.Drawing.Point(85, 62);
            this.vrijemeDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.vrijemeDateTimePicker.MinDate = new System.DateTime(2019, 2, 4, 0, 0, 0, 0);
            this.vrijemeDateTimePicker.Name = "vrijemeDateTimePicker";
            this.vrijemeDateTimePicker.ShowUpDown = true;
            this.vrijemeDateTimePicker.Size = new System.Drawing.Size(52, 20);
            this.vrijemeDateTimePicker.TabIndex = 1;
            // 
            // dodajTerminBtn
            // 
            this.dodajTerminBtn.Location = new System.Drawing.Point(167, 174);
            this.dodajTerminBtn.Name = "dodajTerminBtn";
            this.dodajTerminBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajTerminBtn.TabIndex = 3;
            this.dodajTerminBtn.Text = "Dodaj";
            this.dodajTerminBtn.UseVisualStyleBackColor = true;
            this.dodajTerminBtn.Click += new System.EventHandler(this.dodajTerminBtn_Click);
            // 
            // frizeriComboBox
            // 
            this.frizeriComboBox.FormattingEnabled = true;
            this.frizeriComboBox.Location = new System.Drawing.Point(84, 107);
            this.frizeriComboBox.Name = "frizeriComboBox";
            this.frizeriComboBox.Size = new System.Drawing.Size(158, 21);
            this.frizeriComboBox.TabIndex = 2;
            this.frizeriComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.frizeriComboBox_Format);
            this.frizeriComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.frizeriComboBox_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DodajTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 215);
            this.Controls.Add(this.frizeriComboBox);
            this.Controls.Add(this.dodajTerminBtn);
            this.Controls.Add(this.vrijemeDateTimePicker);
            this.Controls.Add(this.datumDateTimePicker);
            this.Controls.Add(this.frizerLbl);
            this.Controls.Add(this.vrijemeLbl);
            this.Controls.Add(this.datumLbl);
            this.Name = "DodajTermin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj termin";
            this.Load += new System.EventHandler(this.DodajTermin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datumLbl;
        private System.Windows.Forms.Label vrijemeLbl;
        private System.Windows.Forms.Label frizerLbl;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.DateTimePicker vrijemeDateTimePicker;
        private System.Windows.Forms.Button dodajTerminBtn;
        private System.Windows.Forms.ComboBox frizeriComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}