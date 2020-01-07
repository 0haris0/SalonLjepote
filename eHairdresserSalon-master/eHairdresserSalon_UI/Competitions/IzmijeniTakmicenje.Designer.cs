namespace eHairdresserSalon_UI.Competitions
{
    partial class IzmijeniTakmicenje
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
            this.NazivLbl = new System.Windows.Forms.Label();
            this.DatumLbl = new System.Windows.Forms.Label();
            this.MjestoLbl = new System.Windows.Forms.Label();
            this.OpisLbl = new System.Windows.Forms.Label();
            this.FrizerLbl = new System.Windows.Forms.Label();
            this.NazivInput = new System.Windows.Forms.TextBox();
            this.MjestoInput = new System.Windows.Forms.TextBox();
            this.FrizerComboBox = new System.Windows.Forms.ComboBox();
            this.DatumTakmicenjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SacuvajBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OpisInput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NazivLbl
            // 
            this.NazivLbl.AutoSize = true;
            this.NazivLbl.Location = new System.Drawing.Point(13, 24);
            this.NazivLbl.Name = "NazivLbl";
            this.NazivLbl.Size = new System.Drawing.Size(34, 13);
            this.NazivLbl.TabIndex = 6;
            this.NazivLbl.Text = "Naziv";
            // 
            // DatumLbl
            // 
            this.DatumLbl.AutoSize = true;
            this.DatumLbl.Location = new System.Drawing.Point(13, 65);
            this.DatumLbl.Name = "DatumLbl";
            this.DatumLbl.Size = new System.Drawing.Size(38, 13);
            this.DatumLbl.TabIndex = 7;
            this.DatumLbl.Text = "Datum";
            // 
            // MjestoLbl
            // 
            this.MjestoLbl.AutoSize = true;
            this.MjestoLbl.Location = new System.Drawing.Point(13, 110);
            this.MjestoLbl.Name = "MjestoLbl";
            this.MjestoLbl.Size = new System.Drawing.Size(38, 13);
            this.MjestoLbl.TabIndex = 8;
            this.MjestoLbl.Text = "Mjesto";
            // 
            // OpisLbl
            // 
            this.OpisLbl.AutoSize = true;
            this.OpisLbl.Location = new System.Drawing.Point(13, 215);
            this.OpisLbl.Name = "OpisLbl";
            this.OpisLbl.Size = new System.Drawing.Size(28, 13);
            this.OpisLbl.TabIndex = 10;
            this.OpisLbl.Text = "Opis";
            // 
            // FrizerLbl
            // 
            this.FrizerLbl.AutoSize = true;
            this.FrizerLbl.Location = new System.Drawing.Point(13, 162);
            this.FrizerLbl.Name = "FrizerLbl";
            this.FrizerLbl.Size = new System.Drawing.Size(32, 13);
            this.FrizerLbl.TabIndex = 9;
            this.FrizerLbl.Text = "Frizer";
            // 
            // NazivInput
            // 
            this.NazivInput.Location = new System.Drawing.Point(79, 21);
            this.NazivInput.Name = "NazivInput";
            this.NazivInput.Size = new System.Drawing.Size(234, 20);
            this.NazivInput.TabIndex = 0;
            this.NazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.NazivInput_Validating);
            // 
            // MjestoInput
            // 
            this.MjestoInput.Location = new System.Drawing.Point(79, 107);
            this.MjestoInput.Name = "MjestoInput";
            this.MjestoInput.Size = new System.Drawing.Size(96, 20);
            this.MjestoInput.TabIndex = 2;
            this.MjestoInput.Validating += new System.ComponentModel.CancelEventHandler(this.MjestoInput_Validating);
            // 
            // FrizerComboBox
            // 
            this.FrizerComboBox.FormattingEnabled = true;
            this.FrizerComboBox.Location = new System.Drawing.Point(77, 159);
            this.FrizerComboBox.Name = "FrizerComboBox";
            this.FrizerComboBox.Size = new System.Drawing.Size(133, 21);
            this.FrizerComboBox.TabIndex = 3;
            // 
            // DatumTakmicenjaDateTimePicker
            // 
            this.DatumTakmicenjaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatumTakmicenjaDateTimePicker.Location = new System.Drawing.Point(79, 59);
            this.DatumTakmicenjaDateTimePicker.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.DatumTakmicenjaDateTimePicker.MinDate = new System.DateTime(2019, 2, 11, 0, 0, 0, 0);
            this.DatumTakmicenjaDateTimePicker.Name = "DatumTakmicenjaDateTimePicker";
            this.DatumTakmicenjaDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.DatumTakmicenjaDateTimePicker.TabIndex = 1;
            // 
            // SacuvajBtn
            // 
            this.SacuvajBtn.Location = new System.Drawing.Point(238, 339);
            this.SacuvajBtn.Name = "SacuvajBtn";
            this.SacuvajBtn.Size = new System.Drawing.Size(75, 23);
            this.SacuvajBtn.TabIndex = 5;
            this.SacuvajBtn.Text = "Sačuvaj";
            this.SacuvajBtn.UseVisualStyleBackColor = true;
            this.SacuvajBtn.Click += new System.EventHandler(this.SacuvajBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // OpisInput
            // 
            this.OpisInput.Location = new System.Drawing.Point(79, 215);
            this.OpisInput.Name = "OpisInput";
            this.OpisInput.Size = new System.Drawing.Size(234, 96);
            this.OpisInput.TabIndex = 4;
            this.OpisInput.Text = "";
            // 
            // IzmijeniTakmicenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 374);
            this.Controls.Add(this.OpisInput);
            this.Controls.Add(this.SacuvajBtn);
            this.Controls.Add(this.DatumTakmicenjaDateTimePicker);
            this.Controls.Add(this.FrizerComboBox);
            this.Controls.Add(this.MjestoInput);
            this.Controls.Add(this.NazivInput);
            this.Controls.Add(this.FrizerLbl);
            this.Controls.Add(this.OpisLbl);
            this.Controls.Add(this.MjestoLbl);
            this.Controls.Add(this.DatumLbl);
            this.Controls.Add(this.NazivLbl);
            this.Name = "IzmijeniTakmicenje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmjena takmičenja";
            this.Load += new System.EventHandler(this.IzmijeniTakmicenje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NazivLbl;
        private System.Windows.Forms.Label DatumLbl;
        private System.Windows.Forms.Label MjestoLbl;
        private System.Windows.Forms.Label OpisLbl;
        private System.Windows.Forms.Label FrizerLbl;
        private System.Windows.Forms.TextBox NazivInput;
        private System.Windows.Forms.TextBox MjestoInput;
        private System.Windows.Forms.ComboBox FrizerComboBox;
        private System.Windows.Forms.DateTimePicker DatumTakmicenjaDateTimePicker;
        private System.Windows.Forms.Button SacuvajBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RichTextBox OpisInput;
    }
}