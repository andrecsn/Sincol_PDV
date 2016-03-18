using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto.Cadastros.HelpDinamico
{
    public partial class HelpDinamico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHelp.Text=  Request.QueryString["Hlp"].ToString();
        }
    }
}