﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexgmt.aspx.cs" Inherits="GetGMTByCountryWebApplication.indexgmt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="LabelGmt" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get GMT" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
