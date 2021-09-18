using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Lab1_ASPNetConnectedMode.DAL;

namespace Lab1_ASPNetConnectedMode.GUI
{
    public partial class WebFormTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Database Connection Status: " + UtilityDB.ConnectDB().State.ToString());
        }
    }
}