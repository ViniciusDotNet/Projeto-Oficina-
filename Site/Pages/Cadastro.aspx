<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title> Cadastro de Clientes </title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>

<script src="Scripts/jquery-1.9.1.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>

<body>  
    <form id="form1" runat="server">
    <div class="container">
   <div class="span10 offset1">
       <div class="row">

           <h3 class="well"> Cadastro de Clientes</h3>
       
       <br />


           Nome do Cliente: <br/>
           <asp:TextBox ID="TxtNome" runat="server" placeholder="Nome do Completo do Cliente" Width="45%"  Cssclass="form-control" /> <br/><br/>
           <asp:RequiredFieldValidator ID="requiredNome" 
               runat="server" 
               ControlToValidate="TxtNome" 
               ErrorMessage="Insira O Nome do Cliente!"
               ForeColor="Red"
               />
           <br/>


           Endereço do Cliente:<br/>
           <asp:TextBox ID="TxtEndereco" runat="server" placeholder="Endereço ou logradouro do Cliente" Width="45%" CssClass="form-control" /> <br/><br/>
           <asp:RequiredFieldValidator ID="requiredEndereco"
               runat="server"
               ControlToValidate="TxtEndereco"
               ErroMessage="Insira o Enderço do Cliente!"
               ForeColor="Red"
               />


            Email do Cliente: <br/>
            <asp:TextBox ID="TxtEmail" runat="server" placeholder="Email do Cliente" Width="35%" CssClass="form-control" /> <br/><br/>
           <asp:RequiredFieldValidator ID="requiredEmail"
               runat="server"
               ControlToValidate="TxtEmail"
               ErrorMessage="Insira o Email do Cliente"
               ForeColor="Red"
               />
           <p>
               <asp:label ID="lblMensagem" runat="server" />
           </p>
       
       <asp:Button ID="BtnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" OnClick="BtnCadastrarCliente" /> <br/> <br/>
       
       <a href="/Default.aspx" class="btn btn-default btn-lg"> Voltar a Página Anterior </a>
       
       </div>
   </div>
    
    </div>
    </form>
</body>
</html>
