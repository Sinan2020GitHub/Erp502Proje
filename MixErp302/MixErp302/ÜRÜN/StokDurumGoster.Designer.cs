namespace MixErp302.ÜRÜN
{
    partial class StokDurumGoster
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
            this.liste = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.btnKapatt = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepoAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ambar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StokKodu,
            this.UrunAciklama,
            this.UrunAdi,
            this.DepoAdet,
            this.Raf,
            this.Ambar,
            this.OBFiyat});
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(0, 0);
            this.liste.Margin = new System.Windows.Forms.Padding(2);
            this.liste.Name = "liste";
            this.liste.RowTemplate.Height = 24;
            this.liste.Size = new System.Drawing.Size(781, 489);
            this.liste.TabIndex = 1;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.liste);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Yellow;
            this.splitContainer1.Panel2.Controls.Add(this.txtBul);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapatt);
            this.splitContainer1.Panel2.Controls.Add(this.btnBul);
            this.splitContainer1.Size = new System.Drawing.Size(980, 489);
            this.splitContainer1.SplitterDistance = 781;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(16, 59);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(140, 20);
            this.txtBul.TabIndex = 5;
            
            // 
            // btnKapatt
            // 
            this.btnKapatt.BackColor = System.Drawing.Color.Red;
            this.btnKapatt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKapatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapatt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKapatt.Location = new System.Drawing.Point(0, 436);
            this.btnKapatt.Name = "btnKapatt";
            this.btnKapatt.Size = new System.Drawing.Size(195, 53);
            this.btnKapatt.TabIndex = 4;
            this.btnKapatt.Text = "Kapat";
            this.btnKapatt.UseVisualStyleBackColor = false;
            this.btnKapatt.Click += new System.EventHandler(this.btnKapatt_Click);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBul.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.ForeColor = System.Drawing.Color.Green;
            this.btnBul.Location = new System.Drawing.Point(0, 0);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(195, 53);
            this.btnBul.TabIndex = 3;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // StokKodu
            // 
            this.StokKodu.HeaderText = "Stok Kodu";
            this.StokKodu.Name = "StokKodu";
            // 
            // UrunAciklama
            // 
            this.UrunAciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunAciklama.HeaderText = "Ürün Açıklama";
            this.UrunAciklama.Name = "UrunAciklama";
            // 
            // UrunAdi
            // 
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            // 
            // DepoAdet
            // 
            this.DepoAdet.HeaderText = "DepoAdet";
            this.DepoAdet.Name = "DepoAdet";
            // 
            // Raf
            // 
            this.Raf.HeaderText = "Raf";
            this.Raf.Name = "Raf";
            // 
            // Ambar
            // 
            this.Ambar.HeaderText = "Ambar";
            this.Ambar.Name = "Ambar";
            // 
            // OBFiyat
            // 
            this.OBFiyat.HeaderText = "OBFiyat";
            this.OBFiyat.Name = "OBFiyat";
            // 
            // StokDurumGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 489);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StokDurumGoster";
            this.Text = "StokDurumGoster";
            this.Load += new System.EventHandler(this.StokDurumGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnKapatt;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepoAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ambar;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBFiyat;
    }
}