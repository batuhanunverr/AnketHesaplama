using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elkon_Anket_Sonuc_Hesaplama
{
    public partial class Form1 : Form
    {
        Timer timer1 = new Timer();
        public Form1()
        {
            InitializeComponent();
            standartsapmalistbox.HorizontalScrollbar = true;
            ortalamalistbox.HorizontalScrollbar = true;
            medyanlistbox.HorizontalScrollbar = true;


        }

        private void bdtpazarlamabutton_Click(object sender, EventArgs e)
        {
            bdtpazarlamapage form2sec = new bdtpazarlamapage();
                     form2sec.Show();
              

        }

        private void muhasebebutton_Click(object sender, EventArgs e)
        {
            muhasebepage form1sec = new muhasebepage();
            form1sec.Show();
        }

        private void tedarikzinciributton_Click(object sender, EventArgs e)
        {
            InovasyonTedarik form1sec = new InovasyonTedarik();
            form1sec.Show();
        }

        private void emeapazarlamabutton_Click(object sender, EventArgs e)
        {
            Emea form1sec = new Emea();
            form1sec.Show();

        }

        private void yonetimbutton_Click(object sender, EventArgs e)
        {
            yonetimidari form1sec = new yonetimidari();
            form1sec.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer2.Enabled = true;
            label555.Text = "Kolay gelsin Annee Seni seviyorum :)) ";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label555.Text = label555.Text.Substring(1) + label555.Text.Substring(0, 1);
        }

        private void inovasyonprojebutton_Click(object sender, EventArgs e)
        {
            inovasyonproje form1sec = new inovasyonproje();
            form1sec.Show();

        }

        private void inovasyonbilgiislembutton_Click(object sender, EventArgs e)
        {

            İnovasyonbilgiislem form1sec = new İnovasyonbilgiislem();
            form1sec.Show();
        }

        private void disticaretbutton_Click(object sender, EventArgs e)
        {

            disticaret form1sec = new disticaret();
            form1sec.Show();
        }
    }
}
