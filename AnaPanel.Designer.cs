namespace Proje
{
    partial class AnaPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaPanel));
            this.eMailTB = new System.Windows.Forms.TextBox();
            this.sifreTB = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.girisYap = new System.Windows.Forms.Button();
            this.kaydol = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // eMailTB
            // 
            this.eMailTB.Location = new System.Drawing.Point(229, 169);
            this.eMailTB.Name = "eMailTB";
            this.eMailTB.Size = new System.Drawing.Size(170, 22);
            this.eMailTB.TabIndex = 0;
            // 
            // sifreTB
            // 
            this.sifreTB.Location = new System.Drawing.Point(229, 241);
            this.sifreTB.Name = "sifreTB";
            this.sifreTB.Size = new System.Drawing.Size(170, 22);
            this.sifreTB.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.emailLabel.Location = new System.Drawing.Point(139, 166);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(69, 23);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "E-Mail";
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.BackColor = System.Drawing.Color.Transparent;
            this.sifreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifreLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sifreLabel.Location = new System.Drawing.Point(141, 235);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(67, 28);
            this.sifreLabel.TabIndex = 3;
            this.sifreLabel.Text = "Şifre";
            // 
            // girisYap
            // 
            this.girisYap.BackColor = System.Drawing.Color.Transparent;
            this.girisYap.Font = new System.Drawing.Font("WebFont", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYap.ForeColor = System.Drawing.Color.Black;
            this.girisYap.Location = new System.Drawing.Point(179, 290);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(114, 35);
            this.girisYap.TabIndex = 4;
            this.girisYap.Text = "Giriş Yap";
            this.girisYap.UseVisualStyleBackColor = false;
            this.girisYap.Click += new System.EventHandler(this.girisYap_Click);
            // 
            // kaydol
            // 
            this.kaydol.BackColor = System.Drawing.Color.Transparent;
            this.kaydol.Font = new System.Drawing.Font("WebFont", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydol.ForeColor = System.Drawing.Color.Black;
            this.kaydol.Location = new System.Drawing.Point(326, 289);
            this.kaydol.Name = "kaydol";
            this.kaydol.Size = new System.Drawing.Size(114, 36);
            this.kaydol.TabIndex = 5;
            this.kaydol.Text = "Kayıt Ol";
            this.kaydol.UseVisualStyleBackColor = false;
            this.kaydol.Click += new System.EventHandler(this.kaydol_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Proje.Properties.Resources._010;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(229, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 153);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AnaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proje.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 337);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kaydol);
            this.Controls.Add(this.girisYap);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.sifreTB);
            this.Controls.Add(this.eMailTB);
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaPanel";
            this.Text = "SAÜ Kütüphane Giriş Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eMailTB;
        private System.Windows.Forms.TextBox sifreTB;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.Button girisYap;
        private System.Windows.Forms.Button kaydol;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

