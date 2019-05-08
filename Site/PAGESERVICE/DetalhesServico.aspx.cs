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
    public partial class DetalhesServico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnldadosTipoServico.Visible = false;

        }

        protected void BtnPesquisarOS(object sender, EventArgs e)
        {

            try
            {   
                int codigo = Convert.ToInt32(TxtCodigoOS.Text);

              
                ServicosDAL d = new ServicosDAL();

                Servicos s = d.PesquisarServicoporCodigo(codigo);

           
                if (s != null)
                {
                    pnldadosTipoServico.Visible = true; // painel de dados 
                    TxtTipoServico.Text = s.TipoServico;
                    TxtdescricaoServico.Text = s.DescricaoServico;
                    txtStatusServico.Text = s.Statuservico;
                }
                else
                {
                    lblMensagem2.Text = "Ordem de Serviço não encontrada!";
                    TxtCodigoOS.Text = string.Empty;

                }
            }
            catch (Exception ex)
            {

                lblMensagem2.Text = ex.Message;
            }
        }


        protected void btnExcluirServico_Click(object sender, EventArgs e)
        {
            try
            {

                int codigoservico = Convert.ToInt32(TxtCodigoOS);

                Servicos s = new Servicos();

                ServicosDAL d = new ServicosDAL();

                d.ExcluirServico(codigoservico);

                lblMensagem2.Text = "Ordem de Serviço Excluida com Sucesso";

                TxtCodigoOS.Text = string.Empty;
                TxtdescricaoServico.Text = string.Empty;
                txtStatusServico.Text = string.Empty;

            }
            catch (Exception ex)
            {

                lblMensagem2.Text = ex.Message;
            }
        }

        protected void btnAtualizarServico_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoservico = Convert.ToInt32(TxtCodigoOS.Text);

                Servicos s = new Servicos();

                s.codigoservico = Convert.ToInt32(TxtCodigoOS.Text);
                s.TipoServico = Convert.ToString(TxtTipoServico.Text);
                s.DescricaoServico = Convert.ToString(TxtdescricaoServico.Text);
                s.Statuservico = Convert.ToString(txtStatusServico.Text);

                ServicosDAL d = new ServicosDAL();

                d.AtualizarServico(s);

                lblMensagem2.Text = "Ordem de Serviço Atualizada com Sucesso!";

                // limpar os campos apos serem preenchidos e acionado o botão

                TxtCodigoOS.Text = string.Empty;
                TxtTipoServico.Text = string.Empty;
                TxtdescricaoServico.Text = string.Empty;
                txtStatusServico.Text = string.Empty;


            }
            catch (Exception ex )
            {

                lblMensagem2.Text = ex.Message;
            }
        }
    }
}