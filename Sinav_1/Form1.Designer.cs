namespace Sinav_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.grp_UrunEklemePaneli = new System.Windows.Forms.GroupBox();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.txtBirimFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.grp_AramaVeGuncellemePaneli = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstwUrunListele = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMs_Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.cMs_Guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_UrunEklemePaneli.SuspendLayout();
            this.grp_AramaVeGuncellemePaneli.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_UrunEklemePaneli
            // 
            this.grp_UrunEklemePaneli.Controls.Add(this.txtStokMiktari);
            this.grp_UrunEklemePaneli.Controls.Add(this.txtBirimFiyati);
            this.grp_UrunEklemePaneli.Controls.Add(this.txtUrunAdi);
            this.grp_UrunEklemePaneli.Controls.Add(this.btnUrunEkle);
            this.grp_UrunEklemePaneli.Controls.Add(this.label3);
            this.grp_UrunEklemePaneli.Controls.Add(this.label2);
            this.grp_UrunEklemePaneli.Controls.Add(this.label1);
            this.grp_UrunEklemePaneli.Location = new System.Drawing.Point(12, 28);
            this.grp_UrunEklemePaneli.Name = "grp_UrunEklemePaneli";
            this.grp_UrunEklemePaneli.Size = new System.Drawing.Size(325, 225);
            this.grp_UrunEklemePaneli.TabIndex = 0;
            this.grp_UrunEklemePaneli.TabStop = false;
            this.grp_UrunEklemePaneli.Text = "Ürün Ekleme Paneli";
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(115, 102);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(176, 22);
            this.txtStokMiktari.TabIndex = 6;
            // 
            // txtBirimFiyati
            // 
            this.txtBirimFiyati.Location = new System.Drawing.Point(115, 69);
            this.txtBirimFiyati.Name = "txtBirimFiyati";
            this.txtBirimFiyati.Size = new System.Drawing.Size(176, 22);
            this.txtBirimFiyati.TabIndex = 5;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(115, 37);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(176, 22);
            this.txtUrunAdi.TabIndex = 4;
            this.txtUrunAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAdi_KeyPress);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(102, 146);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(176, 40);
            this.btnUrunEkle.TabIndex = 3;
            this.btnUrunEkle.Text = "Ürünü Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Miktarı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birim Fiyatı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(160, 57);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(176, 22);
            this.txtAra.TabIndex = 7;
            // 
            // grp_AramaVeGuncellemePaneli
            // 
            this.grp_AramaVeGuncellemePaneli.Controls.Add(this.btnGuncelle);
            this.grp_AramaVeGuncellemePaneli.Controls.Add(this.btnAra);
            this.grp_AramaVeGuncellemePaneli.Controls.Add(this.label4);
            this.grp_AramaVeGuncellemePaneli.Controls.Add(this.txtAra);
            this.grp_AramaVeGuncellemePaneli.Location = new System.Drawing.Point(357, 28);
            this.grp_AramaVeGuncellemePaneli.Name = "grp_AramaVeGuncellemePaneli";
            this.grp_AramaVeGuncellemePaneli.Size = new System.Drawing.Size(401, 225);
            this.grp_AramaVeGuncellemePaneli.TabIndex = 8;
            this.grp_AramaVeGuncellemePaneli.TabStop = false;
            this.grp_AramaVeGuncellemePaneli.Text = "Ürün Arama ve Güncelleme Paneli";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(160, 146);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(176, 40);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(160, 100);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(176, 40);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aranacak Ürün Adı :";
            // 
            // lstwUrunListele
            // 
            this.lstwUrunListele.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstwUrunListele.ContextMenuStrip = this.contextMenuStrip1;
            this.lstwUrunListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstwUrunListele.FullRowSelect = true;
            this.lstwUrunListele.GridLines = true;
            this.lstwUrunListele.Location = new System.Drawing.Point(12, 259);
            this.lstwUrunListele.Name = "lstwUrunListele";
            this.lstwUrunListele.Size = new System.Drawing.Size(746, 296);
            this.lstwUrunListele.TabIndex = 9;
            this.lstwUrunListele.UseCompatibleStateImageBehavior = false;
            this.lstwUrunListele.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KOLON 1";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "KOLON 2";
            this.columnHeader2.Width = 204;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "KOLON 3";
            this.columnHeader3.Width = 203;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "KOLON 4";
            this.columnHeader4.Width = 521;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMs_Sil,
            this.cMs_Guncelle});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 56);
            // 
            // cMs_Sil
            // 
            this.cMs_Sil.Name = "cMs_Sil";
            this.cMs_Sil.Size = new System.Drawing.Size(135, 24);
            this.cMs_Sil.Text = "Sil";
            this.cMs_Sil.Click += new System.EventHandler(this.cMs_Sil_Click);
            // 
            // cMs_Guncelle
            // 
            this.cMs_Guncelle.Name = "cMs_Guncelle";
            this.cMs_Guncelle.Size = new System.Drawing.Size(181, 26);
            this.cMs_Guncelle.Text = "Güncelle";
            this.cMs_Guncelle.Click += new System.EventHandler(this.cMs_Guncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 573);
            this.Controls.Add(this.lstwUrunListele);
            this.Controls.Add(this.grp_AramaVeGuncellemePaneli);
            this.Controls.Add(this.grp_UrunEklemePaneli);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_UrunEklemePaneli.ResumeLayout(false);
            this.grp_UrunEklemePaneli.PerformLayout();
            this.grp_AramaVeGuncellemePaneli.ResumeLayout(false);
            this.grp_AramaVeGuncellemePaneli.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_UrunEklemePaneli;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.TextBox txtBirimFiyati;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.GroupBox grp_AramaVeGuncellemePaneli;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstwUrunListele;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cMs_Sil;
        private System.Windows.Forms.ToolStripMenuItem cMs_Guncelle;
    }
}

