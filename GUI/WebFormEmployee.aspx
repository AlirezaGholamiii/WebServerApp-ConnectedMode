<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormEmployee.aspx.cs" Inherits="Lab1_ASPNetConnectedMode.GUI.WebFormEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 427px;
            margin-right: 0px;
        }
        .auto-style2 {
            height: 61px;
        }
        .auto-style31 {
            width: 220px;
            height: 61px;
            text-align: center;
        }
        .auto-style33 {
            height: 61px;
            text-align: right;
            width: 209px;
        }
        .auto-style35 {
            width: 100%;
            height: 75px;
        }
        .auto-style39 {
            height: 60px;
            text-align: right;
            width: 220px;
        }
        .auto-style40 {
            height: 61px;
            text-align: right;
            width: 145px;
        }
        .auto-style42 {
            height: 60px;
            text-align: right;
            width: 146px;
        }
        .auto-style45 {
            height: 60px;
            width: 220px;
            text-align: center;
        }
        .auto-style48 {
            height: 60px;
            width: 210px;
            text-align: center;
        }
        .auto-style49 {
            text-align: left;
        }
        .auto-style51 {
            text-align: right;
            width: 146px;
            height: 20px;
        }
        .auto-style52 {
            height: 20px;
            width: 220px;
            text-align: center;
        }
        .auto-style53 {
            height: 20px;
            width: 210px;
            text-align: center;
        }
        .auto-style54 {
            height: 20px;
            text-align: right;
            width: 220px;
        }
        .auto-style55 {
            height: 20px;
        }
        .auto-style56 {
            text-align: right;
            height: 20px;
        }
        .auto-style57 {
            height: 43px;
        }
        .auto-style58 {
            height: 61px;
            text-align: right;
        }
        .auto-style59 {
            height: 61px;
            width: 251px;
        }
        .auto-style61 {
            height: 60px;
            text-align: left;
            width: 251px;
        }
        .auto-style62 {
            height: 20px;
            text-align: right;
            width: 251px;
        }
        .auto-style63 {
            height: 61px;
            text-align: left;
            width: 251px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style59" rowspan="2">
                        &nbsp;</td>
                    <td class="auto-style58" colspan="3" rowspan="2">
                        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#FF6600" Text="Employee Maintenance"></asp:Label>
                    </td>
                    <td class="auto-style57"></td>
                </tr>
                <tr>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style63">
                        <asp:Label ID="Label2" runat="server" Text="Employee ID :"></asp:Label>
                    </td>
                    <td class="auto-style40">
                        <asp:TextBox ID="txtEmployeeId" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style31">
                        <asp:Button ID="btnAdd" runat="server" Height="50px" OnClick="btnAdd_Click" Text="Add" Width="200px" />
                    </td>
                    <td class="auto-style33">
                        &nbsp;</td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style63">
                        <asp:Label ID="Label3" runat="server" Text="First Name : "></asp:Label>
                    </td>
                    <td class="auto-style40">
                        <asp:TextBox ID="txtFirstName" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style31">
                        <asp:Button ID="btnUpdate" runat="server" Height="50px" OnClick="btnUpdate_Click" Text="Update" Width="200px" />
                    </td>
                    <td class="auto-style33">
                        &nbsp;</td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style63">
                        <asp:Label ID="Label4" runat="server" Text="Last Name :"></asp:Label>
                    </td>
                    <td class="auto-style40">
                        <asp:TextBox ID="txtLastName" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style31">
                        <asp:Button ID="btnDelete" runat="server" Height="50px" OnClick="btnDelete_Click" Text="Delete" Width="200px" />
                    </td>
                    <td class="auto-style33">
                        &nbsp;</td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style63">
                        <asp:Label ID="Label5" runat="server" Text="Job Title : "></asp:Label>
                    </td>
                    <td class="auto-style40">
                        <asp:TextBox ID="txtJobTitle" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style31">
                        <asp:Button ID="btnListAll" runat="server" Height="50px" OnClick="btnListAll_Click" Text="List All" Width="200px" />
                    </td>
                    <td class="auto-style33">
                        &nbsp;</td>
                    <td></td>
                </tr>
                </table>
        </div>
        <table class="auto-style35">
            <tr>
                <td class="auto-style61">
                    <asp:Label ID="Label6" runat="server" Text="Search by :"></asp:Label>
                </td>
                <td class="auto-style42">
                    <asp:DropDownList ID="DropDownListSearchOptions" runat="server" Width="200px">
                        <asp:ListItem>Employee ID</asp:ListItem>
                        <asp:ListItem>First or Last Name</asp:ListItem>
                        <asp:ListItem>Job Title</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style45">
                    <asp:TextBox ID="TxtSearchBy" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td class="auto-style48">
                    <asp:Button ID="btnSearch" runat="server" Height="50px" OnClick="btnSearch_Click" Text="Search" Width="200px" />
                </td>
                <td class="auto-style39">
                    &nbsp;</td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style51"></td>
                <td class="auto-style52"></td>
                <td class="auto-style53"></td>
                <td class="auto-style54"></td>
                <td class="auto-style55"></td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style56" colspan="4">
            <asp:GridView ID="GridViewEmployee" runat="server" Height="276px" Width="736px">
            </asp:GridView>
                </td>
                <td class="auto-style55">&nbsp;</td>
            </tr>
        </table>
        <div class="auto-style49">
        </div>
    </form>
</body>
</html>
