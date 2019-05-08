using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.MODEL;
using DAL.Persistence;

namespace Site.PAGESERVICE
{
    public partial class ConsultaServico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                // page feita para mostrar grid .... 
                ServicosDAL d = new ServicosDAL();

                GridServicos.DataSource = d.ListarServico(); // popula o grid com dados

                GridServicos.DataBind(); // mostra o conteudo do grid

                    
                    }
            catch (Exception ex)
            {

                lblMensagem2.Text = ex.Message;
            }
        }
    }
}