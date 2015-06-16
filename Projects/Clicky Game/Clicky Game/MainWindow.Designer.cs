using System.Windows.Forms;
namespace Clicky_Game
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.StartPhoto = new System.Windows.Forms.PictureBox();
            this.fifteenTargets = new System.Windows.Forms.Button();
            this.fiveTargets = new System.Windows.Forms.Button();
            this.twentyTargets = new System.Windows.Forms.Button();
            this.tenTargets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // StartPhoto
            // 
            this.StartPhoto.Image = ((System.Drawing.Image)(resources.GetObject("StartPhoto.Image")));
            this.StartPhoto.Location = new System.Drawing.Point(235, 300);
            this.StartPhoto.Name = "StartPhoto";
            this.StartPhoto.Size = new System.Drawing.Size(230, 100);
            this.StartPhoto.TabIndex = 0;
            this.StartPhoto.TabStop = false;
            this.StartPhoto.Visible = false;
            this.StartPhoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fifteenTargets
            // 
            this.fifteenTargets.Location = new System.Drawing.Point(235, 237);
            this.fifteenTargets.Name = "fifteenTargets";
            this.fifteenTargets.Size = new System.Drawing.Size(113, 23);
            this.fifteenTargets.TabIndex = 3;
            this.fifteenTargets.Text = "15 Targets";
            this.fifteenTargets.UseVisualStyleBackColor = true;
            this.fifteenTargets.Click += new System.EventHandler(this.fifteenTargets_Click);
            // 
            // fiveTargets
            // 
            this.fiveTargets.Location = new System.Drawing.Point(235, 208);
            this.fiveTargets.Name = "fiveTargets";
            this.fiveTargets.Size = new System.Drawing.Size(113, 23);
            this.fiveTargets.TabIndex = 4;
            this.fiveTargets.Text = "5 Targets";
            this.fiveTargets.UseVisualStyleBackColor = true;
            this.fiveTargets.Click += new System.EventHandler(this.fiveTargets_Click);
            // 
            // twentyTargets
            // 
            this.twentyTargets.Location = new System.Drawing.Point(354, 237);
            this.twentyTargets.Name = "twentyTargets";
            this.twentyTargets.Size = new System.Drawing.Size(113, 23);
            this.twentyTargets.TabIndex = 5;
            this.twentyTargets.Text = "20 Targets";
            this.twentyTargets.UseVisualStyleBackColor = true;
            this.twentyTargets.Click += new System.EventHandler(this.twentyTargets_Click);
            // 
            // tenTargets
            // 
            this.tenTargets.Location = new System.Drawing.Point(354, 208);
            this.tenTargets.Name = "tenTargets";
            this.tenTargets.Size = new System.Drawing.Size(113, 23);
            this.tenTargets.TabIndex = 6;
            this.tenTargets.Text = "10 Targets";
            this.tenTargets.UseVisualStyleBackColor = true;
            this.tenTargets.Click += new System.EventHandler(this.tenTargets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(299, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Targets: 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 63);
            this.button1.TabIndex = 8;
            this.button1.Text = "How To Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width / 2) - (684 / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (461 / 2));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tenTargets);
            this.Controls.Add(this.twentyTargets);
            this.Controls.Add(this.fiveTargets);
            this.Controls.Add(this.fifteenTargets);
            this.Controls.Add(this.StartPhoto);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clicky Game";
            ((System.ComponentModel.ISupportInitialize)(this.StartPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StartPhoto;
        private System.Windows.Forms.Button fifteenTargets;
        private System.Windows.Forms.Button fiveTargets;
        private System.Windows.Forms.Button twentyTargets;
        private System.Windows.Forms.Button tenTargets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

