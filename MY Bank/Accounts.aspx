<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Accounts.aspx.cs" Inherits="MY_Bank.Accounts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/Account.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="container">
    <div class="image-section">
        <img src="Image/bank%20home%20image.jpg" alt="Bank Image" />
    </div>

    <div class="form-section">

        <div>
            <table class="auto-style2">
                <tr>
                    <td colspan="2">
                        &nbsp;ACCOUNT OPENING FORM :-</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label1" runat="server" ForeColor="Maroon" Text="First Name"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label7" runat="server" ForeColor="Maroon" Text="Last  Name"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label8" runat="server" ForeColor="Maroon" Text="Address "></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label12" runat="server" ForeColor="Maroon" Text="Mobile  Number"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label13" runat="server" ForeColor="Maroon" Text="Gender"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label11" runat="server" ForeColor="Maroon" Text="City"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" CssClass="submit-button" Text="INSERT" Width="122px" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" CssClass="submit-button" Text="UPDATE" Width="122px" OnClick="Button2_Click" />
                        <asp:Button ID="Button3" runat="server" CssClass="submit-button" Text="DELETE" Width="122px" OnClick="Button3_Click" />
                    </td>
                </tr>
            </table>
                    </div>
            </div>
</div>

</asp:Content>
