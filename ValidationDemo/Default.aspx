<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidationDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter a Value"></asp:Label>
        <asp:TextBox ID="TextBox1" Text="Please enter name" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" 
            runat="server" 
            ErrorMessage="Please change the text" 
            InitialValue="Please enter name"
            ControlToValidate="TextBox1" >                    
        </asp:RequiredFieldValidator>

        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator2" 
            runat="server" 
            ErrorMessage="Please enter the text" 
            ControlToValidate="TextBox1">   
        </asp:RequiredFieldValidator>
        <br/>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        <asp:Label ID="DisplayButton" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
