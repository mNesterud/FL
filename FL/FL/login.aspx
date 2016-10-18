<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="FL.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Logga in</h1>
        <h2>Välj användare</h2>
        <asp:Button ID="btnUser1" runat="server" Text="Användare 1" CommandArgument="1" OnCommand="login_Command"/>
        <asp:Button ID="btnUser2" runat="server" Text="Användare 2" CommandArgument="2" OnCommand="login_Command"/>
    </div>
    </form>
</body>
</html>
