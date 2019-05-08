<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaServico.aspx.cs" Inherits="Site.PAGESERVICE.ConsultaServico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title> Consulta Ordem de Servico</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />

</head>

<script src="Scripts/jquery-1.9.1.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>

<body>
    <form id="form1" runat="server">
    
        <div class="container">
       
        <div class="span10 ofsset1">
            
            <div class="row">
            </div>

            <h3 class="well"> Consulta de Ordem de Serviço </h3>
       </div>
   <asp:GridView ID="GridServicos" runat="server" cssClass="table table-bordered" GridLine="None" AutoGenerateColumns="false" BackColor="SteelBlue" >  
     <Columns>
    <asp:BoundField DataField="codigoservico" HeaderText="Codigo:OS" />
    <asp:BoundField DataField="TipoServico" HeaderText="tipo OS" />
    <asp:BoundField DataField="DescricaoServico" HeaderText="descricao da OS" />
    <asp:BoundField DataField="StatuServico" HeaderText="Status do Servico" />
</Columns>  
    <RowStyle CssClass="cursor-pointer" />          
</asp:GridView>
    
                <a href="/Default.aspx" class="btn btn-default btn-lg"> Voltar  a Página Anterior</a>
        </div>
    
        <p>
           <asp:Label ID="lblMensagem2" runat="server" />

        </p>
    
    </form>
</body>
</html>
