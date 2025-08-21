<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MY_Bank.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/Login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="container">
  <div id="image-section" class="image-section">
    <img src="Image/Home_2.jpeg" alt="login image" />
  </div>
  <div id="form-section" class="form-section">
    <h2>Login</h2>
    <label for="TextBox1">User:</label><br />
    <asp:TextBox ID="TextBox1" runat="server" CssClass="input-box" /><br /><br />

    <label for="TextBox2">Password:</label><br />
    <asp:TextBox ID="TextBox2" runat="server" CssClass="input-box" TextMode="Password" /><br /><br />
      <asp:Button class="login-button" runat="server" Text="Login" OnClick="Unnamed1_Click1" />
  </div>
</div>   

</asp:Content>
