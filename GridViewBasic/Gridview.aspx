<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gridview.aspx.cs" Inherits="GridViewBasic.Gridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView runat="server" ID="gdview"></asp:GridView>
        <asp:Button runat="server" Text="Show na bich" ID="btnshow" OnClick="btnshow_Click" />
        <br />
        <asp:TextBox runat="server" ID="txtname" placeholder="Student name"></asp:TextBox>
        <br />
        <asp:TextBox runat="server" ID="txtrollno" placeholder="Student Rollno"></asp:TextBox>
        <br />
        <asp:Button runat="server" Text="here🤌, Add some comedy(student)" ID="btnadd" OnClick="btnadd_Click" />
    </div>
    </form>
</body>
</html>
