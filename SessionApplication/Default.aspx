<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SessionApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter your name: "></asp:Label>
    
        <asp:TextBox ID="YourName" runat="server"></asp:TextBox>
    
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter your Email: "></asp:Label>
    
        <asp:TextBox ID="YourEmail" runat="server"></asp:TextBox>
    
        <br />
        <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click" />
    
    &nbsp;<asp:Button ID="RetrieveButton" runat="server" Text="Retrieve" OnClick="RetrieveButton_Click" />
    
        <br />
        <asp:Label ID="NameAndEmail" runat="server" Text=""></asp:Label>
    
        <br />
        <asp:Label ID="RetrievedNameAndEmail" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
