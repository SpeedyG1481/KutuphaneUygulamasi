namespace Proje
{
    partial class UyePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyePanel));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Kiralama = new System.Windows.Forms.TabPage();
            this.satinAlTikla = new System.Windows.Forms.Button();
            this.kitaplar = new System.Windows.Forms.DataGridView();
            this.kiralaTikla = new System.Windows.Forms.Button();
            this.iade = new System.Windows.Forms.TabPage();
            this.cikis = new System.Windows.Forms.Button();
            this.hosGeldin = new System.Windows.Forms.Label();
            this.programiKapat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Kiralama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Kiralama);
            this.tabControl1.Controls.Add(this.iade);
            this.tabControl1.Location = new System.Drawing.Point(12, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1558, 780);
            this.tabControl1.TabIndex = 1;
            // 
            // Kiralama
            // 
            this.Kiralama.BackgroundImage = global::Proje.Properties.Resources.images;
            this.Kiralama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Kiralama.Controls.Add(this.satinAlTikla);
            this.Kiralama.Controls.Add(this.kitaplar);
            this.Kiralama.Controls.Add(this.kiralaTikla);
            this.Kiralama.Location = new System.Drawing.Point(4, 25);
            this.Kiralama.Name = "Kiralama";
            this.Kiralama.Padding = new System.Windows.Forms.Padding(3);
            this.Kiralama.Size = new System.Drawing.Size(1550, 751);
            this.Kiralama.TabIndex = 0;
            this.Kiralama.Text = "Kiralama & Satın Alma";
            this.Kiralama.UseVisualStyleBackColor = true;
            // 
            // satinAlTikla
            // 
            this.satinAlTikla.Location = new System.Drawing.Point(184, 25);
            this.satinAlTikla.Name = "satinAlTikla";
            this.satinAlTikla.Size = new System.Drawing.Size(115, 68);
            this.satinAlTikla.TabIndex = 4;
            this.satinAlTikla.Text = "Satın Al";
            this.satinAlTikla.UseVisualStyleBackColor = true;
            // 
            // kitaplar
            // 
            this.kitaplar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.kitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplar.Location = new System.Drawing.Point(0, 114);
            this.kitaplar.Name = "kitaplar";
            this.kitaplar.RowHeadersWidth = 51;
            this.kitaplar.RowTemplate.Height = 24;
            this.kitaplar.Size = new System.Drawing.Size(1544, 675);
            this.kitaplar.TabIndex = 3;
            // 
            // kiralaTikla
            // 
            this.kiralaTikla.Location = new System.Drawing.Point(12, 25);
            this.kiralaTikla.Name = "kiralaTikla";
            this.kiralaTikla.Size = new System.Drawing.Size(119, 68);
            this.kiralaTikla.TabIndex = 3;
            this.kiralaTikla.Text = "Kirala";
            this.kiralaTikla.UseVisualStyleBackColor = true;
            this.kiralaTikla.Click += new System.EventHandler(this.kiralaTikla_Click);
            // 
            // iade
            // 
            this.iade.Location = new System.Drawing.Point(4, 25);
            this.iade.Name = "iade";
            this.iade.Padding = new System.Windows.Forms.Padding(3);
            this.iade.Size = new System.Drawing.Size(1550, 751);
            this.iade.TabIndex = 1;
            this.iade.Text = "İade";
            this.iade.UseVisualStyleBackColor = true;
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(1283, 9);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(102, 29);
            this.cikis.TabIndex = 2;
            this.cikis.Text = "Çıkış Yap";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // hosGeldin
            // 
            this.hosGeldin.AutoSize = true;
            this.hosGeldin.BackColor = System.Drawing.Color.Transparent;
            this.hosGeldin.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosGeldin.Location = new System.Drawing.Point(12, 19);
            this.hosGeldin.Name = "hosGeldin";
            this.hosGeldin.Size = new System.Drawing.Size(148, 25);
            this.hosGeldin.TabIndex = 3;
            this.hosGeldin.Text = "Hoşgeldiniz.";
            // 
            // programiKapat
            // 
            this.programiKapat.Location = new System.Drawing.Point(1412, 9);
            this.programiKapat.Name = "programiKapat";
            this.programiKapat.Size = new System.Drawing.Size(148, 29);
            this.programiKapat.TabIndex = 4;
            this.programiKapat.Text = "Programı Kapat";
            this.programiKapat.UseVisualStyleBackColor = true;
            this.programiKapat.Click += new System.EventHandler(this.programiKapat_Click);
            // 
            // UyePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proje.Properties.Resources.images__1_;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.programiKapat);
            this.Controls.Add(this.hosGeldin);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UyePanel";
            this.Text = "SAÜ Kütüphane Üye Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UyePanel_Load);
            this.tabControl1.ResumeLayout(false);
            this.Kiralama.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Kiralama;
        private System.Windows.Forms.TabPage iade;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.DataGridView kitaplar;
        private System.Windows.Forms.Button satinAlTikla;
        private System.Windows.Forms.Button kiralaTikla;
        private System.Windows.Forms.Label hosGeldin;
        private System.Windows.Forms.Button programiKapat;
    }
}