<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="CrudDemo.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 255px;
        }
        .auto-style3 {
            width: 135px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="font-size:x-large" align="center">Student Info Form</div>
            <br />

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">Student ID</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium"  Width="268px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">Student Name</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium"  Width="268px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">Address</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>India</asp:ListItem>
                            <asp:ListItem>USA</asp:ListItem>
                            <asp:ListItem>Canada</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">Age</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium"  Width="268px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">Contact</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Font-Size="Medium"  Width="268px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" BackColor="#CC0099" BorderColor="Black" Font-Bold="True" ForeColor="White" OnClick="Button1_Click" Text="Insert" Width="78px" />
                    &nbsp;
                        <asp:Button ID="Button2" runat="server" BackColor="#CC0099" BorderColor="Black" Font-Bold="True" ForeColor="White" OnClick="Button2_Click" Text="Update" Width="78px" />
                    &nbsp;
                        <asp:Button ID="Button3" runat="server" BackColor="#CC0099" BorderColor="Black" Font-Bold="True" ForeColor="White" OnClick="Button3_Click" Text="Delete" Width="78px" />
                    &nbsp;
                        <asp:Button ID="Button4" runat="server" BackColor="#CC0099" BorderColor="Black" Font-Bold="True" ForeColor="White" OnClick="Button4_Click" Text="View" Width="78px" />
                    &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" Width="683px">
                        </asp:GridView>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
