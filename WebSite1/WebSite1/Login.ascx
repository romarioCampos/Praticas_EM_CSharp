<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="Login" %>
<div class="login">
    <div>
        <asp:Label ID="lblLogin" runat="server" Text="Login: "></asp:Label>
        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblSenha" runat="server" Text="Senha: "></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnLogin" runat="server" Text="Login" />
    </div>
</div>
<p>
    &nbsp;</p>
<asp:Label ID="lblMensagem" runat="server" Text="[Mensagem]"></asp:Label>
<p>
    &nbsp;</p>

