using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimKayitUI
{
    public partial class frm_Ogrenciler : Form
    {
        BindingSource bs = new BindingSource();
        public frm_Ogrenciler()
        {
            InitializeComponent();
        }

        private void frm_Ogrenciler_Load(object sender, EventArgs e)
        {
             bs.DataSource=Program.isBirimi.Ogrenciler;
             dgvOgrenciler.DataSource = bs;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            frm_OgrenciEkle frm_OgrenciEkle = new frm_OgrenciEkle();
            if (frm_OgrenciEkle.ShowDialog()==DialogResult.OK)
            {
                bs.ResetBindings(false);
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_OgrenciDuzenle frm_OgrenciDuzenle = new frm_OgrenciDuzenle(dgvOgrenciler.SelectedRows[0].Cells["Id"].Value.ToString());
            frm_OgrenciDuzenle.EditItemCompleted += Frm_OgrenciDuzenle_EditItemCompleted;
            frm_OgrenciDuzenle.Show();
        }

        private void Frm_OgrenciDuzenle_EditItemCompleted(object sender, EventArgs e)
        {
            bs.ResetBindings(false);
        }
    }
}
