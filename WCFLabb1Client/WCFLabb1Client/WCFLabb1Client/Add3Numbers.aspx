<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add3Numbers.aspx.cs" Inherits="WCFLabb1Client.Add3Numbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelNumber1" runat="server" Text="Insert a number"></asp:Label>
        <asp:TextBox ID="TextBoxNumber1" runat="server"></asp:TextBox>
    
    </div>
        <asp:Label ID="LabelNumber2" runat="server" Text="Insert a number"></asp:Label>
        <asp:TextBox ID="TextBoxNumber2" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="LabelNumber3" runat="server" Text="Insert a number"></asp:Label>
            <asp:TextBox ID="TextBoxNumber3" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="ButtonResultAdd3" runat="server" OnClick="ButtonResultAdd3_Click" Text="Add all numbers" />
        <asp:Label ID="LabelResultAdd3" runat="server"></asp:Label>
    </form>
</body>
</html>
