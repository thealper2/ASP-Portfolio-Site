using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLHAKKIMDATableAdapter dt = new DataSetTableAdapters.TBLHAKKIMDATableAdapter();
        Repeater1.DataSource = dt.HakkımdaListele();
        Repeater1.DataBind();

        DataSetTableAdapters.TBLDENEYIMIMTableAdapter dt2 = new DataSetTableAdapters.TBLDENEYIMIMTableAdapter();
        Repeater2.DataSource = dt2.DeneyimListesi();
        Repeater2.DataBind();

        DataSetTableAdapters.TBLEGITIMTableAdapter dt3 = new DataSetTableAdapters.TBLEGITIMTableAdapter();
        Repeater3.DataSource = dt3.EgitimListele();
        Repeater3.DataBind();

        DataSetTableAdapters.TBLHOBILERTableAdapter dt4 = new DataSetTableAdapters.TBLHOBILERTableAdapter();
        Repeater4.DataSource = dt4.HobilerListele();
        Repeater4.DataBind();

        DataSetTableAdapters.TBLODULLERTableAdapter dt5 = new DataSetTableAdapters.TBLODULLERTableAdapter();
        Repeater5.DataSource = dt5.OdullerListele();
        Repeater5.DataBind();

        DataSetTableAdapters.TBLYETENEKLERTableAdapter dt6 = new DataSetTableAdapters.TBLYETENEKLERTableAdapter();
        Repeater6.DataSource = dt6.YeteneklerListele();
        Repeater6.DataBind();
    }
}