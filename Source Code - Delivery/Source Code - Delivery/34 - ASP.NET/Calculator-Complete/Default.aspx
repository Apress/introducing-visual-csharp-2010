<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculator_Complete.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            height: 259px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" defaultfocus="minutesTextBox">
    <br />
    <asp:Label ID="Label1" runat="server" Style="z-index: 1; left: 54px; top: 43px; position: absolute;
        text-align: right" Text="Minutes:"></asp:Label>

    <asp:TextBox ID="minutesTextBox" runat="server" Height="22" Style="z-index: 1; left: 124px;
        top: 42px; position: absolute; text-align: right">1</asp:TextBox>
    <br />
    <asp:TextBox ID="resultsTextBox" runat="server" ReadOnly="True" Style="z-index: 1;
        left: 436px; top: 42px; position: absolute; height: 135px; width: 325px" 
        TextMode="MultiLine" TabIndex="6"></asp:TextBox>
    <br />
    <asp:TextBox ID="lapsTextBox" runat="server" Style="z-index: 1; left: 124px; top: 83px;
        position: absolute; text-align: right">1</asp:TextBox>
    <br />
    <asp:Button ID="convertButton" runat="server" Font-Bold="True" Font-Size="X-Large"
        OnClick="convertButton_Click" Style="z-index: 1; left: 318px; top: 42px; position: absolute;
        height: 135px; width: 74px" Text="&gt;" />
    <br />
    <asp:Label ID="Label2" runat="server" Style="z-index: 1; left: 73px; top: 84px; position: absolute;
        width: 32px; right: 878px" Text="Laps:"></asp:Label>
    <asp:Label ID="Label3" runat="server" Style="z-index: 1; left: 36px; top: 124px;
        position: absolute" Text="Length (m):"></asp:Label>
    <asp:Label ID="Label4" runat="server" Style="z-index: 1; left: 59px; top: 159px;
        position: absolute" Text="Cals/hr:"></asp:Label>
    <asp:TextBox ID="lengthTextBox" runat="server" Style="z-index: 1; left: 124px; top: 123px;
        position: absolute; text-align: right" TabIndex="4">20</asp:TextBox>
    <asp:TextBox ID="caloriesTextBox" runat="server" Style="z-index: 1; left: 124px;
        top: 158px; position: absolute; text-align: right" TabIndex="4">1070</asp:TextBox>
    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="minutesTextBox"
        Display="Dynamic" ErrorMessage="Valid Range: 1-1000" ForeColor="Red" MaximumValue="1000"
        MinimumValue="1" Style="z-index: 1; left: 288px; top: 41px; position: absolute"
        Type="Integer">*</asp:RangeValidator>
    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="lapsTextBox"
        Display="Dynamic" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="1000"
        MinimumValue="1" Style="z-index: 1; left: 287px; top: 82px; position: absolute"
        Type="Integer">*</asp:RangeValidator>
    <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="lengthTextBox"
        Display="Dynamic" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="500"
        MinimumValue="1" Style="z-index: 1; left: 286px; top: 122px; position: absolute"
        Type="Integer">*</asp:RangeValidator>
    <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="caloriesTextBox"
        Display="Dynamic" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="2000"
        MinimumValue="1" Style="z-index: 1; left: 286px; top: 157px; position: absolute"
        Type="Integer">*</asp:RangeValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Value Required"
        
        Style="z-index: 1; left: 268px; top: 41px; position: absolute; right: 960px;" 
        Text="*" Display="Dynamic"
        ControlToValidate="minutesTextBox" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Value Required"
        Style="z-index: 1; left: 268px; top: 82px; position: absolute; width: 8px;" Text="*"
        Display="Dynamic" ControlToValidate="lapsTextBox" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Value Required"
        Style="z-index: 1; left: 267px; top: 122px; position: absolute" Text="*" Display="Dynamic"
        ControlToValidate="lengthTextBox" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Value Required"
        Style="z-index: 1; left: 267px; top: 157px; position: absolute" Text="*" Display="Dynamic"
        ControlToValidate="caloriesTextBox" ForeColor="Red"></asp:RequiredFieldValidator>
    </form>
</body>
</html>
