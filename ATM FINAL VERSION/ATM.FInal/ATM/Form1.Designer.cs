namespace ATM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.standBy1 = new ATM.StandBy();
            this.languageSelection1 = new ATM.LanguageSelection();
            this.autentificationRomanian1 = new ATM.AutentificationRomanian();
            this.SuspendLayout();
            // 
            // standBy1
            // 
            this.standBy1.Location = new System.Drawing.Point(0, -1);
            this.standBy1.Name = "standBy1";
            this.standBy1.Size = new System.Drawing.Size(785, 565);
            this.standBy1.TabIndex = 0;
            // 
            // languageSelection1
            // 
            this.languageSelection1.Location = new System.Drawing.Point(0, -1);
            this.languageSelection1.Name = "languageSelection1";
            this.languageSelection1.Size = new System.Drawing.Size(785, 565);
            this.languageSelection1.TabIndex = 1;
            // 
            // autentificationRomanian1
            // 
            this.autentificationRomanian1.Location = new System.Drawing.Point(0, -1);
            this.autentificationRomanian1.Name = "autentificationRomanian1";
            this.autentificationRomanian1.Size = new System.Drawing.Size(785, 565);
            this.autentificationRomanian1.TabIndex = 2;
            this.autentificationRomanian1.Load += new System.EventHandler(this.autentificationRomanian1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.autentificationRomanian1);
            this.Controls.Add(this.languageSelection1);
            this.Controls.Add(this.standBy1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private StandBy standBy1;
        private LanguageSelection languageSelection1;
        private AutentificationRomanian autentificationRomanian1;
    }
}