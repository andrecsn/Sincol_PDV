using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto.Ferramentas
{
    public class Uteis
    {

        public void ExecutaJS(Page pg, string comando)
        {
            
            pg.RegisterStartupScript("Fechar", comando);
        }

       


        public void LimpaCampos(Control form1)
        {

            foreach (Control c in form1.Controls)
            {

                if (c is DropDownList)
                {
                    ((DropDownList)c).SelectedIndex = -1;
                }

                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }

                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
        }

    }
}