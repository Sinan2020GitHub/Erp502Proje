namespace MixErp302.Urun
{
    partial class frmUrunSatis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSatisGrupNo = new System.Windows.Forms.TextBox();
            this.txtVade = new System.Windows.Forms.ComboBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.txtSatisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.split2 = new System.Windows.Forms.SplitContainer();
            this.txtCari = new System.Windows.Forms.ComboBox();
            this.txtOdemeTuru = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.liste = new System.Windows.Forms.DataGridView();
            this.pnlÜst = new System.Windows.Forms.Panel();
            this.txtKarOrani = new System.Windows.Forms.ComboBox();
            this.txtUrunKodu = new System.Windows.Forms.ComboBox();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.txtKdvToplam = new System.Windows.Forms.TextBox();
            this.txtAraToplam = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.split1 = new System.Windows.Forms.SplitContainer();
            this.btnkaydett = new System.Windows.Forms.Button();
            this.btnKapa = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatisFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.araKdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.split2)).BeginInit();
            this.split2.Panel1.SuspendLayout();
            this.split2.Panel2.SuspendLayout();
            this.split2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.pnlÜst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split1)).BeginInit();
            this.split1.Panel1.SuspendLayout();
            this.split1.Panel2.SuspendLayout();
            this.split1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSatisGrupNo
            // 
            this.txtSatisGrupNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSatisGrupNo.Location = new System.Drawing.Point(3, 85);
            this.txtSatisGrupNo.Name = "txtSatisGrupNo";
            this.txtSatisGrupNo.Size = new System.Drawing.Size(194, 20);
            this.txtSatisGrupNo.TabIndex = 10;
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
            this.txtVade.Location = new System.Drawing.Point(356, 27);
            this.txtVade.Margin = new System.Windows.Forms.Padding(2);
            this.txtVade.Name = "txtVade";
            this.txtVade.Size = new System.Drawing.Size(112, 23);
            this.txtVade.TabIndex = 11;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(81, 90);
            this.txtDurum.Margin = new System.Windows.Forms.Padding(2);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(137, 21);
            this.txtDurum.TabIndex = 9;
            // 
            // txtSatisTarihi
            // 
            this.txtSatisTarihi.Location = new System.Drawing.Point(81, 60);
            this.txtSatisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSatisTarihi.Name = "txtSatisTarihi";
            this.txtSatisTarihi.Size = new System.Drawing.Size(138, 21);
            this.txtSatisTarihi.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(19, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "Durum";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(18, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "Satış Tarihi";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(26, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 15);
            this.label17.TabIndex = 3;
            this.label17.Text = "Cari Adı";
            // 
            // split2
            // 
            this.split2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.split2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.split2.Location = new System.Drawing.Point(0, 0);
            this.split2.Name = "split2";
            this.split2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split2.Panel1
            // 
            this.split2.Panel1.Controls.Add(this.txtCari);
            this.split2.Panel1.Controls.Add(this.txtVade);
            this.split2.Panel1.Controls.Add(this.txtOdemeTuru);
            this.split2.Panel1.Controls.Add(this.txtDurum);
            this.split2.Panel1.Controls.Add(this.txtSatisTarihi);
            this.split2.Panel1.Controls.Add(this.label11);
            this.split2.Panel1.Controls.Add(this.label10);
            this.split2.Panel1.Controls.Add(this.label15);
            this.split2.Panel1.Controls.Add(this.label16);
            this.split2.Panel1.Controls.Add(this.label17);
            this.split2.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.split2.Panel1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            // 
            // split2.Panel2
            // 
            this.split2.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.split2.Panel2.Controls.Add(this.liste);
            this.split2.Panel2.Controls.Add(this.pnlÜst);
            this.split2.Size = new System.Drawing.Size(739, 499);
            this.split2.SplitterDistance = 159;
            this.split2.TabIndex = 0;
            // 
            // txtCari
            // 
            this.txtCari.FormattingEnabled = true;
            this.txtCari.Location = new System.Drawing.Point(82, 28);
            this.txtCari.Margin = new System.Windows.Forms.Padding(2);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(137, 23);
            this.txtCari.TabIndex = 12;
            // 
            // txtOdemeTuru
            // 
            this.txtOdemeTuru.FormattingEnabled = true;
            this.txtOdemeTuru.Location = new System.Drawing.Point(357, 57);
            this.txtOdemeTuru.Margin = new System.Windows.Forms.Padding(2);
            this.txtOdemeTuru.Name = "txtOdemeTuru";
            this.txtOdemeTuru.Size = new System.Drawing.Size(112, 23);
            this.txtOdemeTuru.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(266, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ödeme Türü";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(308, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Vade";
            // 
            // liste
            // 
            this.liste.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunKodu,
            this.UrunAciklama,
            this.Birim,
            this.BFiyat,
            this.SatisFiyat,
            this.Adet,
            this.araKdv,
            this.Idd,
            this.Sadet});
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(0, 0);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(735, 219);
            this.liste.TabIndex = 1;
            this.liste.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.liste_CellEndEdit);
            this.liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.liste_EditingControlShowing);
            // 
            // pnlÜst
            // 
            this.pnlÜst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlÜst.Controls.Add(this.txtKarOrani);
            this.pnlÜst.Controls.Add(this.txtUrunKodu);
            this.pnlÜst.Controls.Add(this.txtGenelToplam);
            this.pnlÜst.Controls.Add(this.txtKdvToplam);
            this.pnlÜst.Controls.Add(this.txtAraToplam);
            this.pnlÜst.Controls.Add(this.btnSil);
            this.pnlÜst.Controls.Add(this.txt);
            this.pnlÜst.Controls.Add(this.label1);
            this.pnlÜst.Controls.Add(this.label14);
            this.pnlÜst.Controls.Add(this.label12);
            this.pnlÜst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlÜst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlÜst.Location = new System.Drawing.Point(0, 219);
            this.pnlÜst.Name = "pnlÜst";
            this.pnlÜst.Size = new System.Drawing.Size(735, 113);
            this.pnlÜst.TabIndex = 0;
            // 
            // txtKarOrani
            // 
            this.txtKarOrani.FormattingEnabled = true;
            this.txtKarOrani.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.txtKarOrani.Location = new System.Drawing.Point(270, 39);
            this.txtKarOrani.Name = "txtKarOrani";
            this.txtKarOrani.Size = new System.Drawing.Size(121, 23);
            this.txtKarOrani.TabIndex = 13;
            this.txtKarOrani.SelectedIndexChanged += new System.EventHandler(this.txtKarOrani_SelectedIndexChanged);
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.FormattingEnabled = true;
            this.txtUrunKodu.Location = new System.Drawing.Point(3, 56);
            this.txtUrunKodu.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(120, 23);
            this.txtUrunKodu.TabIndex = 2;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenelToplam.Location = new System.Drawing.Point(549, 70);
            this.txtGenelToplam.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(107, 21);
            this.txtGenelToplam.TabIndex = 7;
            // 
            // txtKdvToplam
            // 
            this.txtKdvToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKdvToplam.Location = new System.Drawing.Point(549, 42);
            this.txtKdvToplam.Margin = new System.Windows.Forms.Padding(2);
            this.txtKdvToplam.Name = "txtKdvToplam";
            this.txtKdvToplam.Size = new System.Drawing.Size(107, 21);
            this.txtKdvToplam.TabIndex = 7;
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAraToplam.Location = new System.Drawing.Point(549, 12);
            this.txtAraToplam.Margin = new System.Windows.Forms.Padding(2);
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.Size = new System.Drawing.Size(107, 21);
            this.txtAraToplam.TabIndex = 7;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Yellow;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSil.Location = new System.Drawing.Point(3, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 35);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt.Location = new System.Drawing.Point(464, 15);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(80, 15);
            this.txt.TabIndex = 3;
            this.txt.Text = "Ara Toplam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(169, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kar Oranı";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(462, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Kdv Toplam";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(450, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Genel Toplam";
            // 
            // split1
            // 
            this.split1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.split1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.split1.Location = new System.Drawing.Point(0, 0);
            this.split1.Name = "split1";
            // 
            // split1.Panel1
            // 
            this.split1.Panel1.Controls.Add(this.split2);
            // 
            // split1.Panel2
            // 
            this.split1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.split1.Panel2.Controls.Add(this.btnkaydett);
            this.split1.Panel2.Controls.Add(this.btnKapa);
            this.split1.Panel2.Controls.Add(this.label18);
            this.split1.Panel2.Controls.Add(this.txtSatisGrupNo);
            this.split1.Size = new System.Drawing.Size(956, 499);
            this.split1.SplitterDistance = 739;
            this.split1.TabIndex = 8;
            // 
            // btnkaydett
            // 
            this.btnkaydett.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnkaydett.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydett.ForeColor = System.Drawing.Color.Red;
            this.btnkaydett.Location = new System.Drawing.Point(0, 0);
            this.btnkaydett.Name = "btnkaydett";
            this.btnkaydett.Size = new System.Drawing.Size(209, 53);
            this.btnkaydett.TabIndex = 2;
            this.btnkaydett.Text = "Kaydet";
            this.btnkaydett.UseVisualStyleBackColor = true;
            this.btnkaydett.Click += new System.EventHandler(this.btnkaydett_Click);
            // 
            // btnKapa
            // 
            this.btnKapa.BackColor = System.Drawing.Color.Red;
            this.btnKapa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKapa.Location = new System.Drawing.Point(0, 442);
            this.btnKapa.Name = "btnKapa";
            this.btnKapa.Size = new System.Drawing.Size(209, 53);
            this.btnKapa.TabIndex = 2;
            this.btnKapa.Text = "Kapat";
            this.btnKapa.UseVisualStyleBackColor = false;
            this.btnKapa.Click += new System.EventHandler(this.btnKapa_Click);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(3, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(194, 22);
            this.label18.TabIndex = 3;
            this.label18.Text = "Satış Grup No";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UrunKodu.HeaderText = "Ürün Kodu";
            this.UrunKodu.Name = "UrunKodu";
            this.UrunKodu.Width = 83;
            // 
            // UrunAciklama
            // 
            this.UrunAciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunAciklama.HeaderText = "Ürün Açıklama";
            this.UrunAciklama.Name = "UrunAciklama";
            // 
            // Birim
            // 
            this.Birim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Birim.HeaderText = "Birim";
            this.Birim.Name = "Birim";
            this.Birim.Width = 54;
            // 
            // BFiyat
            // 
            this.BFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Format = "C2";
            this.BFiyat.DefaultCellStyle = dataGridViewCellStyle1;
            this.BFiyat.HeaderText = "Birim Fiyat";
            this.BFiyat.Name = "BFiyat";
            this.BFiyat.Width = 79;
            // 
            // SatisFiyat
            // 
            this.SatisFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SatisFiyat.HeaderText = "Satış Fiyatı";
            this.SatisFiyat.Name = "SatisFiyat";
            this.SatisFiyat.Width = 82;
            // 
            // Adet
            // 
            this.Adet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Format = "N0";
            this.Adet.DefaultCellStyle = dataGridViewCellStyle2;
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            this.Adet.Width = 54;
            // 
            // araKdv
            // 
            this.araKdv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Format = "C2";
            this.araKdv.DefaultCellStyle = dataGridViewCellStyle3;
            this.araKdv.HeaderText = "Kdv Tutar";
            this.araKdv.Name = "araKdv";
            this.araKdv.Width = 79;
            // 
            // Idd
            // 
            this.Idd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Idd.HeaderText = "Id";
            this.Idd.Name = "Idd";
            this.Idd.Width = 41;
            // 
            // Sadet
            // 
            this.Sadet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sadet.HeaderText = "Stok Adet";
            this.Sadet.Name = "Sadet";
            this.Sadet.Width = 79;
            // 
            // frmUrunSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 499);
            this.Controls.Add(this.split1);
            this.Name = "frmUrunSatis";
            this.Text = "frmUrunSatis";
            this.Load += new System.EventHandler(this.frmUrunSatis_Load);
            this.split2.Panel1.ResumeLayout(false);
            this.split2.Panel1.PerformLayout();
            this.split2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split2)).EndInit();
            this.split2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.pnlÜst.ResumeLayout(false);
            this.pnlÜst.PerformLayout();
            this.split1.Panel1.ResumeLayout(false);
            this.split1.Panel2.ResumeLayout(false);
            this.split1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split1)).EndInit();
            this.split1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSatisGrupNo;
        private System.Windows.Forms.ComboBox txtVade;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.DateTimePicker txtSatisTarihi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.SplitContainer split2;
        private System.Windows.Forms.ComboBox txtCari;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.Panel pnlÜst;
        private System.Windows.Forms.ComboBox txtUrunKodu;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.TextBox txtKdvToplam;
        private System.Windows.Forms.TextBox txtAraToplam;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.SplitContainer split1;
        private System.Windows.Forms.Button btnkaydett;
        private System.Windows.Forms.Button btnKapa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox txtKarOrani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtOdemeTuru;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn BFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatisFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn araKdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadet;
    }
}