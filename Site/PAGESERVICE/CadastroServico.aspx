<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroServico.aspx.cs" Inherits="Site.PAGESERVICE.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title> Cadastro Serviços</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />

</head>

<script src="Scripts/jquery-1.9.1.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>

<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset-1">
                <div class="row">

                      <h3 class="well"> Cadastro de Serviços  </h3>
                                        
                    <br />


   Tipo de Serviço: <br/>
    <asp:TextBox ID="TxtTipoServico" runat="server" placeholder="Insira o tipo Serviço a ser Realizado!" widht="55%" CssClass="form-control" /> <br/><br/> 
       <asp:RequiredFieldValidator ID="requiredTipoServico"
           runat="server"
           ControlToValidate="TxtTipoServico"
           ErrroMessage="Insira o tipo de serviço que será realizado!"
           forecolor="Red"
           />
       

     Status do Serviço: <br/>
       <asp:TextBox ID="TxtStatusServico" runat="server" placeholder="Descreva como Está o andamento do serviço! " Width="35% " CssClass="form-control-static"/>
          <asp:RequiredFieldValidator ID="requiredStatusServico"
              runat="server"
             ControlToValidate="txtStatusServico"
              ErrorMesage="Qual o Statu do Serviço?"
              ForeColor="Red"
              />                
      


   Descrição do Serviço: <br/>
      <asp:TextBox ID="txtDescricaoServico" runat="server" placeholder="Descreva a tipo de Serviço!" Width="60%" CssClass="form-control-static" />
       <asp:RequiredFieldValidator ID="requiredDescricaoServico"
         runat="server"
           ControlToValidate="txtDescricaoServico"
             ErrorMessage="Descriçao Serviço"
              ForeColor="Red"
           />
       
                
                <p>
                    <asp:Label ID ="lblMensagem2" runat="server" />
                </p>

         <asp:Button ID="BtnCadastrarServico" runat="server" Text="Cadastrar Serviço" CssClass="btn btn-success btn-lg"  onclick="BtnCadastrarServico_Click" />

                <a href="/Default.aspx" class="btn btn-default btn-lg" >"Voltar a Pagina Anterior" </a>

                </div>
            </div>
    
    </div>
    </form>
</body>
</html>
