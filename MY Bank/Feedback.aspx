<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="MY_Bank.Feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/Feedback.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="container">
        <!-- Left: Bank Contact Image -->
        <div class="image-section">
            <img src="Image/bankbackgroud.jpg" alt="Contact Image" />
        </div>
        <!-- Right: Contact Form -->
        <div class="form-section">
            <h2>FeedBack Form</h2>

            <label for="txtName">Your Name</label><br />
            <asp:TextBox ID="txtName" runat="server" CssClass="input-box" /><br />

            <label for="txtEmail">Your Email</label><br />
            <asp:TextBox ID="txtEmail" runat="server" CssClass="input-box" /><br />

            <label for="txtMessage">Your Message</label><br />
            <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" Rows="5" CssClass="input-box" /><br />
            <asp:Button ID="Button1" runat="server" CssClass="submit-button" Text="SUBMIT FEEDBACK" OnClick="Button1_Click" />
        </div>
    </div>
</asp:Content>
