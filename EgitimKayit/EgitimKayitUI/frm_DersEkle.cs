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
    public partial class frm_DersEkle : Form
    {
        public frm_DersEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Program.isBirimi.DersEkle(txtDersAdi.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}
