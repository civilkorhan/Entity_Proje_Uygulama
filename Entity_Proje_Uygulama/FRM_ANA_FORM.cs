using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Proje_Uygulama
{
    public partial class FRM_ANA_FORM : Form
    {
        public FRM_ANA_FORM()
        {
            InitializeComponent();
        }

        private void FRM_ANA_FORM_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_URUN fr=new FRM_URUN();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr =new Form1();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ISTATISTIK fr=new FRM_ISTATISTIK();
            fr.Show();
        }
    }
}
