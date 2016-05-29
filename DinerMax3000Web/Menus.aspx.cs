using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Menus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string mpc = "MenusPageCount";

        if (Session[mpc] == null)
        {
            Session[mpc] = 0;
        }

        Session[mpc] = (int)Session[mpc] + 1;
    }

    protected void gvMenu_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            GridView innerGridView = (GridView)e.Row.FindControl("gvMenuItems");
            innerGridView.DataSource = ((DinerMax3000.Business.Menu)e.Row.DataItem).items;
            innerGridView.DataBind();
        }
    }
}