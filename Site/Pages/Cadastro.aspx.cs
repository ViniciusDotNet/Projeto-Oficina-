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
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void BtnCadastrarCliente(object sender, EventArgs e)
        {
            // metodo do botão para gravar os dados do cliente 
            try
            {

                Usuario u = new Usuario();

                u.Nome = TxtNome.Text;
                u.Endereco = TxtEndereco.Text;
                u.Email = TxtEmail.Text;

                UsuarioDAL d = new UsuarioDAL();

                d.Gravar(u);// grava os dados do cliente

                lblMensagem.Text = "Cliente" +u.Nome  + "Cadastrado com Sucesso!";
                // este comando serve para após que o cliente for cadastrado os campos se limpem!
                TxtNome.Text = string.Empty;
                TxtEndereco.Text = string.Empty;
                TxtEmail.Text = string.Empty;          
            }
            catch (Exception ex )
            {

                lblMensagem.Text = ex.Message;
            }

        }
    }
}