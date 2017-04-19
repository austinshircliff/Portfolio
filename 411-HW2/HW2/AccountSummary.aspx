<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountSummary.aspx.cs" Inherits="HW2.AccountSummary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td style="text-align: center; font-size: xx-large; font-weight: 700">Welcome
                    <asp:Label ID="FirstNameLabel" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>All Accounts Available</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:ListBox ID="AccountListBox" runat="server" Width="235px"></asp:ListBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center">
                    <asp:Button ID="ShowDetailsButton" runat="server" BackColor="#3399FF" ForeColor="White" Height="46px" Text="Show Details" Width="136px" PostBackUrl="~/AccountDetails.aspx" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
