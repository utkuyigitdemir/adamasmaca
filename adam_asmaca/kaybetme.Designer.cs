namespace adam_asmaca
{
    partial class kaybetme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kaybetme));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblYenidenOynat = new System.Windows.Forms.Label();
            this.lblKapat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 79);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bu Sefer Olmadı.  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Freestyle Script", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(711, 79);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yeniden Denemek Ne Kaybettirir ki?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(407, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 246);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblYenidenOynat
            // 
            this.lblYenidenOynat.AutoSize = true;
            this.lblYenidenOynat.BackColor = System.Drawing.Color.Transparent;
            this.lblYenidenOynat.Font = new System.Drawing.Font("Freestyle Script", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYenidenOynat.Location = new System.Drawing.Point(393, 449);
            this.lblYenidenOynat.Name = "lblYenidenOynat";
            this.lblYenidenOynat.Size = new System.Drawing.Size(270, 79);
            this.lblYenidenOynat.TabIndex = 9;
            this.lblYenidenOynat.Text = "Yeniden Oyna";
            this.lblYenidenOynat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYenidenOynat.Click += new System.EventHandler(this.lblYenidenOynat_Click);
            this.lblYenidenOynat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lblYenidenOynat.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            this.lblYenidenOynat.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lblYenidenOynat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.BackColor = System.Drawing.Color.Transparent;
            this.lblKapat.Font = new System.Drawing.Font("Freestyle Script", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKapat.Location = new System.Drawing.Point(858, 473);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(138, 79);
            this.lblKapat.TabIndex = 10;
            this.lblKapat.Text = "Kapat";
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click);
            this.lblKapat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lblKapat.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            this.lblKapat.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lblKapat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            // 
            // kaybetme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.lblKapat);
            this.Controls.Add(this.lblYenidenOynat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kaybetme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kaybetme";
            this.Load += new System.EventHandler(this.kaybetme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblYenidenOynat;
        private System.Windows.Forms.Label lblKapat;
    }
}