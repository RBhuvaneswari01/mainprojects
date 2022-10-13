<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webformsproject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="HI ! WELCOME TO THE PAGE"></asp:Label>
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="408px" ImageUrl="~/images/aits pic.jpg" Width="1260px" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Select the below options to see the deatails"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="student details" />
&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;<asp:Button ID="Button2" runat="server" Text="class details" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;<asp:Button ID="Button3" runat="server" Text="subject details" OnClick="Button3_Click" />
        <br />
        <br />
        <div>
        </div>
    </form>