namespace eHairdresserSalon_UI.Services
{
    partial class DodajUslugu
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
            this.NazivUslugeLbl = new System.Windows.Forms.Label();
            this.TrajanjeMinuteLbl = new System.Windows.Forms.Label();
            this.CijenaLbl = new System.Windows.Forms.Label();
            this.NazivUslugeInput = new System.Windows.Forms.TextBox();
            this.TrajanjeUslugeInput = new System.Windows.Forms.TextBox();
            this.CijenaUslugeInput = new System.Windows.Forms.TextBox();
            this.DodajUsluguBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.VrstaUslugeLbl = new System.Windows.Forms.Label();
            this.vrstaUslugeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NazivUslugeLbl
            // 
            this.NazivUslugeLbl.AutoSize = true;
            this.NazivUslugeLbl.Location = new System.Drawing.Point(18, 65);
            this.NazivUslugeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NazivUslugeLbl.Name = "NazivUslugeLbl";
            this.NazivUslugeLbl.Size = new System.Drawing.Size(47, 17);
            this.NazivUslugeLbl.TabIndex = 6;
            this.NazivUslugeLbl.Text = "Naziv ";
            // 
            // TrajanjeMinuteLbl
            // 
            this.TrajanjeMinuteLbl.AutoSize = true;
            this.TrajanjeMinuteLbl.Location = new System.Drawing.Point(18, 112);
            this.TrajanjeMinuteLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TrajanjeMinuteLbl.Name = "TrajanjeMinuteLbl";
            this.TrajanjeMinuteLbl.Size = new System.Drawing.Size(116, 17);
            this.TrajanjeMinuteLbl.TabIndex = 7;
            this.TrajanjeMinuteLbl.Text = "Trajanje (minute)";
            // 
            // CijenaLbl
            // 
            this.CijenaLbl.AutoSize = true;
            this.CijenaLbl.Location = new System.Drawing.Point(19, 160);
            this.CijenaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CijenaLbl.Name = "CijenaLbl";
            this.CijenaLbl.Size = new System.Drawing.Size(47, 17);
            this.CijenaLbl.TabIndex = 8;
            this.CijenaLbl.Text = "Cijena";
            // 
            // NazivUslugeInput
            // 
            this.NazivUslugeInput.Location = new System.Drawing.Point(145, 62);
            this.NazivUslugeInput.Margin = new System.Windows.Forms.Padding(4);
            this.NazivUslugeInput.Name = "NazivUslugeInput";
            this.NazivUslugeInput.Size = new System.Drawing.Size(283, 22);
            this.NazivUslugeInput.TabIndex = 1;
            this.NazivUslugeInput.Validating += new System.ComponentModel.CancelEventHandler(this.NazivUslugeInput_Validating);
            // 
            // TrajanjeUslugeInput
            // 
            this.TrajanjeUslugeInput.Location = new System.Drawing.Point(145, 109);
            this.TrajanjeUslugeInput.Margin = new System.Windows.Forms.Padding(4);
            this.TrajanjeUslugeInput.Name = "TrajanjeUslugeInput";
            this.TrajanjeUslugeInput.Size = new System.Drawing.Size(57, 22);
            this.TrajanjeUslugeInput.TabIndex = 2;
            this.TrajanjeUslugeInput.Validating += new System.ComponentModel.CancelEventHandler(this.TrajanjeUslugeInput_Validating);
            // 
            // CijenaUslugeInput
            // 
            this.CijenaUslugeInput.Location = new System.Drawing.Point(145, 157);
            this.CijenaUslugeInput.Margin = new System.Windows.Forms.Padding(4);
            this.CijenaUslugeInput.Name = "CijenaUslugeInput";
            this.CijenaUslugeInput.Size = new System.Drawing.Size(57, 22);
            this.CijenaUslugeInput.TabIndex = 3;
            this.CijenaUslugeInput.Validating += new System.ComponentModel.CancelEventHandler(this.CijenaUslugeInput_Validating);
            // 
            // DodajUsluguBtn
            // 
            this.DodajUsluguBtn.Location = new System.Drawing.Point(329, 191);
            this.DodajUsluguBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DodajUsluguBtn.Name = "DodajUsluguBtn";
            this.DodajUsluguBtn.Size = new System.Drawing.Size(100, 28);
            this.DodajUsluguBtn.TabIndex = 4;
            this.DodajUsluguBtn.Text = "Dodaj";
            this.DodajUsluguBtn.UseVisualStyleBackColor = true;
            this.DodajUsluguBtn.Click += new System.EventHandler(this.DodajUsluguBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // VrstaUslugeLbl
            // 
            this.VrstaUslugeLbl.AutoSize = true;
            this.VrstaUslugeLbl.Location = new System.Drawing.Point(19, 22);
            this.VrstaUslugeLbl.Name = "VrstaUslugeLbl";
            this.VrstaUslugeLbl.Size = new System.Drawing.Size(91, 17);
            this.VrstaUslugeLbl.TabIndex = 5;
            this.VrstaUslugeLbl.Text = "Vrsta usluge:";
            // 
            // vrstaUslugeComboBox
            // 
            this.vrstaUslugeComboBox.FormattingEnabled = true;
            this.vrstaUslugeComboBox.Location = new System.Drawing.Point(145, 19);
            this.vrstaUslugeComboBox.Name = "vrstaUslugeComboBox";
            this.vrstaUslugeComboBox.Size = new System.Drawing.Size(283, 24);
            this.vrstaUslugeComboBox.TabIndex = 0;
            this.vrstaUslugeComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.vrstaUslugeComboBox_Validating);
            // 
            // DodajUslugu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 241);
            this.Controls.Add(this.vrstaUslugeComboBox);
            this.Controls.Add(this.VrstaUslugeLbl);
            this.Controls.Add(this.DodajUsluguBtn);
            this.Controls.Add(this.CijenaUslugeInput);
            this.Controls.Add(this.TrajanjeUslugeInput);
            this.Controls.Add(this.NazivUslugeInput);
            this.Controls.Add(this.CijenaLbl);
            this.Controls.Add(this.TrajanjeMinuteLbl);
            this.Controls.Add(this.NazivUslugeLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DodajUslugu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj uslugu";
            this.Load += new System.EventHandler(this.DodajUslugu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NazivUslugeLbl;
        private System.Windows.Forms.Label TrajanjeMinuteLbl;
        private System.Windows.Forms.Label CijenaLbl;
        private System.Windows.Forms.TextBox NazivUslugeInput;
        private System.Windows.Forms.TextBox TrajanjeUslugeInput;
        private System.Windows.Forms.TextBox CijenaUslugeInput;
        private System.Windows.Forms.Button DodajUsluguBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox vrstaUslugeComboBox;
        private System.Windows.Forms.Label VrstaUslugeLbl;
    }
}