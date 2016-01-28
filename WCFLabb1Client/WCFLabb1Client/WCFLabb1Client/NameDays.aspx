<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NameDays.aspx.cs" Inherits="WCFLabb1Client.NameDays" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelInsert" runat="server" Text="Insert name"></asp:Label>
        <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox>
    
    </div>
        <asp:Button ID="ButtonResultDate" runat="server" OnClick="ButtonResultDate_Click" Text="Get date" />
        <asp:Label ID="LabelResultDate" runat="server"></asp:Label>
    </form>
</body>
</html>
