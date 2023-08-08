﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDeneyimGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        TxtId.Enabled = false;
        TxtId.Text = x.ToString();

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TBLDENEYIMIMTableAdapter dt = new DataSetTableAdapters.TBLDENEYIMIMTableAdapter();
            TxtBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].BASLIK;
            TxtAltBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
            TxtAciklama.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
            TxtTarih.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].TARIH;
        }
    }

    protected void BtnGuncelle_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLDENEYIMIMTableAdapter dt = new DataSetTableAdapters.TBLDENEYIMIMTableAdapter();
        dt.DeneyimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtTarih.Text, Convert.ToInt16(TxtId.Text));
        Response.Redirect("AdminDeneyimler.aspx");
    }
}