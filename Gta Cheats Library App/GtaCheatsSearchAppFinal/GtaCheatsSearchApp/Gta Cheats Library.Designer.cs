namespace GtaCheatsSearchApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchAndDisplayCheat1 = new GtaCheatsSearchApp.Gta5Cheats();
            this.viceCityCheats1 = new GtaCheatsSearchApp.ViceCityCheats();
            this.gtaSanAndreas1 = new GtaCheatsSearchApp.GtaSanAndreas();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(231, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Game";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::GtaCheatsSearchApp.Properties.Resources.gta_sa_logo_80x70;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(448, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 70);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::GtaCheatsSearchApp.Properties.Resources.vice_City_logo_80x70;
            this.button2.Location = new System.Drawing.Point(162, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 70);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GtaCheatsSearchApp.Properties.Resources.gta_5_logo_3_80x70;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(309, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 70);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchAndDisplayCheat1
            // 
            this.searchAndDisplayCheat1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchAndDisplayCheat1.BackgroundImage")));
            this.searchAndDisplayCheat1.Location = new System.Drawing.Point(0, -3);
            this.searchAndDisplayCheat1.Name = "searchAndDisplayCheat1";
            this.searchAndDisplayCheat1.Size = new System.Drawing.Size(726, 441);
            this.searchAndDisplayCheat1.TabIndex = 1;
            this.searchAndDisplayCheat1.Load += new System.EventHandler(this.searchAndDisplayCheat1_Load);
            // 
            // viceCityCheats1
            // 
            this.viceCityCheats1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viceCityCheats1.BackgroundImage")));
            this.viceCityCheats1.Location = new System.Drawing.Point(0, -3);
            this.viceCityCheats1.Name = "viceCityCheats1";
            this.viceCityCheats1.Size = new System.Drawing.Size(724, 443);
            this.viceCityCheats1.TabIndex = 4;
            // 
            // gtaSanAndreas1
            // 
            this.gtaSanAndreas1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gtaSanAndreas1.BackgroundImage")));
            this.gtaSanAndreas1.Location = new System.Drawing.Point(0, -3);
            this.gtaSanAndreas1.Name = "gtaSanAndreas1";
            this.gtaSanAndreas1.Size = new System.Drawing.Size(724, 443);
            this.gtaSanAndreas1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 437);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchAndDisplayCheat1);
            this.Controls.Add(this.viceCityCheats1);
            this.Controls.Add(this.gtaSanAndreas1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Gta5Cheats searchAndDisplayCheat1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private ViceCityCheats viceCityCheats1;
        private System.Windows.Forms.Button button3;
        private GtaSanAndreas gtaSanAndreas1;
    }
}

