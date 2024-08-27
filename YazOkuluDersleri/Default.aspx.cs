using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DAL;
using BusinessLogicLayer;



public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci entityOgrenci = new EntityOgrenci();
        entityOgrenci.AD = txt_ad.Text;
        entityOgrenci.SOYAD = txt_soyad.Text;
        entityOgrenci.NUMARA = txt_numara.Text;
        entityOgrenci.SIFRE = txt_sifre.Text;
        entityOgrenci.FOTOGRAF = txt_foto.Text;
        BLLOgrenci.OgrenciEkleBLL(entityOgrenci);
    }
}