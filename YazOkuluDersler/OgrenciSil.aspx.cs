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
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"]);//Diğer Formdan Taşınan ID'yi x'e atadık !
            Response.Write(x);
            EntityOgrenci ent = new EntityOgrenci();
            ent.OGRID = x;//Değerimizi x'e Taşımıstık Unutmayalım !!!
            BLLOgrenci.OgrenciSilBLL(ent.OGRID);
            Response.Redirect("OgrenciListesi.Aspx");//Yönlendirmek İstediğimiz Sayfalara Bu Komutla Gideriz !
        }
    }
}