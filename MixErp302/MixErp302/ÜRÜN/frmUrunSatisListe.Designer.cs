namespace MixErp302.Urun
{
    partial class frmUrunSatisListe
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.liste = new System.Windows.Forms.DataGridView();
            this.UrunAlisGrupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKapatt = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.btnKapatt);
            this.splitContainer1.Panel2.Controls.Add(this.btnBul);
            this.splitContainer1.Size = new System.Drawing.Size(918, 475);
            this.splitContainer1.SplitterDistance = 733;
            this.splitContainer1.TabIndex = 0;
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunAlisGrupNo,
            this.CariAdii,
            this.Atarih});
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(0, 0);
            this.liste.Margin = new System.Windows.Forms.Padding(2);
            this.liste.Name = "liste";
            this.liste.RowTemplate.Height = 24;
            this.liste.Size = new System.Drawing.Size(733, 475);
            this.liste.TabIndex = 1;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // UrunAlisGrupNo
            // 
            this.UrunAlisGrupNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UrunAlisGrupNo.HeaderText = "Grup No";
            this.UrunAlisGrupNo.Name = "UrunAlisGrupNo";
            this.UrunAlisGrupNo.Width = 72;
            // 
            // CariAdii
            // 
            this.CariAdii.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdii.HeaderText = "Cari Adı";
            this.CariAdii.Name = "CariAdii";
            // 
            // Atarih
            // 
            this.Atarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Atarih.HeaderText = "Alış Tarihi";
            this.Atarih.Name = "Atarih";
            this.Atarih.Width = 77;
            // 
            // btnKapatt
            // 
            this.btnKapatt.BackColor = System.Drawing.Color.Red;
            this.btnKapatt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKapatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapatt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKapatt.Location = new System.Drawing.Point(0, 422);
            this.btnKapatt.Name = "btnKapatt";
            this.btnKapatt.Size = new System.Drawing.Size(181, 53);
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
            this.btnBul.Size = new System.Drawing.Size(181, 53);
            this.btnBul.TabIndex = 3;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // frmUrunSatisListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 475);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmUrunSatisListe";
            this.Text = "frmUrunSatisListe";
            this.Load += new System.EventHandler(this.frmUrunSatisListe_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAlisGrupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdii;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atarih;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnKapatt;
    }
}