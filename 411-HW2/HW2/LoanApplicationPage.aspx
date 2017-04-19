<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoanApplicationPage.aspx.cs" Inherits="HW2.LoanApplicationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            width: 246px;
        }
        .auto-style3 {
            width: 246px;
        }
    </style>
</head>
<body>
   
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Name</td>
                <td>
                    <asp:Label ID="NameLabel" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Salary</td>
                <td>
                    <asp:TextBox ID="SalaryTextBox" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Age</td>
                <td>
                    <asp:TextBox ID="AgeTextBox" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Loan Amount</td>
                <td>
                    <asp:TextBox ID="LoanTextBox" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="LoanApprovalLabel" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="AccountSumButton" runat="server" Text="Go to Account Summary"  PostBackUrl="~/AccountSummary.aspx"/>
                </td>
                <td>
                    <asp:Button ID="AccountDetailsButton" runat="server" Text="Go to Account Details" PostBackUrl="~/AccountDetails.aspx" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
