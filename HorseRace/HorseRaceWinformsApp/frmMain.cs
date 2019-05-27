using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HorseRaceDomain;


namespace HorseRaceWinformsApp
{
    public partial class frmMain : Form
    {
        RaceTournamentEvent tEvent = new RaceTournamentEvent(Environment.CurrentDirectory);
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
            tEvent.Initialize();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            timerRace.Enabled = true;
        }

        private void timerRace_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            pictureBox1.Location = new Point(pictureBox1.Location.X + rnd.Next(0, 5), pictureBox1.Location.Y);
            pictureBox2.Location = new Point(pictureBox2.Location.X + rnd.Next(0, 5), pictureBox2.Location.Y);
        }
    }
}
