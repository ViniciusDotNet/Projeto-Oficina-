<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title> Consultar Dados do Cliente</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />"
</head>

    <script src="Scripts/jquery-1.9.1.min.js" ></script>
    <script src="Scripts/bootstrap.min.js" ></script>

<body>
    
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset1">
            <div class="row" />

               <h3 class="well"> Consulta de Dados do Cliente</h3>
        
<asp:GridView ID="GridClientes" runat="server"  CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="SpringGreen">
<Columns>
    <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
    <asp:BoundField DataField="Nome" HeaderText="Nome" />
    <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
    <asp:BoundField DataField="Email" HeaderText="Email" />
</Columns>  
    <RowStyle CssClass="cursor-pointer" />          
</asp:GridView>
            
              <a href="/Default.aspx" class="btn btn-default btn-lg"> Voltar a Pagina Anterior</a>  
    </div>
        
        <p>
            <asp:label ID="lblMensagem" runat="server" />
        </p>
         
        </div>
    </form>
</body>
</html>
