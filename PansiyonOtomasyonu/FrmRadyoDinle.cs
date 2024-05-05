using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonOtomasyonu
{
    public partial class FrmRadyoDinle : Form
    {
        public FrmRadyoDinle()
        {
            InitializeComponent();
        }

        private void btnKanal1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/166/";//90 lar radyo
        }

        private void btnKanal2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.201:80/";//kral pop
        }

        private void btnKanal3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.7.125/listen.pls";//bestfm 
        }

        private void btnKanal4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.100.104/stream/552/";//Alem fm
        }

        private void btnKanal5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radyo.duhnet.tv/slowturk";//Slow türk
        }

        private void btnKanal6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://95.211.162.32:8000/";//Taksim Fm
            
        }

        private void FrmRadyoDinle_Load(object sender, EventArgs e)
        {

        }
    }//growandshrik bak 
}