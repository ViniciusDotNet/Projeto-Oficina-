<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalhesServico.aspx.cs" Inherits="Site.PAGESERVICE.DetalhesServico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title> Detalhes da Ordem de Serviço</title>

    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
<script src="Scripts/jquery-1.9.1.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>

<body>
    <form id="form1" runat="server">
    <div class="container">
       <div class="span col-lg-10 offset1">
           <div class="row">

           </div>

           <h3 class="well"> Detalhes da Ordem de Serviço  </h3>

           Insira o Código da Ordem de Serviço: <br/>
           <asp:TextBox ID="TxtCodigoOS" runat="server" Cssclass="form-control" Width="4%" />
           <br/><br/>

           <asp:Button ID="btnPesquisarOS" runat="server"  text="PesquisarOS" CssClass="btn btn-info btn-lg"  Onclick="BtnPesquisarOS" />
           <br/><br/>

           <asp:Panel ID="pnldadosTipoServico" runat="server">
               TIPO DE SERVIÇO:
               <asp:TextBox ID="TxtTipoServico" runat="server" cssclass="form-control" width="45%" />
               <br />

               Descrição Serviço:
               <asp:textBox ID="TxtdescricaoServico" runat="server" CssClass="form-control" Width="65%" />
               <br />

               Status da Ordem de Serviço:
               <asp:TextBox ID="txtStatusServico" runat="server" CssClass="form-control" Width="25%" />
               <br />

               <asp:Button ID="btnExcluirServico" runat="server" text="Excluir OS" CssClass="btn btn-danger btn-lg" onclick="btnExcluirServico_Click" />
               <br /><br/>

               <asp:Button ID="btnAtualizarServico" runat="server" Text=" Atualizar OS" CssClass="btn btn-warning btn-lg" OnClick="btnAtualizarServico_Click"/>
               <br/><br/>

           </asp:Panel>

           <br/><br/>
        <a href="/Default.aspx" class="btn  btn-default btn-lg"> Voltar a Tela Anterior </a>                

           <p>
              <asp:Label ID="lblMensagem2" runat="server"></asp:Label>

           </p>

       </div>
    
    </div>
    </form>
</body>
</html>
