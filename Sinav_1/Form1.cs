using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinav_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                        /*   create database UrunKayitDb
                             use UrunKayitDb

                             create table UrunBilgileri
                            (
                                 Id   INT NOT NULL IDENTITY(1 , 1) PRIMARY KEY ,
                                 UrunAdi NVARCHAR(50) NOT NULL ,
                                 BirimFiyat DECIMAL,
                                 StokMiktari INT,
                            )

                            */



        UrunKayitDbEntities urunDb = new UrunKayitDbEntities();


        void UrunDoldur()
        {
            lstwUrunListele.Items.Clear();

            foreach (UrunBilgileri item in urunDb.UrunBilgileris.ToList())
            {
                ListViewItem eleman = new ListViewItem();
                eleman.Text = item.Id.ToString();
                eleman.SubItems.Add(item.UrunAdi);
                eleman.SubItems.Add(item.BirimFiyat.ToString());
                eleman.SubItems.Add(item.StokMiktari.ToString());
                eleman.Tag = item;

                lstwUrunListele.Items.Add(eleman);
            }

        }
        void UrunAra(string ara)
        {
            lstwUrunListele.Items.Clear();
            foreach (UrunBilgileri item in urunDb.UrunBilgileris.Where(x => x.UrunAdi.StartsWith(ara)).ToList())
            {
                ListViewItem eleman = new ListViewItem();
                eleman.Text = item.Id.ToString();
                eleman.SubItems.Add(item.UrunAdi);
                eleman.SubItems.Add(item.BirimFiyat.ToString());
                eleman.SubItems.Add(item.StokMiktari.ToString());
                eleman.Tag = item;
               

                lstwUrunListele.Items.Add(eleman);
            }
        }
        void Temizle()
        {
            foreach (Control tool in grp_UrunEklemePaneli.Controls)
            {
                if (tool is TextBox)
                {
                    tool.Text = string.Empty;
                }

            }
            txtUrunAdi.Focus();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            UrunDoldur();
            btnGuncelle.Enabled = false;
        }
        private void txtUrunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {

            urunDb.UrunBilgileris.Add
                (
                new UrunBilgileri
                {
                    UrunAdi = txtUrunAdi.Text.ToUpper(),
                    BirimFiyat = Convert.ToDecimal(txtBirimFiyati.Text),
                    StokMiktari = Convert.ToInt32(txtStokMiktari.Text),

                }
                );

            urunDb.SaveChanges();
            UrunDoldur();
            Temizle();
        }


        private void cMs_Sil_Click(object sender, EventArgs e)
        {
            if (lstwUrunListele.SelectedItems.Count <= 0)
                return;

            urunDb.UrunBilgileris.Remove(urunDb.UrunBilgileris.Find((lstwUrunListele.SelectedItems[0].Tag as UrunBilgileri).Id));
            urunDb.SaveChanges();

            UrunDoldur();
        }
        UrunBilgileri guncelle;

        private void cMs_Guncelle_Click(object sender, EventArgs e)
        {
            if (lstwUrunListele.SelectedItems.Count <= 0)
                return;

            guncelle = urunDb.UrunBilgileris.Find((lstwUrunListele.SelectedItems[0].Tag as UrunBilgileri).Id);

            txtUrunAdi.Text = guncelle.UrunAdi;
            txtBirimFiyati.Text = guncelle.BirimFiyat.ToString();
            txtStokMiktari.Text = guncelle.StokMiktari.ToString();

            btnGuncelle.Enabled = true;
            btnUrunEkle.Enabled = false;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            guncelle.UrunAdi = txtUrunAdi.Text;
            guncelle.StokMiktari = Convert.ToInt32(txtStokMiktari.Text);
            guncelle.BirimFiyat = Convert.ToDecimal(txtBirimFiyati.Text);
        

            urunDb.SaveChanges();
            UrunDoldur();
            btnGuncelle.Enabled = false;
            btnUrunEkle.Enabled = true;


        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            UrunAra(txtAra.Text);
        }


    }
}
