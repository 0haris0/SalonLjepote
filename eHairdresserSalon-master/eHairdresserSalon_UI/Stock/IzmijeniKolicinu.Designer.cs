namespace eHairdresserSalon_UI.Stock
{
    partial class IzmijeniKolicinu
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
            this.KolicinaLbl = new System.Windows.Forms.Label();
            this.KolicinaInput = new System.Windows.Forms.TextBox();
            this.SacuvajBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // KolicinaLbl
            // 
            this.KolicinaLbl.AutoSize = true;
            this.KolicinaLbl.Location = new System.Drawing.Point(77, 24);
            this.KolicinaLbl.Name = "KolicinaLbl";
            this.KolicinaLbl.Size = new System.Drawing.Size(44, 13);
            this.KolicinaLbl.TabIndex = 2;
            this.KolicinaLbl.Text = "Količina";
            // 
            // KolicinaInput
            // 
            this.KolicinaInput.Location = new System.Drawing.Point(127, 21);
            this.KolicinaInput.Name = "KolicinaInput";
            this.KolicinaInput.Size = new System.Drawing.Size(67, 20);
            this.KolicinaInput.TabIndex = 0;
            this.KolicinaInput.Validating += new System.ComponentModel.CancelEventHandler(this.KolicinaInput_Validating);
            // 
            // SacuvajBtn
            // 
            this.SacuvajBtn.Location = new System.Drawing.Point(129, 76);
            this.SacuvajBtn.Name = "SacuvajBtn";
            this.SacuvajBtn.Size = new System.Drawing.Size(65, 23);
            this.SacuvajBtn.TabIndex = 1;
            this.SacuvajBtn.Text = "Sačuvaj";
            this.SacuvajBtn.UseVisualStyleBackColor = true;
            this.SacuvajBtn.Click += new System.EventHandler(this.SacuvajBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // IzmijeniKolicinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 111);
            this.Controls.Add(this.SacuvajBtn);
            this.Controls.Add(this.KolicinaInput);
            this.Controls.Add(this.KolicinaLbl);
            this.Name = "IzmijeniKolicinu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmijena količine na skladištu";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KolicinaLbl;
        private System.Windows.Forms.TextBox KolicinaInput;
        private System.Windows.Forms.Button SacuvajBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}