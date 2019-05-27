using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace EsiniBul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Color originalColor = Color.AliceBlue;
        private Dictionary<int,AtanacakRenk> renkListesi;
        private Button acikButton;
        private int _boyut=0;
        private int score = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void RastgeleRenkAtama()
        {
            Random rnd = new Random();
            for (int i = 1; i < Math.Pow(_boyut,2)+1; i++)
            {
                var renkIndisi = rnd.Next(0, renkListesi.Count);
                var renkAnahtari = renkListesi.Keys.ElementAt(renkIndisi);
                groupBox1.Controls[$"btn{i}"].BackColor = renkListesi[renkAnahtari].Renk;
                groupBox1.Controls[$"btn{i}"].Tag = renkListesi[renkAnahtari].Renk;
                renkListesi[renkAnahtari].AtanmaSayisi++;
                if (renkListesi[renkAnahtari].AtanmaSayisi == 2)
                    renkListesi.Remove(renkAnahtari);
            }

            tmrHepsiniGoster.Interval = 3000;
            tmrHepsiniGoster.Tick += (sender, args) =>
            {
                tmrHepsiniGoster.Stop();
                foreach (Control item in groupBox1.Controls)
                {
                    item.BackColor = originalColor;
                }
            };
            tmrHepsiniGoster.Start();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            var btn = (sender as Button);
            btn.BackColor = btn.BackColor == originalColor ? (Color)btn.Tag : originalColor;
            if (acikButton == null)
                acikButton = btn;
            else
            {
                tmrButtonAcma.Tag = btn;
                tmrButtonAcma.Start();
            }
        }
        private void tmrButtonAcma_Tick(object sender, EventArgs e)
        {
            var ikinciButton = ((sender as Timer).Tag as Button);
            if (acikButton.BackColor == ikinciButton.BackColor)
            {
                acikButton.Visible = false;
                ikinciButton.Visible = false;
                score++;
            }
            else
            {
                acikButton.BackColor = originalColor;
                ikinciButton.BackColor = originalColor;
            }
            tmrButtonAcma.Stop();
            acikButton = null;
            label1.Text = $"Puan : {score}";
            if (OyunBittiMi())
            {
                var result = MessageBox.Show($"Oyun bitti. Skor = {score} yeniden oynayalım mı?", "Oyun Sonu",
                    MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                    RestartGame();
                else if(result == DialogResult.No)
                    Environment.Exit(1);
            }
        }

        private bool OyunBittiMi()
        {
            foreach (var btn in groupBox1.Controls)
            {
                if ((btn as Button).Visible == true)
                    return false;
            }

            return true;
        }
        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var strip = (ToolStripMenuItem) sender;
            _boyut = Convert.ToInt32(strip.Tag);

            RestartGame(_boyut);
        }

        private void OyunBaslat(int boyut)
        {
            Random rnd = new Random();
            renkListesi = new Dictionary<int, AtanacakRenk>();

            for (int i = 0; i < boyut*boyut/2; i++)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                renkListesi.Add(i, new AtanacakRenk() { Renk = randomColor, AtanmaSayisi = 0 });
            }

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(70, 70);
                    btn.Text = string.Empty;
                    btn.Location = new Point(40 + (73 * j), 60 + (73 * i));
                    btn.Click += new EventHandler(btn_Click);
                    btn.Name = $"btn{(i * boyut + j + 1)}";
                    //btn.BackColor = originalColor;
                    //string.Format("btn{0}", (i + 1) * (j + 1));
                    groupBox1.Controls.Add(btn);
                }
            }
            var width = groupBox1.Controls[groupBox1.Controls.Count-1].Location.X + 100;
            var height = groupBox1.Controls[groupBox1.Controls.Count-1].Location.Y + 150;
            this.Size = new Size(width,height);
            RastgeleRenkAtama();
        }

        private void RestartGame(int boyut = 0)
        {
            boyut = boyut == 0 ? _boyut : boyut;
            ClearGame();
            OyunBaslat(boyut);
        }

        private void ClearGame()
        {
            renkListesi=null;
            acikButton = null;
            groupBox1.Controls.Clear();
            score = 0;
        }
    }
}
