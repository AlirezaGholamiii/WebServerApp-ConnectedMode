<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTest.aspx.cs" Inherits="Lab1_ASPNetConnectedMode.GUI.WebFormTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
            
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 94px;
            left: 47px;
            z-index: 1;
            width: 193px;
            height: 44px;
        }
        .auto-style2 {
            height: 215px;
        }
    </style>
</head>
<body style="height: 542px">
    <form id="form1" runat="server">
        <p class="auto-style2">
            <asp:Button ID="btnConnect" runat="server" CssClass="auto-style1" OnClick="btnConnect_Click" Text="Connect To DataBase" />
        </p>
    </form>
</body>
</html>
