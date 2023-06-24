using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccesLayer;
using BusinessLogicLayer;

namespace YazOkuluDersler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {//BusinessLogicLayer(BLLOgrenci)'da ki Şarta göre bir veri NULL olursa Öğrenci ekleme yapmaz !
            EntityOgrenci ent = new EntityOgrenci();//Butona basınca yazılan verileri oluşturduğumuz textboxlara bağladık ve veri ekledik.
            ent.AD = TxtAd.Text;
            ent.SOYAD = TxtSoyad.Text;
            ent.NUMARA = TxtNumara.Text;
            ent.SİFRE = TxtSifre.Text;
            ent.FOTOGRAF = TxtFoto.Text;
            BLLOgrenci.OgrenciEkleBLL(ent);
        }
    }
}