<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SwimCalculator.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" defaultfocus="minutesTextBox">
    
        <div class="style1">
    
        <asp:Label ID="Label1" runat="server" Text="Minutes:" Style="z-index: 1; left: 84px;
            top: 44px; position: absolute"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Length (m):" Style="z-index: 1; left: 68px;
            top: 143px; position: absolute"></asp:Label>
        <asp:Label ID="Label4" runat="server" Text="Cals/hr:" Style="z-index: 1; left: 91px;
            top: 191px; position: absolute"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Laps:" Style="z-index: 1; left: 104px;
            top: 92px; position: absolute"></asp:Label>
        <asp:TextBox ID="minutesTextBox" runat="server" Style="z-index: 1; left: 157px; top: 44px;
            position: absolute; text-align: right;">0</asp:TextBox>
        <asp:TextBox ID="lapsTextBox" runat="server" Style="z-index: 1; left: 157px; top: 91px;
            position: absolute; text-align: right;" TabIndex="1">0</asp:TextBox>
        <asp:TextBox ID="lengthTextBox" runat="server" Style="z-index: 1; left: 157px; top: 142px;
            position: absolute; text-align: right;" TabIndex="-1">20</asp:TextBox>
        <asp:TextBox ID="caloriesTextBox" runat="server" Style="z-index: 1; left: 157px; top: 190px;
            position: absolute; text-align: right;" TabIndex="-1">1070</asp:TextBox>
        <asp:Button ID="convertButton" runat="server" Text="&gt;" Style="z-index: 1; left: 363px;
            top: 44px; position: absolute; height: 168px; width: 82px;" Font-Bold="True" 
                Font-Size="X-Large" onclick="convertButton_Click" TabIndex="2" />
        <asp:TextBox ID="resultsTextBox" runat="server" Style="z-index: 1; left: 494px; top: 44px;
            position: absolute; height: 166px; width: 320px;" ReadOnly="True" 
                TabIndex="-1" TextMode="MultiLine"></asp:TextBox>
        </div>    
    </form>
</body>
</html>
