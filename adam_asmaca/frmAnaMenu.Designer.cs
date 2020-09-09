namespace adam_asmaca
{
    partial class frmAnaMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaMenu));
            this.lblOyunuBaslat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKapat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkKentler = new System.Windows.Forms.CheckBox();
            this.chkUlkeler = new System.Windows.Forms.CheckBox();
            this.chkTDK = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOyunuBaslat
            // 
            this.lblOyunuBaslat.AutoSize = true;
            this.lblOyunuBaslat.BackColor = System.Drawing.Color.Transparent;
            this.lblOyunuBaslat.Enabled = false;
            this.lblOyunuBaslat.Font = new System.Drawing.Font("Freestyle Script", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOyunuBaslat.Location = new System.Drawing.Point(446, 286);
            this.lblOyunuBaslat.Name = "lblOyunuBaslat";
            this.lblOyunuBaslat.Size = new System.Drawing.Size(124, 79);
            this.lblOyunuBaslat.TabIndex = 0;
            this.lblOyunuBaslat.Text = "Oyna";
            this.lblOyunuBaslat.Click += new System.EventHandler(this.lblOyunuBaslat_Click);
            this.lblOyunuBaslat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblOyunuBaslat_MouseDown);
            this.lblOyunuBaslat.MouseEnter += new System.EventHandler(this.lblOyunuBaslat_MouseEnter);
            this.lblOyunuBaslat.MouseLeave += new System.EventHandler(this.lblOyunuBaslat_MouseLeave);
            this.lblOyunuBaslat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblOyunuBaslat_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Freestyle Script", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 79);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adam Asmaca";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.BackColor = System.Drawing.Color.Transparent;
            this.lblKapat.Font = new System.Drawing.Font("Freestyle Script", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKapat.Location = new System.Drawing.Point(861, 512);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(138, 79);
            this.lblKapat.TabIndex = 3;
            this.lblKapat.Text = "Kapat";
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click);
            this.lblKapat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblKapat_MouseDown);
            this.lblKapat.MouseEnter += new System.EventHandler(this.lblKapat_MouseEnter);
            this.lblKapat.MouseLeave += new System.EventHandler(this.lblKapat_MouseLeave);
            this.lblKapat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblKapat_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Freestyle Script", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 47);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kategoriler";
            // 
            // chkKentler
            // 
            this.chkKentler.AutoSize = true;
            this.chkKentler.BackColor = System.Drawing.Color.Transparent;
            this.chkKentler.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKentler.Location = new System.Drawing.Point(390, 225);
            this.chkKentler.Name = "chkKentler";
            this.chkKentler.Size = new System.Drawing.Size(69, 36);
            this.chkKentler.TabIndex = 7;
            this.chkKentler.Text = "iller";
            this.chkKentler.UseVisualStyleBackColor = false;
            this.chkKentler.Click += new System.EventHandler(this.chkKentler_Click);
            this.chkKentler.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chkKentler_MouseDown);
            this.chkKentler.MouseEnter += new System.EventHandler(this.chkKentler_MouseEnter);
            this.chkKentler.MouseLeave += new System.EventHandler(this.chkKentler_MouseLeave);
            this.chkKentler.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkKentler_MouseUp);
            // 
            // chkUlkeler
            // 
            this.chkUlkeler.AutoSize = true;
            this.chkUlkeler.BackColor = System.Drawing.Color.Transparent;
            this.chkUlkeler.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUlkeler.Location = new System.Drawing.Point(517, 225);
            this.chkUlkeler.Name = "chkUlkeler";
            this.chkUlkeler.Size = new System.Drawing.Size(99, 36);
            this.chkUlkeler.TabIndex = 8;
            this.chkUlkeler.Text = "Ülkeler";
            this.chkUlkeler.UseVisualStyleBackColor = false;
            this.chkUlkeler.Click += new System.EventHandler(this.chkUlkeler_Click);
            this.chkUlkeler.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chkUlkeler_MouseDown);
            this.chkUlkeler.MouseEnter += new System.EventHandler(this.chkUlkeler_MouseEnter);
            this.chkUlkeler.MouseLeave += new System.EventHandler(this.chkUlkeler_MouseLeave);
            this.chkUlkeler.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkUlkeler_MouseUp);
            // 
            // chkTDK
            // 
            this.chkTDK.AutoSize = true;
            this.chkTDK.BackColor = System.Drawing.Color.Transparent;
            this.chkTDK.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTDK.Location = new System.Drawing.Point(644, 225);
            this.chkTDK.Name = "chkTDK";
            this.chkTDK.Size = new System.Drawing.Size(69, 36);
            this.chkTDK.TabIndex = 7;
            this.chkTDK.Text = "TDK";
            this.chkTDK.UseVisualStyleBackColor = false;
            this.chkTDK.Click += new System.EventHandler(this.chkTDK_Click);
            this.chkTDK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chkTDK_MouseDown);
            this.chkTDK.MouseEnter += new System.EventHandler(this.chkTDK_MouseEnter);
            this.chkTDK.MouseLeave += new System.EventHandler(this.chkTDK_MouseLeave);
            this.chkTDK.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkTDK_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 234);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(741, 96);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(234, 297);
            this.pictureBox8.TabIndex = 69;
            this.pictureBox8.TabStop = false;
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1079, 600);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkUlkeler);
            this.Controls.Add(this.chkKentler);
            this.Controls.Add(this.chkTDK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblKapat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOyunuBaslat);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adam Asmaca Oyunu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOyunuBaslat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKapat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkKentler;
        private System.Windows.Forms.CheckBox chkUlkeler;
        private System.Windows.Forms.CheckBox chkTDK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

