namespace WindowsFormsApp1
{
    partial class SearchTab
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
            this.searchCif = new System.Windows.Forms.Button();
            this.enterCifbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayTransactions = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchCif
            // 
            this.searchCif.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchCif.Location = new System.Drawing.Point(314, 365);
            this.searchCif.Name = "searchCif";
            this.searchCif.Size = new System.Drawing.Size(122, 38);
            this.searchCif.TabIndex = 0;
            this.searchCif.Text = "Search";
            this.searchCif.UseVisualStyleBackColor = true;
            this.searchCif.Click += new System.EventHandler(this.button1_Click);
            // 
            // enterCifbox
            // 
            this.enterCifbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.enterCifbox.Location = new System.Drawing.Point(272, 273);
            this.enterCifbox.Name = "enterCifbox";
            this.enterCifbox.Size = new System.Drawing.Size(214, 38);
            this.enterCifbox.TabIndex = 1;
            this.enterCifbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(167, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "CIF";
            // 
            // displayTransactions
            // 
            this.displayTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.displayTransactions.Location = new System.Drawing.Point(-3, 52);
            this.displayTransactions.Name = "displayTransactions";
            this.displayTransactions.ReadOnly = true;
            this.displayTransactions.Size = new System.Drawing.Size(800, 215);
            this.displayTransactions.TabIndex = 3;
            this.displayTransactions.Text = "";
            this.displayTransactions.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(122, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Transaction Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(295, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "CIF";
            // 
            // SearchTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayTransactions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterCifbox);
            this.Controls.Add(this.searchCif);
            this.Name = "SearchTab";
            this.Text = "SearchTab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchCif;
        private System.Windows.Forms.TextBox enterCifbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox displayTransactions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}