<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherForecast.aspx.cs" Inherits="WCFLabb1Client.WeatherForecast" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelWeather" runat="server" Text="Tomorrows weather: "></asp:Label>
        <asp:Button ID="ButtonGetWeather" runat="server" OnClick="ButtonGetWeather_Click" Text="Find out" />
        <asp:Label ID="LabelResultWeather" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
