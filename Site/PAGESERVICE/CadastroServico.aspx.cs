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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

       // Metodo que cadastra as OS Ordem de Serviço
        protected void BtnCadastrarServico_Click(object sender, EventArgs e)
        {
            try
            {

                Servicos s = new Servicos();
                s.TipoServico = TxtTipoServico.Text;
                s.DescricaoServico = txtDescricaoServico.Text;
                s.Statuservico = TxtStatusServico.Text;

                ServicosDAL d = new ServicosDAL();

                d.GravarTipoServico(s); // Grava/ Cadastra o tipo de serviço


                lblMensagem2.Text = "Ordem de Serviço Cadastrada com Sucesso!";


                // comando para limpar os campos após preenchidos e cadastrados
                TxtTipoServico.Text = string.Empty;
                txtDescricaoServico.Text = string.Empty;
                TxtStatusServico.Text = string.Empty;


            }

            catch (Exception ex)
            {
                lblMensagem2.Text = ex.Message;
               
            }


        }
    }
}