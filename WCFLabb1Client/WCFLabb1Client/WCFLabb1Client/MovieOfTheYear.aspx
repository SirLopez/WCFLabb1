<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieOfTheYear.aspx.cs" Inherits="WCFLabb1Client.MovieOfTheYear" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelYear" runat="server" Text="Input Year"></asp:Label>
        <asp:TextBox ID="TextBoxInputYear" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonResult" runat="server" OnClick="ButtonResult_Click" Text="Get Movie" />
    
    </div>
        <asp:Label ID="LabelResultMovie" runat="server"></asp:Label>
    </form>
</body>
</html>
