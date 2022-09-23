<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listagem.aspx.cs" Inherits="ProjetoEsig.Listagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .container{
            width: 450px;
            margin: 0 auto;
        }
        
        .container h1{
            text-align: center;
        }

        .campo{
            padding: 10px;
        }

        .campo input[type="text"]{
            float: right;
            width: 350px;
        }

        .campo input[type="submit"]{
            float: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Recalcular os Salários</h1>
            <div class="campo">
                <asp:Label runat="server" AssociatedControlID="txtNome">Nome: </asp:Label>
                <asp:TextBox runat="server" ID="txtNome"></asp:TextBox>
            </div>
            <div class="campo">
                <asp:Label runat="server" AssociatedControlID="txtCargo_ID">Cargo_ID: </asp:Label>
                <asp:TextBox runat="server" ID="txtCargo_ID"></asp:TextBox>
            </div>

            <div class="campo">
                <asp:Button ID="btnRecalcular" runat="server" Text="Recalcular" />
            </div>
            <p><asp:Literal runat="server" ID="ltMensagem"></asp:Literal></p>
        </div>
    </form>
</body>
</html>
