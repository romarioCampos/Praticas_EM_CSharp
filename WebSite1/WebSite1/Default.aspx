<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="~/Login.ascx" TagPrefix="uc1" TagName="Login" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:Login runat="server" ID="ctrLogin" />
        </div>
        <asp:TextBox ID="txtMensagem" runat="server"></asp:TextBox>
        <input type="text" name="telefone" id="telefone" runat="server" />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Mostrar mensagem" />
        <br />
        <br />
        <br />
        <asp:DropDownList ID="ddlContatos" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <select id="selectManual">
            <% foreach (var contato in contatos)
                { %>
                    <option value="<%= contato.Id %>"><%= contato.Nome %></option>
            <% } %>
        </select><br />
&nbsp;<asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
