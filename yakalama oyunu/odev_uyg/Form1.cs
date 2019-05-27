using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace odev_uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int skor = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(70, 70);
                    btn.Location = new Point(40 + (73 * j), 60 + (73 * i));
                    btn.Tag = 4 * i + j;
                    btn.BackColor = Color.White;
                    btn.Name = $"btn{i}";
                    groupBox1.Controls.Add(btn);
                    btn.Click += new EventHandler(btn_Click);
                }
               
            }
            timer1.Start();
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
           
            if(btn.Text=="X")
            {
                btn.Text = "O";
                skor++;
            }
            else
            {
                skor--;
            }
            lbl_score.Text = skor.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int deger = rnd.Next(0, 16);

            foreach (Control btn in groupBox1.Controls)
            {
                if (btn is Button)
                {
                    if (Convert.ToInt32(btn.Tag) == deger)
                    {
                        btn.Text = "X";
                    }
                    else
                    {
                        btn.Text = "";
                    }
                }

            }
        }
    }
}