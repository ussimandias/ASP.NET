<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SecondWebApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter your Birthdate:"></asp:Label><br />
        <asp:TextBox ID="BirthDate" runat="server"></asp:TextBox> <br />
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" /><br />
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
