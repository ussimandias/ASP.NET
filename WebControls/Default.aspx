<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebControls.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBox ID="SSD1" Text="SSD?" runat="server" />
        <asp:CheckBox ID="SixteenGB" Text="16GB?" runat="server" />
        <asp:CheckBox ID="DaulMonitor" Text="Dual Monitor?" runat="server" />
        <hr/>
        <asp:RadioButton ID="MaleRadioButton" GroupName="Sex" Text="Male" Checked="True" runat="server" />
        <asp:RadioButton ID="FemaleRadioButton" GroupName="Sex" Text="Female" runat="server" />
        <hr/>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
             <asp:ListItem Text="Power Windows" Value="Feature1"></asp:ListItem>
             <asp:ListItem Text="Power Seats" Value="Feature2"></asp:ListItem>
             <asp:ListItem Text="For Lights" Value="Feature3"></asp:ListItem>
             <asp:ListItem Text="Winter Packag" Value="Feature4"></asp:ListItem>
        </asp:CheckBoxList>
        <hr/>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
             <asp:ListItem Text="Under 30" Value="Young" Selected="True"></asp:ListItem>
             <asp:ListItem Text="30 - 60" Value="Middle-Age" ></asp:ListItem>
             <asp:ListItem Text="Over 60" Value="Old-Age"></asp:ListItem>
        </asp:RadioButtonList>
        <hr/>

        <asp:DropDownList ID="DropDownList1" runat="server">
             <asp:ListItem Text="Item 1" Value="1" />
             <asp:ListItem Text="Item 2" Value="2" />
             <asp:ListItem Text="Item 3" Value="3" />
             <asp:ListItem Text="Item 4" Value="4" />
        </asp:DropDownList>
        <hr/>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
