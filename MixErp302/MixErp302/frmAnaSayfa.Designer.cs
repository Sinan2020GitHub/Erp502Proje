namespace MixErp302
{
    partial class frmAnaSayfa
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.pnlKur = new System.Windows.Forms.Panel();
            this.txtEuro = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnFatura = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btbUrun = new System.Windows.Forms.Button();
            this.btnBilgiDiris = new System.Windows.Forms.Button();
            this.gbLeft = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnKulGiris = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUrunGiris = new System.Windows.Forms.Button();
            this.btnCariGiris = new System.Windows.Forms.Button();
            this.btnPersonelGiris = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUrunSatisListele = new System.Windows.Forms.Button();
            this.btnUrunAlisListe = new System.Windows.Forms.Button();
            this.btnUrunSatis = new System.Windows.Forms.Button();
            this.btnUrunAlis = new System.Windows.Forms.Button();
            this.btnStokGit = new System.Windows.Forms.Button();
            this.pnlUst.SuspendLayout();
            this.pnlKur.SuspendLayout();
            this.gbLeft.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.AccessibleName = "pnlUst";
            this.pnlUst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlUst.Controls.Add(this.pnlKur);
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Controls.Add(this.btnAdmin);
            this.pnlUst.Controls.Add(this.btnFatura);
            this.pnlUst.Controls.Add(this.btnStok);
            this.pnlUst.Controls.Add(this.btbUrun);
            this.pnlUst.Controls.Add(this.btnBilgiDiris);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(890, 73);
            this.pnlUst.TabIndex = 0;
            // 
            // pnlKur
            // 
            this.pnlKur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlKur.Controls.Add(this.txtEuro);
            this.pnlKur.Controls.Add(this.txtDolar);
            this.pnlKur.Location = new System.Drawing.Point(491, 12);
            this.pnlKur.Name = "pnlKur";
            this.pnlKur.Size = new System.Drawing.Size(247, 32);
            this.pnlKur.TabIndex = 1;
            // 
            // txtEuro
            // 
            this.txtEuro.BackColor = System.Drawing.Color.Red;
            this.txtEuro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEuro.Location = new System.Drawing.Point(132, 3);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 23);
            this.txtEuro.TabIndex = 0;
            this.txtEuro.Text = "€";
            this.txtEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDolar
            // 
            this.txtDolar.BackColor = System.Drawing.Color.Blue;
            this.txtDolar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDolar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDolar.Location = new System.Drawing.Point(14, 3);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 23);
            this.txtDolar.TabIndex = 0;
            this.txtDolar.Text = "$";
            this.txtDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(803, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 32);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Magenta;
            this.btnAdmin.Location = new System.Drawing.Point(393, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 32);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnFatura
            // 
            this.btnFatura.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFatura.Location = new System.Drawing.Point(299, 12);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(75, 32);
            this.btnFatura.TabIndex = 0;
            this.btnFatura.Text = "Fatura";
            this.btnFatura.UseVisualStyleBackColor = true;
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // btnStok
            // 
            this.btnStok.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStok.Location = new System.Drawing.Point(201, 12);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(75, 32);
            this.btnStok.TabIndex = 0;
            this.btnStok.Text = "Stok";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btbUrun
            // 
            this.btbUrun.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btbUrun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btbUrun.Location = new System.Drawing.Point(107, 12);
            this.btbUrun.Name = "btbUrun";
            this.btbUrun.Size = new System.Drawing.Size(75, 32);
            this.btbUrun.TabIndex = 0;
            this.btbUrun.Text = "Ürün";
            this.btbUrun.UseVisualStyleBackColor = true;
            this.btbUrun.Click += new System.EventHandler(this.btbUrun_Click);
            // 
            // btnBilgiDiris
            // 
            this.btnBilgiDiris.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiDiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBilgiDiris.Location = new System.Drawing.Point(12, 12);
            this.btnBilgiDiris.Name = "btnBilgiDiris";
            this.btnBilgiDiris.Size = new System.Drawing.Size(75, 32);
            this.btnBilgiDiris.TabIndex = 0;
            this.btnBilgiDiris.Text = "Bilgi Giriş";
            this.btnBilgiDiris.UseVisualStyleBackColor = true;
            this.btnBilgiDiris.Click += new System.EventHandler(this.btnBilgiDiris_Click);
            // 
            // gbLeft
            // 
            this.gbLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbLeft.Controls.Add(this.panel2);
            this.gbLeft.Controls.Add(this.panel5);
            this.gbLeft.Controls.Add(this.panel1);
            this.gbLeft.Controls.Add(this.panel4);
            this.gbLeft.Controls.Add(this.panel3);
            this.gbLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbLeft.Location = new System.Drawing.Point(0, 73);
            this.gbLeft.Name = "gbLeft";
            this.gbLeft.Size = new System.Drawing.Size(151, 454);
            this.gbLeft.TabIndex = 0;
            this.gbLeft.TabStop = false;
            this.gbLeft.Text = "groupBox1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.btnKulGiris);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(447, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(148, 435);
            this.panel5.TabIndex = 1;
            this.panel5.Visible = false;
            // 
            // btnKulGiris
            // 
            this.btnKulGiris.Location = new System.Drawing.Point(3, 20);
            this.btnKulGiris.Name = "btnKulGiris";
            this.btnKulGiris.Size = new System.Drawing.Size(139, 23);
            this.btnKulGiris.TabIndex = 2;
            this.btnKulGiris.Text = "Kullanıcı Giriş";
            this.btnKulGiris.UseVisualStyleBackColor = true;
            this.btnKulGiris.Click += new System.EventHandler(this.btnKulGiris_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnUrunGiris);
            this.panel1.Controls.Add(this.btnCariGiris);
            this.panel1.Controls.Add(this.btnPersonelGiris);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(299, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 435);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // btnUrunGiris
            // 
            this.btnUrunGiris.Location = new System.Drawing.Point(3, 78);
            this.btnUrunGiris.Name = "btnUrunGiris";
            this.btnUrunGiris.Size = new System.Drawing.Size(139, 23);
            this.btnUrunGiris.TabIndex = 2;
            this.btnUrunGiris.Tag = "";
            this.btnUrunGiris.Text = "Ürün Giriş";
            this.btnUrunGiris.UseVisualStyleBackColor = true;
            this.btnUrunGiris.Click += new System.EventHandler(this.btnUrunGiris_Click_1);
            // 
            // btnCariGiris
            // 
            this.btnCariGiris.Location = new System.Drawing.Point(3, 49);
            this.btnCariGiris.Name = "btnCariGiris";
            this.btnCariGiris.Size = new System.Drawing.Size(139, 23);
            this.btnCariGiris.TabIndex = 3;
            this.btnCariGiris.Text = "Cari Giriş";
            this.btnCariGiris.UseVisualStyleBackColor = true;
            this.btnCariGiris.Click += new System.EventHandler(this.btnCariGiris_Click);
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.Location = new System.Drawing.Point(3, 20);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(139, 23);
            this.btnPersonelGiris.TabIndex = 2;
            this.btnPersonelGiris.Text = "Personel Giriş";
            this.btnPersonelGiris.UseVisualStyleBackColor = true;
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(151, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 435);
            this.panel4.TabIndex = 0;
            this.panel4.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.btnStokGit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 435);
            this.panel3.TabIndex = 0;
            this.panel3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnUrunSatisListele);
            this.panel2.Controls.Add(this.btnUrunAlisListe);
            this.panel2.Controls.Add(this.btnUrunSatis);
            this.panel2.Controls.Add(this.btnUrunAlis);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(595, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 435);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            // 
            // btnUrunSatisListele
            // 
            this.btnUrunSatisListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUrunSatisListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSatisListele.ForeColor = System.Drawing.Color.Yellow;
            this.btnUrunSatisListele.Location = new System.Drawing.Point(4, 136);
            this.btnUrunSatisListele.Name = "btnUrunSatisListele";
            this.btnUrunSatisListele.Size = new System.Drawing.Size(140, 23);
            this.btnUrunSatisListele.TabIndex = 0;
            this.btnUrunSatisListele.Text = "Ürün Satış Listesi";
            this.btnUrunSatisListele.UseVisualStyleBackColor = false;
            this.btnUrunSatisListele.Click += new System.EventHandler(this.btnUrunSatisListele_Click);
            // 
            // btnUrunAlisListe
            // 
            this.btnUrunAlisListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUrunAlisListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunAlisListe.ForeColor = System.Drawing.Color.Yellow;
            this.btnUrunAlisListe.Location = new System.Drawing.Point(2, 49);
            this.btnUrunAlisListe.Name = "btnUrunAlisListe";
            this.btnUrunAlisListe.Size = new System.Drawing.Size(140, 23);
            this.btnUrunAlisListe.TabIndex = 0;
            this.btnUrunAlisListe.Text = "Ürün Alış Listesi";
            this.btnUrunAlisListe.UseVisualStyleBackColor = false;
            this.btnUrunAlisListe.Click += new System.EventHandler(this.btnUrunAlisListe_Click);
            // 
            // btnUrunSatis
            // 
            this.btnUrunSatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUrunSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSatis.ForeColor = System.Drawing.Color.Yellow;
            this.btnUrunSatis.Location = new System.Drawing.Point(5, 107);
            this.btnUrunSatis.Name = "btnUrunSatis";
            this.btnUrunSatis.Size = new System.Drawing.Size(140, 23);
            this.btnUrunSatis.TabIndex = 0;
            this.btnUrunSatis.Text = "Ürün Satış";
            this.btnUrunSatis.UseVisualStyleBackColor = false;
            this.btnUrunSatis.Click += new System.EventHandler(this.btnUrunSatis_Click);
            // 
            // btnUrunAlis
            // 
            this.btnUrunAlis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUrunAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunAlis.ForeColor = System.Drawing.Color.Yellow;
            this.btnUrunAlis.Location = new System.Drawing.Point(3, 20);
            this.btnUrunAlis.Name = "btnUrunAlis";
            this.btnUrunAlis.Size = new System.Drawing.Size(140, 23);
            this.btnUrunAlis.TabIndex = 0;
            this.btnUrunAlis.Text = "Ürün Alış";
            this.btnUrunAlis.UseVisualStyleBackColor = false;
            this.btnUrunAlis.Click += new System.EventHandler(this.btnUrunAlis_Click);
            // 
            // btnStokGit
            // 
            this.btnStokGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokGit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStokGit.Location = new System.Drawing.Point(19, 20);
            this.btnStokGit.Name = "btnStokGit";
            this.btnStokGit.Size = new System.Drawing.Size(105, 23);
            this.btnStokGit.TabIndex = 0;
            this.btnStokGit.Text = "Stok Durum Göster";
            this.btnStokGit.UseVisualStyleBackColor = true;
            this.btnStokGit.Click += new System.EventHandler(this.btnStokGit_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 527);
            this.Controls.Add(this.gbLeft);
            this.Controls.Add(this.pnlUst);
            this.IsMdiContainer = true;
            this.Name = "frmAnaSayfa";
            this.Text = "frmAnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnaSayfa_FormClosing);
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlKur.ResumeLayout(false);
            this.gbLeft.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.GroupBox gbLeft;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btbUrun;
        private System.Windows.Forms.Button btnBilgiDiris;
        private System.Windows.Forms.Button btnPersonelGiris;
        private System.Windows.Forms.Button btnCariGiris;
        private System.Windows.Forms.Button btnUrunGiris;
        private System.Windows.Forms.Button btnUrunSatisListele;
        private System.Windows.Forms.Button btnUrunAlisListe;
        private System.Windows.Forms.Button btnUrunSatis;
        private System.Windows.Forms.Button btnUrunAlis;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnKulGiris;
        private System.Windows.Forms.Panel pnlKur;
        private System.Windows.Forms.Label txtEuro;
        private System.Windows.Forms.Label txtDolar;
        private System.Windows.Forms.Button btnStokGit;
    }
}