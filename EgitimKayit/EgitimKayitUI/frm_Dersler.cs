using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EgitimKayitLib;

namespace EgitimKayitUI
{
    public partial class frm_Dersler : Form
    {
        BindingSource bs = new BindingSource();
        public frm_Dersler()
        {
            InitializeComponent();
        }

        private void frm_Dersler_Load(object sender, EventArgs e)
        {
            
            bs.DataSource = Program.isBirimi.Dersler;
            dgvDersler.DataSource = bs;
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            frm_DersEkle frm_DersEkle = new frm_DersEkle();          
            if (frm_DersEkle.ShowDialog()==DialogResult.OK)
            {
                bs.ResetBindings(false);
            }
        }

        private void duzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DersDuzenle frm_DersDuzenle = new frm_DersDuzenle(dgvDersler.SelectedRows[0].Cells["Col_Id"].Value.ToString());
            frm_DersDuzenle.EditItemCompleted += new EventHandler(EditItem);
            frm_DersDuzenle.Show();
        }

        private void EditItem(object sender,EventArgs e)
        {
            bs.ResetBindings(false);
        }
    }
}
