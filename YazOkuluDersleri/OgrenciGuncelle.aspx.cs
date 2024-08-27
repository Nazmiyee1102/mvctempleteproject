using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DAL;
using BusinessLogicLayer;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["Ogrid"].ToString());
        txt_id.Text = x.ToString();
        txt_id.Enabled = false;

        if (Page.IsPostBack == false)
        {
            List<EntityOgrenci> OgrList = BLLOgrenci.BllDetay(x);
            txt_ad.Text = OgrList[0].AD.ToString();
            txt_soyad.Text = OgrList[0].SOYAD.ToString();
            txt_numara.Text = OgrList[0].NUMARA.ToString();
            txt_foto.Text = OgrList[0].FOTOGRAF.ToString();
            txt_sifre.Text = OgrList[0].SIFRE.ToString();
        }




    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        EntityOgrenci entityOgrenci = new EntityOgrenci();
        entityOgrenci.AD = txt_ad.Text;
        entityOgrenci.SOYAD = txt_soyad.Text;
        entityOgrenci.SIFRE = txt_sifre.Text;
        entityOgrenci.NUMARA = txt_numara.Text;
        entityOgrenci.FOTOGRAF = txt_foto.Text;
        entityOgrenci.ID = Convert.ToInt32(txt_id.Text);
        BLLOgrenci.OgrencilGuncelleBl(entityOgrenci);
        Response.Redirect("OgrenciListesi.aspx");


    }
}