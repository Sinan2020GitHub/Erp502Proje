namespace MixErp302.Urun
{
    partial class frmUrunAlis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVade = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtUKod = new System.Windows.Forms.ComboBox();
            this.txtAraToplam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKdvToplam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOdeme = new System.Windows.Forms.ComboBox();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.UrunKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.araKdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.ComboBox();
            this.split2 = new System.Windows.Forms.SplitContainer();
            this.txtAlisTarih = new System.Windows.Forms.DateTimePicker();
            this.split1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlisGrupNo = new System.Windows.Forms.TextBox();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split2)).BeginInit();
            this.split2.Panel1.SuspendLayout();
            this.split2.Panel2.SuspendLayout();
            this.split2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split1)).BeginInit();
            this.split1.Panel1.SuspendLayout();
            this.split1.Panel2.SuspendLayout();
            this.split1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(0, 355);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(131, 46);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Red;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(131, 54);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(346, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Vade :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cari Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ödeme Türü :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alış Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fatura No :";
            // 
            // txtVade
            // 
            this.txtVade.FormattingEnabled = true;
            this.txtVade.Items.AddRange(new object[] {
            "Belirtilmemiş",
            "1",
            "3",
            "4",
            "5",
            "6",
            "9",
            "12"});
            this.txtVade.Location = new System.Drawing.Point(388, 9);
            this.txtVade.Margin = new System.Windows.Forms.Padding(2);
            this.txtVade.Name = "txtVade";
            this.txtVade.Size = new System.Drawing.Size(123, 21);
            this.txtVade.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Orange;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(8, 6);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(56, 25);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlUst.Controls.Add(this.txtUKod);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.txtAraToplam);
            this.pnlUst.Controls.Add(this.label8);
            this.pnlUst.Controls.Add(this.txtGenelToplam);
            this.pnlUst.Controls.Add(this.label7);
            this.pnlUst.Controls.Add(this.txtKdvToplam);
            this.pnlUst.Controls.Add(this.label2);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUst.Location = new System.Drawing.Point(0, 206);
            this.pnlUst.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(792, 91);
            this.pnlUst.TabIndex = 0;
            // 
            // txtUKod
            // 
            this.txtUKod.FormattingEnabled = true;
            this.txtUKod.Location = new System.Drawing.Point(8, 35);
            this.txtUKod.Name = "txtUKod";
            this.txtUKod.Size = new System.Drawing.Size(121, 21);
            this.txtUKod.TabIndex = 4;
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.Location = new System.Drawing.Point(633, 11);
            this.txtAraToplam.Margin = new System.Windows.Forms.Padding(2);
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.Size = new System.Drawing.Size(123, 20);
            this.txtAraToplam.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(550, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ara Toplam :";
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Location = new System.Drawing.Point(633, 60);
            this.txtGenelToplam.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(123, 20);
            this.txtGenelToplam.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(536, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Genel Toplam :";
            // 
            // txtKdvToplam
            // 
            this.txtKdvToplam.Location = new System.Drawing.Point(633, 35);
            this.txtKdvToplam.Margin = new System.Windows.Forms.Padding(2);
            this.txtKdvToplam.Name = "txtKdvToplam";
            this.txtKdvToplam.Size = new System.Drawing.Size(123, 20);
            this.txtKdvToplam.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(544, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "KDV Toplam :";
            // 
            // txtOdeme
            // 
            this.txtOdeme.FormattingEnabled = true;
            this.txtOdeme.Location = new System.Drawing.Point(388, 38);
            this.txtOdeme.Margin = new System.Windows.Forms.Padding(2);
            this.txtOdeme.Name = "txtOdeme";
            this.txtOdeme.Size = new System.Drawing.Size(124, 21);
            this.txtOdeme.TabIndex = 1;
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunKod,
            this.UrunAciklama,
            this.Birim,
            this.BFiyat,
            this.Adet,
            this.araKdv});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Margin = new System.Windows.Forms.Padding(2);
            this.Liste.Name = "Liste";
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(792, 206);
            this.Liste.TabIndex = 1;
            this.Liste.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellEndEdit);
            this.Liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Liste_EditingControlShowing);
            // 
            // UrunKod
            // 
            this.UrunKod.HeaderText = "Ürün Kodu";
            this.UrunKod.Name = "UrunKod";
            this.UrunKod.Width = 83;
            // 
            // UrunAciklama
            // 
            this.UrunAciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunAciklama.HeaderText = "Ürün Açıklama";
            this.UrunAciklama.Name = "UrunAciklama";
            // 
            // Birim
            // 
            this.Birim.HeaderText = "Birim";
            this.Birim.Name = "Birim";
            // 
            // BFiyat
            // 
            dataGridViewCellStyle4.Format = "C2";
            this.BFiyat.DefaultCellStyle = dataGridViewCellStyle4;
            this.BFiyat.HeaderText = "Birim Fiyat";
            this.BFiyat.Name = "BFiyat";
            // 
            // Adet
            // 
            dataGridViewCellStyle5.Format = "N0";
            this.Adet.DefaultCellStyle = dataGridViewCellStyle5;
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            // 
            // araKdv
            // 
            dataGridViewCellStyle6.Format = "C2";
            this.araKdv.DefaultCellStyle = dataGridViewCellStyle6;
            this.araKdv.HeaderText = "Kdv Tutar";
            this.araKdv.Name = "araKdv";
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(80, 64);
            this.txtFaturaNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(123, 20);
            this.txtFaturaNo.TabIndex = 0;
            // 
            // txtCari
            // 
            this.txtCari.FormattingEnabled = true;
            this.txtCari.Location = new System.Drawing.Point(81, 8);
            this.txtCari.Margin = new System.Windows.Forms.Padding(2);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(200, 21);
            this.txtCari.TabIndex = 1;
            // 
            // split2
            // 
            this.split2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.split2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.split2.Location = new System.Drawing.Point(0, 0);
            this.split2.Margin = new System.Windows.Forms.Padding(2);
            this.split2.Name = "split2";
            this.split2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split2.Panel1
            // 
            this.split2.Panel1.Controls.Add(this.txtAlisTarih);
            this.split2.Panel1.Controls.Add(this.label11);
            this.split2.Panel1.Controls.Add(this.label5);
            this.split2.Panel1.Controls.Add(this.label4);
            this.split2.Panel1.Controls.Add(this.label3);
            this.split2.Panel1.Controls.Add(this.label1);
            this.split2.Panel1.Controls.Add(this.txtVade);
            this.split2.Panel1.Controls.Add(this.txtOdeme);
            this.split2.Panel1.Controls.Add(this.txtCari);
            this.split2.Panel1.Controls.Add(this.txtFaturaNo);
            // 
            // split2.Panel2
            // 
            this.split2.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.split2.Panel2.Controls.Add(this.Liste);
            this.split2.Panel2.Controls.Add(this.pnlUst);
            this.split2.Size = new System.Drawing.Size(796, 405);
            this.split2.SplitterDistance = 101;
            this.split2.SplitterWidth = 3;
            this.split2.TabIndex = 0;
            // 
            // txtAlisTarih
            // 
            this.txtAlisTarih.Location = new System.Drawing.Point(81, 38);
            this.txtAlisTarih.Name = "txtAlisTarih";
            this.txtAlisTarih.Size = new System.Drawing.Size(200, 20);
            this.txtAlisTarih.TabIndex = 4;
            // 
            // split1
            // 
            this.split1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.split1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.split1.Location = new System.Drawing.Point(0, 0);
            this.split1.Margin = new System.Windows.Forms.Padding(2);
            this.split1.Name = "split1";
            // 
            // split1.Panel1
            // 
            this.split1.Panel1.Controls.Add(this.split2);
            // 
            // split1.Panel2
            // 
            this.split1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.split1.Panel2.Controls.Add(this.btnKapat);
            this.split1.Panel2.Controls.Add(this.btnKaydet);
            this.split1.Panel2.Controls.Add(this.label6);
            this.split1.Panel2.Controls.Add(this.txtAlisGrupNo);
            this.split1.Size = new System.Drawing.Size(934, 405);
            this.split1.SplitterDistance = 796;
            this.split1.SplitterWidth = 3;
            this.split1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(2, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Alış Grup No :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAlisGrupNo
            // 
            this.txtAlisGrupNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlisGrupNo.Location = new System.Drawing.Point(2, 91);
            this.txtAlisGrupNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlisGrupNo.Name = "txtAlisGrupNo";
            this.txtAlisGrupNo.Size = new System.Drawing.Size(130, 20);
            this.txtAlisGrupNo.TabIndex = 0;
            // 
            // frmUrunAlis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 405);
            this.Controls.Add(this.split1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUrunAlis";
            this.Text = "frmUrunAlis";
            this.Load += new System.EventHandler(this.frmUrunAlis_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.split2.Panel1.ResumeLayout(false);
            this.split2.Panel1.PerformLayout();
            this.split2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split2)).EndInit();
            this.split2.ResumeLayout(false);
            this.split1.Panel1.ResumeLayout(false);
            this.split1.Panel2.ResumeLayout(false);
            this.split1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split1)).EndInit();
            this.split1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtVade;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.ComboBox txtOdeme;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.ComboBox txtCari;
        private System.Windows.Forms.SplitContainer split2;
        private System.Windows.Forms.SplitContainer split1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlisGrupNo;
        private System.Windows.Forms.DateTimePicker txtAlisTarih;
        private System.Windows.Forms.TextBox txtAraToplam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKdvToplam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtUKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn BFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn araKdv;
    }
}