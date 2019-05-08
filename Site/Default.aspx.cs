using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        // Botão do Menu Clientes
        protected void btnMenu_Click(object sender, EventArgs e)
        {
            string opcao = ddlMenu.SelectedValue;

            switch(opcao)
            {
                case "0":
                    lblMensagem.Text = "Selecione uma Opção";
                    break;

                case "1":
                    Response.Redirect ("/Pages/Cadastro.aspx");
                    break;

                case "2":
                    Response.Redirect("/Pages/Consulta.aspx");
                    break;

                case "3":
                    Response.Redirect("/Pages/Detalhes.aspx");
                    break;          
                        }

        }


        // Botão do Menu Serviços
        protected void btnMenu2_Click(object sender, EventArgs e)
        {
            string opcao = ddlMenu2.SelectedValue;

            switch(opcao)
            {
                case "0":
                    lblMensagem2.Text = "Escolha uma Opção que seja Valida !";
                    break;

                case "1":
                    Response.Redirect("/PAGESERVICE/CadastroServico.aspx");
                    break;

                case "2":
                    Response.Redirect("/PAGESERVICE/ConsultaServico.aspx");
                    break;

                case "3":
                    Response.Redirect("/PAGESERVICE/DetalhesServico.aspx");
                    break;
            }
        }
    }
}