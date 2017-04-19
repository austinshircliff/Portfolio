<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountDetails.aspx.cs" Inherits="HW2.AccountDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 186px;
        }
        .auto-style4 {
            width: 186px;
        }
        .auto-style5 {
            height: 23px;
            width: 248px;
        }
        .auto-style6 {
            width: 248px;
        }
        .auto-style7 {
            height: 23px;
            width: 256px;
        }
        .auto-style8 {
            width: 256px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Account Name:</td>
                <td class="auto-style5">
                    <asp:Label ID="AccountNameLabel" runat="server"></asp:Label>
                </td>
                <td class="auto-style7"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style4">Account Type:</td>
                <td class="auto-style6">
                    <asp:Label ID="AccountTypelabel" runat="server"></asp:Label>
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Account Balance:</td>
                <td class="auto-style6">
                    <asp:Label ID="AccountBalanceLabel" runat="server"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="withdrawlTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="WithdrawlButton" runat="server" Text="Withdrawl Money" OnClick="WithdrawlButton_Click" />
                </td>
                <td>
                    <asp:Label ID="WithdrawlErrorLabel" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Eligible for Loan:</td>
                <td class="auto-style6">
                    <asp:Label ID="LoanLabel" runat="server"></asp:Label>
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td>
                    <asp:Button ID="LoanButton" runat="server" Text="Want a Loan?" PostBackUrl ="~/LoanApplicationPage.aspx" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Address Provided:</td>
                <td class="auto-style6">
                    <asp:Label ID="AddressLabel" runat="server"></asp:Label>
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
