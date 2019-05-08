<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
<link href="Content/bootstrap.css" rel="stylesheet" />

</head>
    <script src="scripts/jquery-1.9.1.min.js"></script>
<script src="scripts/bootstrap.min.js"></script>

<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
        <h1> Oficina - Controle de Clientes</h1>
        
        seleciona a Operação:
        <asp:DropDownList ID="ddlMenu" runat="server">
            <asp:ListItem Value="0"  Text="Escolha uma Opçao"/>
            <asp:ListItem Value="1" Text="Cadastrar Cliente" />
            <asp:ListItem Value="2" Text="Consultar" />
            <asp:ListItem Value="3" Text="Obter dados do cliente" />
        </asp:DropDownList>
        
        <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-info btn-lg" OnClick="btnMenu_Click"/>
            <p>
                <asp:Label ID="lblMensagem" runat="server" />
            </p>


        <div class="jumbotron">
        <h1>  Controle de Serviços</h1>
        
        Selecione a Operação:
        <asp:DropDownList ID="ddlMenu2" runat="server">
            <asp:ListItem Value="0"  Text="Escolha uma Opçao"/>
            <asp:ListItem Value="1" Text="Cadastrar Serviço" />
            <asp:ListItem Value="2" Text="Consultar Serviço" />
            <asp:ListItem Value="3" Text="Obter dados do Serviço" />
        </asp:DropDownList>
        
        <asp:Button ID="btnMenu2" runat="server" Text="Acessar" CssClass="btn btn-info btn-lg" Onclick="btnMenu2_Click"/>
            <p>
                <asp:Label ID="lblMensagem2" runat="server" />
            </p>

            <div>
    </div>
    </div>
    </form>
</body>
</html>
