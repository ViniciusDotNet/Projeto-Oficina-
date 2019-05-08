using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.MODEL;
using DAL.Persistence;
namespace Site.Pages
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                UsuarioDAL d = new UsuarioDAL();
                GridClientes.DataSource = d.Listar();// popular o grid com dados 

                GridClientes.DataBind();// mostra o conteudo do  grid

            }
            catch (Exception ex )
            {

                lblMensagem.Text = ex.Message;
            }


        }
    }
}