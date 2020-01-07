namespace eHairdresserSalon_UI.Services
{
    partial class IzmijeniUslugu
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
            this.TrajanjeLbl = new System.Windows.Forms.Label();
            this.CijenaLbl = new System.Windows.Forms.Label();
            this.NazivInput = new System.Windows.Forms.TextBox();
            this.TrajanjeInput = new System.Windows.Forms.TextBox();
            this.CijenaInput = new System.Windows.Forms.TextBox();
            this.SacuvajBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.vrstaUslugeComboBox = new System.Windows.Forms.ComboBox();
            this.VrstaUslugeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NazivLbl
            // 
            this.NazivLbl.AutoSize = true;
            this.NazivLbl.Location = new System.Drawing.Point(18, 70);
            this.NazivLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NazivLbl.Name = "NazivLbl";
            this.NazivLbl.Size = new System.Drawing.Size(43, 17);
            this.NazivLbl.TabIndex = 6;
            this.NazivLbl.Text = "Naziv";
            // 
            // TrajanjeLbl
            // 
            this.TrajanjeLbl.AutoSize = true;
            this.TrajanjeLbl.Location = new System.Drawing.Point(18, 118);
            this.TrajanjeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TrajanjeLbl.Name = "TrajanjeLbl";
            this.TrajanjeLbl.Size = new System.Drawing.Size(116, 17);
            this.TrajanjeLbl.TabIndex = 7;
            this.TrajanjeLbl.Text = "Trajanje (minute)";
            // 
            // CijenaLbl
            // 
            this.CijenaLbl.AutoSize = true;
            this.CijenaLbl.Location = new System.Drawing.Point(18, 163);
            this.CijenaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CijenaLbl.Name = "CijenaLbl";
            this.CijenaLbl.Size = new System.Drawing.Size(47, 17);
            this.CijenaLbl.TabIndex = 8;
            this.CijenaLbl.Text = "Cijena";
            // 
            // NazivInput
            // 
            this.NazivInput.Location = new System.Drawing.Point(139, 70);
            this.NazivInput.Margin = new System.Windows.Forms.Padding(4);
            this.NazivInput.Name = "NazivInput";
            this.NazivInput.Size = new System.Drawing.Size(305, 22);
            this.NazivInput.TabIndex = 1;
            this.NazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.NazivInput_Validating);
            // 
            // TrajanjeInput
            // 
            this.TrajanjeInput.Location = new System.Drawing.Point(139, 115);
            this.TrajanjeInput.Margin = new System.Windows.Forms.Padding(4);
            this.TrajanjeInput.Name = "TrajanjeInput";
            this.TrajanjeInput.Size = new System.Drawing.Size(55, 22);
            this.TrajanjeInput.TabIndex = 2;
            this.TrajanjeInput.Validating += new System.ComponentModel.CancelEventHandler(this.TrajanjeInput_Validating);
            // 
            // CijenaInput
            // 
            this.CijenaInput.Location = new System.Drawing.Point(139, 163);
            this.CijenaInput.Margin = new System.Windows.Forms.Padding(4);
            this.CijenaInput.Name = "CijenaInput";
            this.CijenaInput.Size = new System.Drawing.Size(55, 22);
            this.CijenaInput.TabIndex = 3;
            this.CijenaInput.Validating += new System.ComponentModel.CancelEventHandler(this.CijenaInput_Validating);
            // 
            // SacuvajBtn
            // 
            this.SacuvajBtn.Location = new System.Drawing.Point(346, 200);
            this.SacuvajBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SacuvajBtn.Name = "SacuvajBtn";
            this.SacuvajBtn.Size = new System.Drawing.Size(100, 28);
            this.SacuvajBtn.TabIndex = 4;
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
            this.vrstaUslugeComboBox.Location = new System.Drawing.Point(139, 23);
            this.vrstaUslugeComboBox.Name = "vrstaUslugeComboBox";
            this.vrstaUslugeComboBox.Size = new System.Drawing.Size(305, 24);
            this.vrstaUslugeComboBox.TabIndex = 0;
            // 
            // VrstaUslugeLbl
            // 
            this.VrstaUslugeLbl.AutoSize = true;
            this.VrstaUslugeLbl.Location = new System.Drawing.Point(18, 26);
            this.VrstaUslugeLbl.Name = "VrstaUslugeLbl";
            this.VrstaUslugeLbl.Size = new System.Drawing.Size(91, 17);
            this.VrstaUslugeLbl.TabIndex = 5;
            this.VrstaUslugeLbl.Text = "Vrsta usluge:";
            // 
            // IzmijeniUslugu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 248);
            this.Controls.Add(this.vrstaUslugeComboBox);
            this.Controls.Add(this.VrstaUslugeLbl);
            this.Controls.Add(this.SacuvajBtn);
            this.Controls.Add(this.CijenaInput);
            this.Controls.Add(this.TrajanjeInput);
            this.Controls.Add(this.NazivInput);
            this.Controls.Add(this.CijenaLbl);
            this.Controls.Add(this.TrajanjeLbl);
            this.Controls.Add(this.NazivLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IzmijeniUslugu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmjena usluge";
            this.Load += new System.EventHandler(this.IzmijeniUslugu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NazivLbl;
        private System.Windows.Forms.Label TrajanjeLbl;
        private System.Windows.Forms.Label CijenaLbl;
        private System.Windows.Forms.TextBox NazivInput;
        private System.Windows.Forms.TextBox TrajanjeInput;
        private System.Windows.Forms.TextBox CijenaInput;
        private System.Windows.Forms.Button SacuvajBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox vrstaUslugeComboBox;
        private System.Windows.Forms.Label VrstaUslugeLbl;
    }
}