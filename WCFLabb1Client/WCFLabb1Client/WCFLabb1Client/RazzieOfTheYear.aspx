<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RazzieOfTheYear.aspx.cs" Inherits="WCFLabb1Client.RazzieOfTheYear" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelInput" runat="server" Text="Search Razzie by year (1980-2014) "></asp:Label>
        <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonResultRazzie" runat="server" OnClick="ButtonResultRazzie_Click" Text="Get Razzie" />
    
    </div>
        <asp:Label ID="LabelResult" runat="server"></asp:Label>
    </form>
</body>
</html>
