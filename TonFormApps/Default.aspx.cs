using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TonFormApps
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check whether the browser remains
            // connected to the server.
            if (Response.IsClientConnected)
            {
                // If still connected, redirect
                // to another page. 
                Response.Redirect("https://www.newmarket.ca", false);
            }
            else
            {
                // If the browser is not connected
                // stop all response processing.
                Response.End();
            }
        }



    }
}