<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="JqueryProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%-- JQUERY SCRIPT --%>
    <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script>
        function onValidate() {
            if (!($("#Text1").val())) {
                $("#Label1").css("color", "red");
                $("#Label1").text("*Please enter your name")
                return false;
            }
            else {
                $("#Label1").remove();
            }
            if (!($("Text2").val())) {
                $("#Label4").css("color", "red");
                $("#Label4").text("*Please enter email Id")
                return false;

            }
            return true;
          }OnClientClick="return onValidate() "
    </script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
             <input id="Text1" type="text"  runat="server"  /><asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Email-id"></asp:Label>
            <input id="Text2" type="text"  runat="server" /><asp:Label ID="Label4" runat="server"></asp:Label>
        </p>
        <asp:Button ID="Button1" runat="server"  Text="Login"   OnClick="Button1_Click" />
        <p>
            <asp:Label ID="Label5" runat="server" Text="Invalid User"></asp:Label>
        </p>
    </form>
</body>
</html>
