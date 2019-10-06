<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="Cadastro" %>

<%@ Register src="Login.ascx" tagname="Login" tagprefix="uc1" %>
<%@ Register Src="~/Login.ascx" TagPrefix="uc2" TagName="Login" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        img{
            width:100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:Login ID="ctrLogin" runat="server" />
            <uc2:Login runat="server" ID="ctrLogin2" />
        </div>
        <div>
            <asp:Panel ID="pnlCampoCadastro" runat="server">
                <asp:Label ID="lblNome" runat="server" Text="Nome: "></asp:Label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Telefone: "></asp:Label>
                <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Foto: "></asp:Label>
                <asp:FileUpload ID="fileFoto" runat="server" />
                <br />
                <br />
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </asp:Panel>
        </div>
        <asp:Panel ID="pnlResultado" runat="server">
            <asp:Button ID="btnIrCadastro" runat="server" Text="Novo Cadastro" OnClick="btnIrCadastro_Click" />
            <hr />
            <asp:GridView ID="gridResultado" AutoGenerateColumns="false" runat="server">
                <Columns>
                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                    <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                    <asp:ImageField DataImageUrlField="Foto" HeaderText="Foto">
                    </asp:ImageField>
                </Columns>
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
