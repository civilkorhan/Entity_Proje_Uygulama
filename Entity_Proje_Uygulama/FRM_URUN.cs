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
    public partial class FRM_URUN : Form
    {
        public FRM_URUN()
        {
            InitializeComponent();
        }
        DB_Entity_UrunEntities db=new DB_Entity_UrunEntities();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
          // tüm hepsni baglantili oldugunu kolonları da getirecek
            //dataGridView1.DataSource = db.TBL_URUNLER.ToList();
            dataGridView1.DataSource=(from x in db.TBL_URUNLER
                                      select new
                                      {
                                          x.URUN_ID,
                                          x.URUN_AD,
                                          x.URUN_MARKA,
                                          x.URUN_FIYAT,
                                          x.TBL_KATEGORILER.KATEGORI_AD // baglı oldugundan getirdik
                                      }
                                      ).ToList();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            TBL_URUNLER u=new TBL_URUNLER();
            u.URUN_AD=txtbox_ad.Text;
            u.URUN_MARKA=txtbox_marka.Text;
            u.URUN_DURUM = true;
            u.URUN_FIYAT=decimal.Parse(txtbox_fiyat.Text);
            u.URUN_STOK=short.Parse(txtbox_stok.Text);
            u.URUN_KATEGORİ = int.Parse(cmbobox_ktgri.SelectedValue.ToString());
            db.TBL_URUNLER.Add(u);
            db.SaveChanges();
            MessageBox.Show("Ürün Eklendi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int x= Convert.ToInt32(txtbox_id.Text);
            var bul=db.TBL_URUNLER.Find(x);
            db.TBL_URUNLER.Remove(bul);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_gnclle_Click(object sender, EventArgs e)
        {
            int x= Convert.ToInt32(txtbox_id.Text);
            var bul = db.TBL_URUNLER.Find(x);
            bul.URUN_AD=txtbox_ad.Text;
            bul.URUN_FIYAT = Decimal.Parse(txtbox_fiyat.Text);
            bul.URUN_MARKA = txtbox_marka.Text;
            bul.URUN_STOK=short.Parse(txtbox_stok.Text);
            bul.URUN_KATEGORİ = int.Parse(cmbobox_ktgri.SelectedValue.ToString());
            db.SaveChanges() ;
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void FRM_URUN_Load(object sender, EventArgs e)
        {
            var gtr = (from x in db.TBL_KATEGORILER
                       select new
                       {
                           x.KATEGORI_ID,
                           x.KATEGORI_AD
                       }
                     ) .ToList();
            cmbobox_ktgri.ValueMember = "KATEGORI_ID";
            cmbobox_ktgri.DisplayMember= "KATEGORI_AD";
            cmbobox_ktgri.DataSource = gtr;

                          
        }
    }

}
