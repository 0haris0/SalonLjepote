namespace eHairdresserSalon_UI.Appointments
{
    partial class IzmijeniTermin
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
            this.frizeriComboBox = new System.Windows.Forms.ComboBox();
            this.vrijemeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.frizerLbl = new System.Windows.Forms.Label();
            this.vrijemeLbl = new System.Windows.Forms.Label();
            this.datumLbl = new System.Windows.Forms.Label();
            this.SacuvajBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxProsaoTermin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // frizeriComboBox
            // 
            this.frizeriComboBox.FormattingEnabled = true;
            this.frizeriComboBox.Location = new System.Drawing.Point(96, 87);
            this.frizeriComboBox.Name = "frizeriComboBox";
            this.frizeriComboBox.Size = new System.Drawing.Size(158, 21);
            this.frizeriComboBox.TabIndex = 2;
            // 
            // vrijemeDateTimePicker
            // 
            this.vrijemeDateTimePicker.CustomFormat = "hh:mm";
            this.vrijemeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vrijemeDateTimePicker.Location = new System.Drawing.Point(97, 52);
            this.vrijemeDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.vrijemeDateTimePicker.MinDate = new System.DateTime(2019, 2, 4, 0, 0, 0, 0);
            this.vrijemeDateTimePicker.Name = "vrijemeDateTimePicker";
            this.vrijemeDateTimePicker.ShowUpDown = true;
            this.vrijemeDateTimePicker.Size = new System.Drawing.Size(57, 20);
            this.vrijemeDateTimePicker.TabIndex = 1;
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDateTimePicker.Location = new System.Drawing.Point(97, 17);
            this.datumDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.datumDateTimePicker.MinDate = new System.DateTime(2019, 2, 4, 0, 0, 0, 0);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.datumDateTimePicker.TabIndex = 0;
            // 
            // frizerLbl
            // 
            this.frizerLbl.AutoSize = true;
            this.frizerLbl.Location = new System.Drawing.Point(15, 90);
            this.frizerLbl.Name = "frizerLbl";
            this.frizerLbl.Size = new System.Drawing.Size(32, 13);
            this.frizerLbl.TabIndex = 6;
            this.frizerLbl.Text = "Frizer";
            // 
            // vrijemeLbl
            // 
            this.vrijemeLbl.AutoSize = true;
            this.vrijemeLbl.Location = new System.Drawing.Point(15, 58);
            this.vrijemeLbl.Name = "vrijemeLbl";
            this.vrijemeLbl.Size = new System.Drawing.Size(41, 13);
            this.vrijemeLbl.TabIndex = 5;
            this.vrijemeLbl.Text = "Vrijeme";
            // 
            // datumLbl
            // 
            this.datumLbl.AutoSize = true;
            this.datumLbl.Location = new System.Drawing.Point(15, 23);
            this.datumLbl.Name = "datumLbl";
            this.datumLbl.Size = new System.Drawing.Size(38, 13);
            this.datumLbl.TabIndex = 4;
            this.datumLbl.Text = "Datum";
            // 
            // SacuvajBtn
            // 
            this.SacuvajBtn.Location = new System.Drawing.Point(179, 177);
            this.SacuvajBtn.Name = "SacuvajBtn";
            this.SacuvajBtn.Size = new System.Drawing.Size(75, 23);
            this.SacuvajBtn.TabIndex = 3;
            this.SacuvajBtn.Text = "Sačuvaj";
            this.SacuvajBtn.UseVisualStyleBackColor = true;
            this.SacuvajBtn.Click += new System.EventHandler(this.SacuvajBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prošao termin";
            // 
            // checkBoxProsaoTermin
            // 
            this.checkBoxProsaoTermin.AutoSize = true;
            this.checkBoxProsaoTermin.Location = new System.Drawing.Point(97, 131);
            this.checkBoxProsaoTermin.Name = "checkBoxProsaoTermin";
            this.checkBoxProsaoTermin.Size = new System.Drawing.Size(15, 14);
            this.checkBoxProsaoTermin.TabIndex = 8;
            this.checkBoxProsaoTermin.UseVisualStyleBackColor = true;
            // 
            // IzmijeniTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 228);
            this.Controls.Add(this.checkBoxProsaoTermin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SacuvajBtn);
            this.Controls.Add(this.frizeriComboBox);
            this.Controls.Add(this.vrijemeDateTimePicker);
            this.Controls.Add(this.datumDateTimePicker);
            this.Controls.Add(this.frizerLbl);
            this.Controls.Add(this.vrijemeLbl);
            this.Controls.Add(this.datumLbl);
            this.Name = "IzmijeniTermin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmjena termina";
            this.Load += new System.EventHandler(this.IzmijeniTermin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox frizeriComboBox;
        private System.Windows.Forms.DateTimePicker vrijemeDateTimePicker;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.Label frizerLbl;
        private System.Windows.Forms.Label vrijemeLbl;
        private System.Windows.Forms.Label datumLbl;
        private System.Windows.Forms.Button SacuvajBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox checkBoxProsaoTermin;
        private System.Windows.Forms.Label label1;
    }
}