using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccesLayer;
using EntityLayer;

namespace YazOkuluDersler
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)//Dersleri DerslerSayfasında ki Textbox içine aktardık !
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDers> EntDers = BLLDers.BllListele();
                DropDownList1.DataSource = BLLDers.BllListele();
                DropDownList1.DataTextField = "DersAd";//Veritabanında Gözükecek Alan
                DropDownList1.DataValueField = "DersID";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)//DERS TALEPLERİNİ VT'ye EKLEDİK !!!
        {
            //TextBox1.Text = DropDownList1.SelectedValue.ToString();//Talep Oluştur Butonuna Basınca Ders ID'si ID Bölümüne Gelir !
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.BASOGRID = int.Parse(TextBox1.Text);
            ent.BASDERSID = int.Parse(DropDownList1.SelectedValue.ToString());
            BLLDers.TalepEkle(ent);
        }
    }
}