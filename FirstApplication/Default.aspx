<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FirstApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Enter your Birthdate<br />
        <br />
        <input id="BirthDate" type="text"  runat="server"/><br />
        <input id="Submit" type="submit" value="submit" runat="server"/><br />
        <br/>
        <div id="Message" runat="server"></div>
    </div>
    </form>
</body>
</html>
