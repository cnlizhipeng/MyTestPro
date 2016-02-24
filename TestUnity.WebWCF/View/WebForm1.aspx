<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EFWCF.WebWCF.View.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="发布消息："></asp:Label>
        <asp:TextBox ID="txtMsg" runat="server"></asp:TextBox>
        <asp:Button ID="btnSendMsg" runat="server" OnClick="btnSendMsg_Click" Text="发送消息" />
        <asp:GridView ID="GridView1" runat="server" Width="479px">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="获取所有连接" />
    
    </div>
    </form>
</body>
</html>
