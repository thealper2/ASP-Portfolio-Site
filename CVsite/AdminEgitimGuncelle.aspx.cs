﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEgitimGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        TxtId.Enabled = false;
        TxtId.Text = x.ToString();

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TBLEGITIMTableAdapter dt = new DataSetTableAdapters.TBLEGITIMTableAdapter();
            TxtBaslik.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].BASLIK;
            TxtAltBaslik.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
            TxtAciklama.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
            TxtTarih.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].TARIH;
            TxtGnot.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].GNOT;
        }
    }

    protected void BtnGuncelle_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLEGITIMTableAdapter dt = new DataSetTableAdapters.TBLEGITIMTableAdapter();
        dt.EgitimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtGnot.Text, TxtTarih.Text, Convert.ToInt16(TxtId.Text));
        Response.Redirect("AdminEgitimler.aspx");
    }
}