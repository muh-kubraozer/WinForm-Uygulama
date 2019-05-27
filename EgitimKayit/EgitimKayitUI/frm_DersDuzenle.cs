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
    public partial class frm_DersDuzenle : Form
    {
        public event EventHandler EditItemCompleted;
        private string _dersId;
        public frm_DersDuzenle(string dersId)
        {
            InitializeComponent();
            _dersId = dersId;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Program.isBirimi.DersDuzenle(_dersId, txtDersAdi.Text);
            if (EditItemCompleted!=null)
            {
                EditItemCompleted(this, null);
            }
            this.Close();
        }

        private void frm_DersDuzenle_Load(object sender, EventArgs e)
        {
           var duzenlenecekDers=Program.isBirimi.Dersler.SingleOrDefault(x => x.Id == _dersId);
           txtDersAdi.Text = duzenlenecekDers.DersAdi;
        }
    }
}
