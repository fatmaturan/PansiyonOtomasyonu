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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiriş fr = new FrmAdminGiriş();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMüsteriEkle fr = new FrmMüsteriEkle();
            fr.Show();

        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

            private void button4_Click(object sender, EventArgs e)
        {
            FrmMüşteriler fr = new FrmMüşteriler();
            fr.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sunfaduta Pansiyon Uygulaması/2024/İZMİR ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odalar FR = new Odalar();
            FR.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGelirFider fr = new FrmGelirFider();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmStoklar ft = new FrmStoklar();
            ft.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle rd = new FrmRadyoDinle();
            rd.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmGazeteler fr = new FrmGazeteler();
            fr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmHavaDurumu fr = new FrmHavaDurumu();
            fr.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            FrmYorumlar fr = new FrmYorumlar();
            fr.Show();
        }

        

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sistemden çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                Application.Exit(); // Uygulamadan çık 
            }
        }

    }

}

//maximinize minimize false olması formun kullanıcı tarafından büyütülüp küçültülemsini engellemek demek 
