<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetARImage.aspx.cs" Inherits="WebServer.GetARImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="Tex_ImageNum" runat="server"></asp:TextBox>
    
    </div>
        <p>
            <asp:Button ID="Btn_Image" runat="server" Text="Button" OnClick="GetImage" />
        </p>
    </form>
</body>
</html>
