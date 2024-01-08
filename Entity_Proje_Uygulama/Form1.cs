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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DB_Entity_UrunEntities db=new DB_Entity_UrunEntities();
        private void button2_Click(object sender, EventArgs e)
        {
            var kategoriler =db.TBL_KATEGORILER.ToList();
            dataGridView1.DataSource = kategoriler; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBL_KATEGORILER k=new TBL_KATEGORILER();
            k.KATEGORI_AD = txtbox_ad.Text;
            db.TBL_KATEGORILER.Add(k); // k dan geleni ekle dedik
            db.SaveChanges();
            MessageBox.Show("Kategoriye Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            int x=Convert.ToInt16(txtbox_id.Text);
            var find=db.TBL_KATEGORILER.Find(x);
            db.TBL_KATEGORILER.Remove(find);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_updt_Click(object sender, EventArgs e)
        {
            int x= Convert.ToInt32(txtbox_id.Text);
            var bulunan = db.TBL_KATEGORILER.Find(x);
            bulunan.KATEGORI_AD=txtbox_ad.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
