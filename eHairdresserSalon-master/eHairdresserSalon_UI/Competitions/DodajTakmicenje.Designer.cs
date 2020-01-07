namespace eHairdresserSalon_UI.Competitions
{
    partial class DodajTakmicenje
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
            this.NazivInput = new System.Windows.Forms.TextBox();
            this.MjestoInput = new System.Windows.Forms.TextBox();
            this.DatumInput = new System.Windows.Forms.DateTimePicker();
            this.DodajTakmicenjeBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FrizeriComboBox = new System.Windows.Forms.ComboBox();
            this.FrizeriLbl = new System.Windows.Forms.Label();
            this.OpisInput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NazivLbl
            // 
            this.NazivLbl.AutoSize = true;
            this.NazivLbl.Location = new System.Drawing.Point(12, 24);
            this.NazivLbl.Name = "NazivLbl";
            this.NazivLbl.Size = new System.Drawing.Size(34, 13);
            this.NazivLbl.TabIndex = 6;
            this.NazivLbl.Text = "Naziv";
            // 
            // DatumLbl
            // 
            this.DatumLbl.AutoSize = true;
            this.DatumLbl.Location = new System.Drawing.Point(12, 64);
            this.DatumLbl.Name = "DatumLbl";
            this.DatumLbl.Size = new System.Drawing.Size(38, 13);
            this.DatumLbl.TabIndex = 7;
            this.DatumLbl.Text = "Datum";
            // 
            // MjestoLbl
            // 
            this.MjestoLbl.AutoSize = true;
            this.MjestoLbl.Location = new System.Drawing.Point(12, 102);
            this.MjestoLbl.Name = "MjestoLbl";
            this.MjestoLbl.Size = new System.Drawing.Size(38, 13);
            this.MjestoLbl.TabIndex = 8;
            this.MjestoLbl.Text = "Mjesto";
            // 
            // OpisLbl
            // 
            this.OpisLbl.AutoSize = true;
            this.OpisLbl.Location = new System.Drawing.Point(12, 187);
            this.OpisLbl.Name = "OpisLbl";
            this.OpisLbl.Size = new System.Drawing.Size(28, 13);
            this.OpisLbl.TabIndex = 10;
            this.OpisLbl.Text = "Opis";
            // 
            // NazivInput
            // 
            this.NazivInput.Location = new System.Drawing.Point(73, 21);
            this.NazivInput.Name = "NazivInput";
            this.NazivInput.Size = new System.Drawing.Size(213, 20);
            this.NazivInput.TabIndex = 0;
            this.NazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.NazivInput_Validating);
            // 
            // MjestoInput
            // 
            this.MjestoInput.Location = new System.Drawing.Point(73, 102);
            this.MjestoInput.Name = "MjestoInput";
            this.MjestoInput.Size = new System.Drawing.Size(143, 20);
            this.MjestoInput.TabIndex = 2;
            this.MjestoInput.Validating += new System.ComponentModel.CancelEventHandler(this.MjestoInput_Validating);
            // 
            // DatumInput
            // 
            this.DatumInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatumInput.Location = new System.Drawing.Point(73, 64);
            this.DatumInput.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.DatumInput.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.DatumInput.Name = "DatumInput";
            this.DatumInput.Size = new System.Drawing.Size(100, 20);
            this.DatumInput.TabIndex = 1;
            this.DatumInput.Value = new System.DateTime(2019, 1, 28, 0, 0, 0, 0);
            // 
            // DodajTakmicenjeBtn
            // 
            this.DodajTakmicenjeBtn.Location = new System.Drawing.Point(211, 309);
            this.DodajTakmicenjeBtn.Name = "DodajTakmicenjeBtn";
            this.DodajTakmicenjeBtn.Size = new System.Drawing.Size(75, 23);
            this.DodajTakmicenjeBtn.TabIndex = 5;
            this.DodajTakmicenjeBtn.Text = "Dodaj";
            this.DodajTakmicenjeBtn.UseVisualStyleBackColor = true;
            this.DodajTakmicenjeBtn.Click += new System.EventHandler(this.DodajTakmicenjeBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrizeriComboBox
            // 
            this.FrizeriComboBox.FormattingEnabled = true;
            this.FrizeriComboBox.Location = new System.Drawing.Point(73, 142);
            this.FrizeriComboBox.Name = "FrizeriComboBox";
            this.FrizeriComboBox.Size = new System.Drawing.Size(143, 21);
            this.FrizeriComboBox.TabIndex = 3;
            // 
            // FrizeriLbl
            // 
            this.FrizeriLbl.AutoSize = true;
            this.FrizeriLbl.Location = new System.Drawing.Point(12, 145);
            this.FrizeriLbl.Name = "FrizeriLbl";
            this.FrizeriLbl.Size = new System.Drawing.Size(32, 13);
            this.FrizeriLbl.TabIndex = 9;
            this.FrizeriLbl.Text = "Frizer";
            // 
            // OpisInput
            // 
            this.OpisInput.Location = new System.Drawing.Point(73, 184);
            this.OpisInput.Name = "OpisInput";
            this.OpisInput.Size = new System.Drawing.Size(213, 96);
            this.OpisInput.TabIndex = 4;
            this.OpisInput.Text = "";
            // 
            // DodajTakmicenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 354);
            this.Controls.Add(this.OpisInput);
            this.Controls.Add(this.FrizeriLbl);
            this.Controls.Add(this.FrizeriComboBox);
            this.Controls.Add(this.DodajTakmicenjeBtn);
            this.Controls.Add(this.DatumInput);
            this.Controls.Add(this.MjestoInput);
            this.Controls.Add(this.NazivInput);
            this.Controls.Add(this.OpisLbl);
            this.Controls.Add(this.MjestoLbl);
            this.Controls.Add(this.DatumLbl);
            this.Controls.Add(this.NazivLbl);
            this.Name = "DodajTakmicenje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj takmičenje";
            this.Load += new System.EventHandler(this.DodajTakmicenje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NazivLbl;
        private System.Windows.Forms.Label DatumLbl;
        private System.Windows.Forms.Label MjestoLbl;
        private System.Windows.Forms.Label OpisLbl;
        private System.Windows.Forms.TextBox NazivInput;
        private System.Windows.Forms.TextBox MjestoInput;
        private System.Windows.Forms.DateTimePicker DatumInput;
        private System.Windows.Forms.Button DodajTakmicenjeBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label FrizeriLbl;
        private System.Windows.Forms.ComboBox FrizeriComboBox;
        private System.Windows.Forms.RichTextBox OpisInput;
    }
}