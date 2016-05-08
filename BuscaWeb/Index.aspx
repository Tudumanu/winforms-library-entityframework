<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BuscaWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Busca de Livros</h1>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend>Busca por código(id):</legend>
        <asp:Label runat="server" Text="Código: "></asp:Label>
        <asp:TextBox runat="server" id="txtCodigo"></asp:TextBox>
        <asp:Button runat="server" Text="Buscar" OnClick="btnCodigo_Click" />
        <br />
        <asp:Label runat="server" id="labelMensagemCodigo"></asp:Label>
    </fieldset>
    </div>

        <br />
        <br />

    <div>
    <fieldset>
        <legend>Busca por título:</legend>
        <asp:Label runat="server" Text="Título: "></asp:Label>
        <asp:TextBox runat="server" id="txtTitulo"></asp:TextBox>
        <asp:Button runat="server" Text="Buscar" OnClick="btnTitulo_Click" />
        <asp:Label runat="server" id="labelMensagemTitulo"></asp:Label>
    </fieldset>
    </div>
    </form>
</body>
</html>
