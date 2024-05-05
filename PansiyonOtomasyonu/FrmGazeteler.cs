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
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void btnHürriyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hurriyet.com.tr/");
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
        }

        private void btnSözcü_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sozcu.com.tr/");
        }

        private void btnHbrTrk_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.haberturk.com/");
        }

        private void btnFanatik_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fanatik.com.tr/");

        }

        private void btnOnedio_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://onedio.com/");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

       
    }
}
