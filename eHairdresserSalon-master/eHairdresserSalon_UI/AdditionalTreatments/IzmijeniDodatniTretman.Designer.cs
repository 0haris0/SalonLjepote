namespace eHairdresserSalon_UI.AdditionalTreatments
{
    partial class IzmijeniDodatniTretman
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
            this.CijenaDodatnogTretmanaInput = new System.Windows.Forms.TextBox();
            this.NazivDodatnogTretmanaInput = new System.Windows.Forms.TextBox();
            this.CijenaDodatnogTretmanaLbl = new System.Windows.Forms.Label();
            this.NazivDodatnogTretmanaLbl = new System.Windows.Forms.Label();
            this.SacuvajBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.vrstaUslugeComboBox = new System.Windows.Forms.ComboBox();
            this.VrstaUslugeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CijenaDodatnogTretmanaInput
            // 
            this.CijenaDodatnogTretmanaInput.Location = new System.Drawing.Point(128, 145);
            this.CijenaDodatnogTretmanaInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CijenaDodatnogTretmanaInput.Name = "CijenaDodatnogTretmanaInput";
            this.CijenaDodatnogTretmanaInput.Size = new System.Drawing.Size(71, 22);
            this.CijenaDodatnogTretmanaInput.TabIndex = 1;
            this.CijenaDodatnogTretmanaInput.Validating += new System.ComponentModel.CancelEventHandler(this.CijenaDodatnogTretmanaInput_Validating);
            // 
            // NazivDodatnogTretmanaInput
            // 
            this.NazivDodatnogTretmanaInput.Location = new System.Drawing.Point(128, 84);
            this.NazivDodatnogTretmanaInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NazivDodatnogTretmanaInput.Name = "NazivDodatnogTretmanaInput";
            this.NazivDodatnogTretmanaInput.Size = new System.Drawing.Size(373, 22);
            this.NazivDodatnogTretmanaInput.TabIndex = 0;
            this.NazivDodatnogTretmanaInput.Validating += new System.ComponentModel.CancelEventHandler(this.NazivDodatnogTretmanaInput_Validating);
            // 
            // CijenaDodatnogTretmanaLbl
            // 
            this.CijenaDodatnogTretmanaLbl.AutoSize = true;
            this.CijenaDodatnogTretmanaLbl.Location = new System.Drawing.Point(28, 148);
            this.CijenaDodatnogTretmanaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CijenaDodatnogTretmanaLbl.Name = "CijenaDodatnogTretmanaLbl";
            this.CijenaDodatnogTretmanaLbl.Size = new System.Drawing.Size(47, 17);
            this.CijenaDodatnogTretmanaLbl.TabIndex = 4;
            this.CijenaDodatnogTretmanaLbl.Text = "Cijena";
            // 
            // NazivDodatnogTretmanaLbl
            // 
            this.NazivDodatnogTretmanaLbl.AutoSize = true;
            this.NazivDodatnogTretmanaLbl.Location = new System.Drawing.Point(28, 87);
            this.NazivDodatnogTretmanaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NazivDodatnogTretmanaLbl.Name = "NazivDodatnogTretmanaLbl";
            this.NazivDodatnogTretmanaLbl.Size = new System.Drawing.Size(43, 17);
            this.NazivDodatnogTretmanaLbl.TabIndex = 3;
            this.NazivDodatnogTretmanaLbl.Text = "Naziv";
            // 
            // SacuvajBtn
            // 
            this.SacuvajBtn.Location = new System.Drawing.Point(401, 180);
            this.SacuvajBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SacuvajBtn.Name = "SacuvajBtn";
            this.SacuvajBtn.Size = new System.Drawing.Size(100, 28);
            this.SacuvajBtn.TabIndex = 2;
            this.SacuvajBtn.Text = "Sačuvaj";
            this.SacuvajBtn.UseVisualStyleBackColor = true;
            this.SacuvajBtn.Click += new System.EventHandler(this.SacuvajBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // vrstaUslugeComboBox
            // 
            this.vrstaUslugeComboBox.FormattingEnabled = true;
            this.vrstaUslugeComboBox.Location = new System.Drawing.Point(128, 32);
            this.vrstaUslugeComboBox.Name = "vrstaUslugeComboBox";
            this.vrstaUslugeComboBox.Size = new System.Drawing.Size(283, 24);
            this.vrstaUslugeComboBox.TabIndex = 9;
            // 
            // VrstaUslugeLbl
            // 
            this.VrstaUslugeLbl.AutoSize = true;
            this.VrstaUslugeLbl.Location = new System.Drawing.Point(28, 35);
            this.VrstaUslugeLbl.Name = "VrstaUslugeLbl";
            this.VrstaUslugeLbl.Size = new System.Drawing.Size(87, 17);
            this.VrstaUslugeLbl.TabIndex = 10;
            this.VrstaUslugeLbl.Text = "Vrsta usluge";
            // 
            // IzmijeniDodatniTretman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 242);
            this.Controls.Add(this.vrstaUslugeComboBox);
            this.Controls.Add(this.VrstaUslugeLbl);
            this.Controls.Add(this.SacuvajBtn);
            this.Controls.Add(this.CijenaDodatnogTretmanaInput);
            this.Controls.Add(this.NazivDodatnogTretmanaInput);
            this.Controls.Add(this.CijenaDodatnogTretmanaLbl);
            this.Controls.Add(this.NazivDodatnogTretmanaLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IzmijeniDodatniTretman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmjena dodatnog tretmana";
            this.Load += new System.EventHandler(this.IzmijeniDodatniTretman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CijenaDodatnogTretmanaInput;
        private System.Windows.Forms.TextBox NazivDodatnogTretmanaInput;
        private System.Windows.Forms.Label CijenaDodatnogTretmanaLbl;
        private System.Windows.Forms.Label NazivDodatnogTretmanaLbl;
        private System.Windows.Forms.Button SacuvajBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox vrstaUslugeComboBox;
        private System.Windows.Forms.Label VrstaUslugeLbl;
    }
}