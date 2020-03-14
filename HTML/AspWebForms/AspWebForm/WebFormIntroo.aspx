
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormIntroo.aspx.cs" Inherits="AspWebForm.WebFormIntroo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
<asp:Label runat="server" Text="Name"></asp:Label><asp:TextBox runat="server" Height="21px" Width="215px"></asp:TextBox>

        <br />
        <br />
        <div>

        <asp:Button id="Button1" runat="server" Text="Button" OnClick="Button1_Click" Width="72px" />
        </div>
    </form>
</body>
</html>
