<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="davidsp8.web.PostSamlAssertion._Default" EnableSessionState="True" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultfocus="txtEmail" 
    defaultbutton="btnLogin">
    <div>
    
        <asp:Label ID="lblGroupAccountCode" runat="server" Text="Employee ID:"></asp:Label>&nbsp
        <asp:TextBox ID="txtSSOID" runat="server"></asp:TextBox>&nbsp
        <asp:Label ID="lblUserId" runat="server" Text="User ID:"></asp:Label>&nbsp
        <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>&nbsp
        <asp:Button ID="btnLogin" runat="server" Text="Login" 
            onclick="btnLogin_Click" />&nbsp
    
        &nbsp<asp:HyperLink ID="lnkSSO" runat="server" NavigateUrl="SSO.aspx" 
            Target="_blank" Visible="False">SSO</asp:HyperLink>
    
    &nbsp;</div>
    </form>
</body>
</html>
