using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DinerMax3000MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string tpc = "TotalPageCount";

        if (Application[tpc] == null)
        {
            Application[tpc] = 0;
        }

        Application[tpc] = (int)Application[tpc] + 1;
    }
}
