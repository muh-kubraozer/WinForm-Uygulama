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
    public partial class frm_OgrenciDuzenle : Form
    {
        public event EventHandler EditItemCompleted;
        private string ogrenciId;
        public frm_OgrenciDuzenle(string ogrenciId)
        {
            InitializeComponent();
            this.ogrenciId = ogrenciId;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ogrenciBindingSource.EndEdit();
            if (this.EditItemCompleted != null)
                EditItemCompleted(this, null);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frm_OgrenciDuzenle_Load(object sender, EventArgs e)
        {
            ogrenciBindingSource.DataSource = Program.isBirimi.Ogrenciler.SingleOrDefault(x => x.Id == ogrenciId);
        }

        private void frm_OgrenciDuzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
                ogrenciBindingSource.ResetItem(0);
        }
    }
}
