using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace figura20_20_6439059
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Forzamos la categoría 1 para probar que hay datos
            Session["intCategoryID"] = 1;
        }
    }
}