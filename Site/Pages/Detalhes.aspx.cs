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
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // faz com que o painel de dados na página não apareça!
            pnlDados.Visible = false;

        }


        // botão que pesquisar
        protected void BtnPesquisaCliente(object sender, EventArgs e)
        {
            try
            {
                // obtem pelo código ou id do cliente !

                int codigo = Convert.ToInt32(txtCodigo.Text);

                UsuarioDAL d = new UsuarioDAL();

                Usuario u = d.Pesquisarporcodigo(codigo);

                // se diferente que vazio ou nulo mostra os dados!
                if (u != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = u.Nome;
                    txtEndereco.Text = u.Endereco;
                    txtEmail.Text = u.Email;
                }
                else
                {
                    lblMensagem.Text = "Cliente não encontrado";

                    txtCodigo.Text = string.Empty;
                }
                

            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;

                
            }
            

        }

        // botao que exclui os dados 
        protected void btnExcluirCliente(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);

                Usuario u = new Usuario();

                UsuarioDAL d = new UsuarioDAL();


                d.Excluir(codigo);


                lblMensagem.Text = "Cliente Excluido !";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtEndereco.Text = string.Empty;

            }
            catch (Exception ex )
            {

                lblMensagem.Text = ex.Message;
            }
        }

        // botão atualiza dados do cliente
        protected void AtualizarCliente(object sender, EventArgs e)
        {

            try
            {

                int codigo = Convert.ToInt32(txtCodigo.Text);

                Usuario u = new Usuario();

                u.Codigo = Convert.ToInt32(txtCodigo.Text);
                u.Nome = Convert.ToString(txtNome.Text);
                u.Endereco = Convert.ToString(txtEndereco.Text);
                u.Email = Convert.ToString(txtEmail.Text);

                UsuarioDAL d = new UsuarioDAL();

                d.AtualizarDados(u);

                lblMensagem.Text = "Cliente Atualizado!";
                
                // limpa os campos ou text box
                txtNome.Text     = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text    = string.Empty;

            }
            catch (Exception ex )
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}