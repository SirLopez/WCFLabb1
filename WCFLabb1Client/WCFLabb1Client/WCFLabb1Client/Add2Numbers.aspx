<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add2Numbers.aspx.cs" Inherits="WCFLabb1Client.Add2Numbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelNo1" runat="server" Text="Number 1"></asp:Label>
    
        <asp:TextBox ID="TextBoxNumberOne" runat="server"></asp:TextBox>
        <asp:Label ID="LabelAdd" runat="server" Text="+"></asp:Label>
        <asp:Label ID="LabelNo2" runat="server" Text=" Number 2"></asp:Label>
        <asp:TextBox ID="TextBoxNumberTwo" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonResult" runat="server" OnClick="ButtonResult_Click" Text="Equals" />
        <asp:Label ID="LabelResultAddTwoNumbers" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
