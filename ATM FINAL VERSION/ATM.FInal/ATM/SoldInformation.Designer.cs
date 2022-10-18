namespace ATM
{
    partial class SoldInformation
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
            this.soldAmount = new System.Windows.Forms.TextBox();
            this.soldContinueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "AVAILABLE CASH:";
            // 
            // soldAmount
            // 
            this.soldAmount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soldAmount.Location = new System.Drawing.Point(354, 269);
            this.soldAmount.Name = "soldAmount";
            this.soldAmount.ReadOnly = true;
            this.soldAmount.Size = new System.Drawing.Size(107, 47);
            this.soldAmount.TabIndex = 1;
            this.soldAmount.TextChanged += new System.EventHandler(this.soldAmount_TextChanged);
            // 
            // soldContinueButton
            // 
            this.soldContinueButton.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soldContinueButton.Location = new System.Drawing.Point(673, 523);
            this.soldContinueButton.Name = "soldContinueButton";
            this.soldContinueButton.Size = new System.Drawing.Size(95, 53);
            this.soldContinueButton.TabIndex = 2;
            this.soldContinueButton.Text = ">";
            this.soldContinueButton.UseVisualStyleBackColor = true;
            // 
            // SoldInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.soldContinueButton);
            this.Controls.Add(this.soldAmount);
            this.Controls.Add(this.label1);
            this.Name = "SoldInformation";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox soldAmount;
        private Button soldContinueButton;
    }
}
