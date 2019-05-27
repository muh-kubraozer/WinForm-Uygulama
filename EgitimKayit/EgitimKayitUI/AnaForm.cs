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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void derslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Dersler frm_Dersler = new frm_Dersler();
            frm_Dersler.Show();
        }

        private void öğrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ogrenciler frm_Ogrenciler = new frm_Ogrenciler();
            frm_Ogrenciler.Show();
        }
    }
}
