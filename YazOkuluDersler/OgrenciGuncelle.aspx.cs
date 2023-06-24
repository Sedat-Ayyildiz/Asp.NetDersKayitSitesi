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
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)//OgrVerileri Güncelle Sayfasına Taşıdık.
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());//OgrID'yi OgrGuncellede kullandık yani ID'ye Göre Güncelledik.
            TxtID.Text = x.ToString();//OGRID'yi Güncelle Sayfasında ki TextBox içine taşıdık !
            TxtID.Enabled = false;//ID'yi kitledik kullanıcı müdahale edip değiştiremesin diye !!!

            if (Page.IsPostBack == false)//Güncelle Sayfasında İlk Gelen Verileri Tutsun ki Güncelleyince VT'ye gitsin diye kullanırız !
            {
                List<EntityOgrenci> OgrList = BLLOgrenci.BllDetay(x);
                TxtAd.Text = OgrList[0].AD.ToString();//Hafızaya alınan 0. değere OgrAd'ı yazdır demek !
                TxtSoyad.Text = OgrList[0].SOYAD.ToString();
                TxtNumara.Text = OgrList[0].NUMARA.ToString();
                TxtFoto.Text = OgrList[0].FOTOGRAF.ToString();
                TxtSifre.Text = OgrList[0].SİFRE.ToString();
            }            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.AD = TxtAd.Text;
            ent.SOYAD = TxtSoyad.Text;
            ent.SİFRE = TxtSifre.Text;
            ent.NUMARA = TxtNumara.Text;
            ent.FOTOGRAF = TxtFoto.Text;
            ent.OGRID = Convert.ToInt32(TxtID.Text);
            BLLOgrenci.OgrenciGuncelleBLL(ent);
            Response.Redirect("OgrenciListesi.Aspx");
        }
    }
}