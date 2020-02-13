<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UIproject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function formValidate() {
           alert("Came here");
            var text = document.getElementById('TextBox1').value.length;
            if (text == 0) {
                document.getElementById('tb1Error').innerText = "* You haven't entered anything";
                return false;

            }
            //var lastname = document.getElementById('TextBox2').value.length;
            //if (lastname == 0) {
            //    document.getElementById('tb2Error').innerText = "* Please enter last name";
            //    return false;
            //}

            var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
            var emailID = document.getElementById('TextBox3').value.length;
            if (emailID == 0) {
                document.getElementById('tb3Error').innerText = "* Please enter valid email id";
                return false;
            }
            var contactnumber = document.getElementById('TextBox4').value.length;
            if (contactnumber == 0) {
                document.getElementById('tb4Error').innerText = "* Please enter your contact number";
                return false;
            }
           
            
            
            return true;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server" >
        <div>
            <asp:Label ID="Label3" runat="server" BorderColor="#3366FF" ForeColor="#9966FF" Text="FORMS"></asp:Label>
            <br />
            <br />
            First name&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox><span id="tb1Error" style="color:red;"></span>
            <asp:Label ID="Label6" runat="server"></asp:Label>
        </div>
        <p>
            Last name&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><span id ="tb2Error" style="color:red;"></span>&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server"></asp:Label>
        </p>
        <p>
            Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><span id ="tb3Error" style="color:red;"></span>
        </p>
        <p>
            Contact No:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><span id="tb4Error" style="color:red;"></span>
        </p>
        <p>
            Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="Male" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged1" />
            <asp:Label ID="Label1" runat="server" Text="Male"></asp:Label>
            <asp:RadioButton ID="Female" runat="server" />
            <asp:Label ID="Label2" runat="server" Text="Female"></asp:Label>
        </p>
        Select Country :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"   
                    DataTextField="cname" DataValueField="cid" AppendDataBoundItems="true"   
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">  
                    <asp:ListItem Value="0">--Select Country--</asp:ListItem>  
                </asp:DropDownList> 
        <br />
        Select State:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" AppendDataBoundItems="true" DataTextField="sname"   
                    DataValueField="sid" AutoPostBack="True"   
                    onselectedindexchanged="DropDownList2_SelectedIndexChanged">  
                    <asp:ListItem Value="0">-- Select State--</asp:ListItem>  
                </asp:DropDownList> 
        <br />
        Select City :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server" AppendDataBoundItems="true" DataTextField="ccname"   
                    DataValueField="ciid">  
                    <asp:ListItem Value="0">-- Select City--</asp:ListItem>  
                </asp:DropDownList> 
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="DOB"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Date"></asp:TextBox>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        </asp:Calendar>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click1" OnClientClick="return formValidate()" />
        <br />
        <br />
    </form>
</body>
</html>
