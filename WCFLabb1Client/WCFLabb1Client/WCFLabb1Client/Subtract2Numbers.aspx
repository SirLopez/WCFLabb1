<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Subtract2Numbers.aspx.cs" Inherits="WCFLabb1Client.Subtract2Numbers" %>

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
            <asp:Button ID="ButtonResult" runat="server" OnClick="ButtonResult_Click" Text="Substract" />
        </p>
        <asp:Label ID="LabelResultSubstract" runat="server"></asp:Label>
    </form>
</body>
</html>
