namespace ATM
{
    partial class LanguageSelection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.romanianButton = new System.Windows.Forms.Button();
            this.englishButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(252, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECTATI LIMBA";
            // 
            // romanianButton
            // 
            this.romanianButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.romanianButton.Location = new System.Drawing.Point(37, 377);
            this.romanianButton.Name = "romanianButton";
            this.romanianButton.Size = new System.Drawing.Size(182, 62);
            this.romanianButton.TabIndex = 3;
            this.romanianButton.Text = "ROMANA";
            this.romanianButton.UseVisualStyleBackColor = true;
            this.romanianButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // englishButton
            // 
            this.englishButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.englishButton.Location = new System.Drawing.Point(580, 377);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(182, 62);
            this.englishButton.TabIndex = 4;
            this.englishButton.Text = "ENGLISH";
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(235, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "SELECT LANGUAGE";
            // 
            // LanguageSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.englishButton);
            this.Controls.Add(this.romanianButton);
            this.Controls.Add(this.label1);
            this.Name = "LanguageSelection";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.LanguageSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button romanianButton;
        private Button englishButton;
        private Label label2;
    }
}
