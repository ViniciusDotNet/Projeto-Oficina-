<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title> Detalhes do Cliente </title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />

</head>
<script src="Scripts/jquery-1.9.1.min.js" ></script>
<script src="Scripts/bootstrap.min.js"></script>

<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset1" />
            <div class="row" />


        <h3 class="well"> Detalhes do Cliente</h3>

         Insira o Código: <br/>
        <asp:TextBox ID ="txtCodigo" runat="server" CssClass="form-control" Width="4%" /> <br/>
        
        <asp:Button ID="BtnPesquisa" runat="server" Text="Pesquisar" CssClass="btn btn-info btn-lg" OnClick="BtnPesquisaCliente"/>
        <br/> <br />


       <asp:Panel ID="pnlDados" runat="server" >
        Nome do Cliente:
        <asp:TextBox ID="txtNome" runat="server"  CssClass="form-control" Width="45%" />
        <br />
        
        Endereço do Cliente:
        <asp:TextBox ID="txtEndereco" runat="server"  CssClass="form-control" Width="50%" />
        <br />
        
        Email do Cliente:
        <asp:TextBox ID="txtEmail" runat="server"  CssClass="form-control" Width="45%" />
        <br />

       
         <asp:Button ID ="btnExcluir" runat="server"  Text="Excluir" CssClass="btn btn-danger btn-lg" OnClick="btnExcluirCliente" />
        <br /><br/>

        <asp:Button ID="Atualizar" runat="server" Text="Atualizar" CssClass="btn btn-warning btn-lg"  OnClick="AtualizarCliente"/>
        <br /><br/>

         </asp:Panel>

        <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar a Página Anterior</a>
    
         
        <p>
            <asp:Label ID="lblMensagem" runat="server"> </asp:Label>
           
        </p>

    </div>
    </form>
</body>
</html>
