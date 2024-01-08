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
    public partial class FRM_ISTATISTIK : Form
    {
        public FRM_ISTATISTIK()
        {
            InitializeComponent();
        }
        DB_Entity_UrunEntities db=new DB_Entity_UrunEntities(); // heryerden erişebilmek için buraya
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = db.TBL_KATEGORILER.Count().ToString();
        }

        private void FRM_ISTATISTIK_Load(object sender, EventArgs e)
        {
            label1.Text = db.TBL_KATEGORILER.Count().ToString();
            label2.Text = db.TBL_KATEGORILER.Count().ToString();
            label3.Text=db.TBL_MUSTERILER.Count(x=> x.DURUM==true).ToString();
            label4.Text = db.TBL_MUSTERILER.Count(x => x.DURUM == false).ToString();
            label7.Text=db.TBL_URUNLER.Sum(y=> y.URUN_STOK).ToString();
            label11.Text = db.TBL_SATIS.Sum(z => z.FIYAT).ToString() + "TL";
            label6.Text=(from g in db.TBL_URUNLER orderby g.URUN_FIYAT descending select g.URUN_AD).FirstOrDefault();
            label5.Text=( from x in db.TBL_URUNLER orderby x.URUN_FIYAT ascending select x.URUN_AD).FirstOrDefault();   
            label8.Text= db.TBL_URUNLER.Count(x=> x.URUN_KATEGORİ==1).ToString(); 
            // istenilen ürünün istenilen özelliğini getirmiş olduk label 8 için 
            label9.Text=db.TBL_URUNLER.Count(x=> x.URUN_AD=="BUZDOLABI").ToString();
            label12.Text=(from x in db.TBL_MUSTERILER select x.MUSTERI_SEHIR).Distinct().Count().ToString();
            label10.Text = db.MARKA_GETIR().FirstOrDefault();

        }
    }
}
