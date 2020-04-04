namespace Stok
{
    partial class frmUrunListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMiktari = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.satisFiyatiTxt = new System.Windows.Forms.TextBox();
            this.alisFiyatiTxt = new System.Windows.Forms.TextBox();
            this.miktarTxt = new System.Windows.Forms.TextBox();
            this.urunAdiTxt = new System.Windows.Forms.TextBox();
            this.markaTxt = new System.Windows.Forms.TextBox();
            this.kategoriTxt = new System.Windows.Forms.TextBox();
            this.barkodNoTxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtBarkodnoAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblMiktari
            // 
            this.lblMiktari.AutoSize = true;
            this.lblMiktari.Location = new System.Drawing.Point(40, 389);
            this.lblMiktari.Name = "lblMiktari";
            this.lblMiktari.Size = new System.Drawing.Size(0, 17);
            this.lblMiktari.TabIndex = 37;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(133, 383);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(90, 40);
            this.btnGuncelle.TabIndex = 25;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Satış Fiyatı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Alış Fiyatı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Miktarı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Ürün Adı :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Marka :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "Kategori :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Barkod No :";
            // 
            // satisFiyatiTxt
            // 
            this.satisFiyatiTxt.Location = new System.Drawing.Point(123, 343);
            this.satisFiyatiTxt.Name = "satisFiyatiTxt";
            this.satisFiyatiTxt.Size = new System.Drawing.Size(100, 22);
            this.satisFiyatiTxt.TabIndex = 29;
            // 
            // alisFiyatiTxt
            // 
            this.alisFiyatiTxt.Location = new System.Drawing.Point(123, 300);
            this.alisFiyatiTxt.Name = "alisFiyatiTxt";
            this.alisFiyatiTxt.Size = new System.Drawing.Size(100, 22);
            this.alisFiyatiTxt.TabIndex = 28;
            // 
            // miktarTxt
            // 
            this.miktarTxt.Location = new System.Drawing.Point(123, 257);
            this.miktarTxt.Name = "miktarTxt";
            this.miktarTxt.Size = new System.Drawing.Size(100, 22);
            this.miktarTxt.TabIndex = 27;
            // 
            // urunAdiTxt
            // 
            this.urunAdiTxt.Location = new System.Drawing.Point(123, 214);
            this.urunAdiTxt.Name = "urunAdiTxt";
            this.urunAdiTxt.Size = new System.Drawing.Size(100, 22);
            this.urunAdiTxt.TabIndex = 26;
            // 
            // markaTxt
            // 
            this.markaTxt.Location = new System.Drawing.Point(123, 171);
            this.markaTxt.Name = "markaTxt";
            this.markaTxt.ReadOnly = true;
            this.markaTxt.Size = new System.Drawing.Size(100, 22);
            this.markaTxt.TabIndex = 24;
            // 
            // kategoriTxt
            // 
            this.kategoriTxt.Location = new System.Drawing.Point(123, 128);
            this.kategoriTxt.Name = "kategoriTxt";
            this.kategoriTxt.ReadOnly = true;
            this.kategoriTxt.Size = new System.Drawing.Size(100, 22);
            this.kategoriTxt.TabIndex = 23;
            // 
            // barkodNoTxt
            // 
            this.barkodNoTxt.Location = new System.Drawing.Point(123, 85);
            this.barkodNoTxt.Name = "barkodNoTxt";
            this.barkodNoTxt.Size = new System.Drawing.Size(100, 22);
            this.barkodNoTxt.TabIndex = 22;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(786, 108);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 38;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkodnoAra
            // 
            this.txtBarkodnoAra.Location = new System.Drawing.Point(582, 44);
            this.txtBarkodnoAra.Name = "txtBarkodnoAra";
            this.txtBarkodnoAra.Size = new System.Drawing.Size(100, 22);
            this.txtBarkodnoAra.TabIndex = 39;
            this.txtBarkodnoAra.TextChanged += new System.EventHandler(this.txtBarkodnoAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Borkodno\'ya göre ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Güncellemek istediğiniz ürüne çift tıklayınız.";
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(421, 417);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(113, 24);
            this.comboKategori.TabIndex = 42;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(421, 463);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(113, 24);
            this.comboMarka.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Marka :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Kategori :";
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(554, 424);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(88, 51);
            this.btnMarkaGuncelle.TabIndex = 46;
            this.btnMarkaGuncelle.Text = "Marka Güncelle";
            this.btnMarkaGuncelle.UseVisualStyleBackColor = true;
            this.btnMarkaGuncelle.Click += new System.EventHandler(this.btnMarkaGuncelle_Click);
            // 
            // frmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 507);
            this.Controls.Add(this.btnMarkaGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodnoAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblMiktari);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.satisFiyatiTxt);
            this.Controls.Add(this.alisFiyatiTxt);
            this.Controls.Add(this.miktarTxt);
            this.Controls.Add(this.urunAdiTxt);
            this.Controls.Add(this.markaTxt);
            this.Controls.Add(this.kategoriTxt);
            this.Controls.Add(this.barkodNoTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUrunListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmUrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMiktari;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox satisFiyatiTxt;
        private System.Windows.Forms.TextBox alisFiyatiTxt;
        private System.Windows.Forms.TextBox miktarTxt;
        private System.Windows.Forms.TextBox urunAdiTxt;
        private System.Windows.Forms.TextBox markaTxt;
        private System.Windows.Forms.TextBox kategoriTxt;
        private System.Windows.Forms.TextBox barkodNoTxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtBarkodnoAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMarkaGuncelle;
    }
}