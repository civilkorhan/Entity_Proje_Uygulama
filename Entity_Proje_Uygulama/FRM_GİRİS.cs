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
    public partial class FRM_GİRİS : Form
    {
        public FRM_GİRİS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Entity_UrunEntities db = new DB_Entity_UrunEntities();
            var sorgu = from x in db.TBL_ADMIN
                        where x.KULLANICI == textBox1.Text && x.SIFRE == textBox2.Text
                        select x;
            if (sorgu.Any()) // eger bir şey döndüyorsa demek istedik
            {
                FRM_ANA_FORM fr=new FRM_ANA_FORM();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
