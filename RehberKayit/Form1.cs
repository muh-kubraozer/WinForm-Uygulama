using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehberDuzenlenmis
{
    public enum Durumlar
    {
        Ekle,
        Guncelle
    }
    public partial class frmKisiEkleGuncelle : Form
    {
        private List<Kisi> kisiler;
        public frmKisiEkleGuncelle()
        {
            InitializeComponent();
            kisiler = new List<Kisi>();
        }

        private void KontrolleriDurumaSetEt(Durumlar durum)
        {
            switch (durum)
            {
                case Durumlar.Ekle:
                    grbEkle.Enabled = true;
                    grbGuncelle.Enabled = false;
                    break;
                case Durumlar.Guncelle:
                    grbEkle.Enabled = false;
                    grbGuncelle.Enabled = true;
                    break;
            }
        }


        public void btnCancel_Click(object sender, EventArgs e)
        {
            ControlTemizle(grbEkle.Controls);
           // ControlTemizle(this.Controls); form üzerindeki tüm textboxları temizler
        }

        private void ControlTemizle(System.Windows.Forms.Control.ControlCollection collection)
        {
            foreach (var kontrol in collection)
            {
                if(kontrol is TextBoxBase)
                    (kontrol as TextBoxBase).Clear();
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            KontrolleriDurumaSetEt(Durumlar.Ekle);
            ControlTemizle(grbGuncelle.Controls);
            txtAdGuncelle.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           Kisi YeniKisi= new Kisi(txtAd.Text,txtSoyad.Text,txtTelefon.Text,rchAdres.Text); 
           kisiler.Add(YeniKisi);
           listGoruntule.Items.Add(KisiyiLstviewItemaCevir(YeniKisi)); // burda da kendi ListView elemanımıza eklenmiş oluyor.
           ControlTemizle(grbEkle.Controls);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var seciliTelefon = listGoruntule.SelectedItems[0].SubItems[1].Text;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Telefon == seciliTelefon)
                {
                    kisiler[i].Ad = txtAdGuncelle.Text;
                    kisiler[i].Soyad = txtSoyadGuncelle.Text;
                    kisiler[i].Telefon = txtTelefonGuncelle.Text;
                    kisiler[i].Adres = rchAdresGuncelle.Text;

                    var secili = listGoruntule.SelectedItems[0];
                    secili.SubItems[0].Text = kisiler[i].AdSoyad;
                    secili.SubItems[1].Text = kisiler[i].Telefon;
                    break;
                }
            }

            KontrolleriDurumaSetEt(Durumlar.Ekle);
            ControlTemizle(grbGuncelle.Controls);
        }
        private void listGoruntule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGoruntule.SelectedItems.Count<=0)
            {
                return; // eğer hiç seçili Item yok ise Metodu bitir. Aşağıya hiç uğramaz. 
            }
            KontrolleriDurumaSetEt(Durumlar.Guncelle);

            var seciliTelefon = listGoruntule.SelectedItems[0].SubItems[1].Text;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Telefon == seciliTelefon)
                {
                    txtAdGuncelle.Text = kisiler[i].Ad;
                    txtSoyadGuncelle.Text = kisiler[i].Soyad;
                    txtTelefonGuncelle.Text = kisiler[i].Telefon;
                    rchAdresGuncelle.Text = kisiler[i].Adres;
                    break;
                }
            }

            //txtAdGuncelle.Text = listGoruntule.SelectedItems[0].Text.Split(' ')[0];
        }
        private void frmKisiEkleGuncelle_Load(object sender, EventArgs e)
        {
            KontrolleriDurumaSetEt(Durumlar.Ekle);
        }
        private ListViewItem KisiyiLstviewItemaCevir(Kisi kisi)
        {
            // ListView için bir satır oluşturduk
            ListViewItem kisiItem = new ListViewItem();
            kisiItem.SubItems[0].Text = kisi.AdSoyad; // İlk sutuna bir değer ataması yapmak

            ListViewItem.ListViewSubItem sub = new ListViewItem.ListViewSubItem(); // ikinci bir sutun oluşturduk
            sub.Text = kisi.Telefon;
            kisiItem.SubItems.Add(sub);  //kisiItem.SubItems.Add(YeniKisi.Telefon); // buraya ekleyerek 
            return kisiItem;
        }
    }
}
