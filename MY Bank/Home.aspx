<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MY_Bank.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/Home.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 434px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="container">
        <div class="image-section">
            <img src="Image/bank%20home%20image.jpg"  alt="home image." class="auto-style1"/>
        </div>
        <div class="home-text-section">
            <h1>About Our Bank</h1>
            <p>
                My Bank has been a pillar of financial stability and customer trust for over 50 years.
                We provide comprehensive services including savings and current accounts, personal and business loans,
                fixed deposits, and cutting-edge digital banking platforms.
            </p>
            <p>
                With a vast network of branches and ATMs across the country, combined with secure online access,
                we make banking accessible anytime, anywhere. Our goal is to make financial services simple,
                secure, and tailored to the evolving needs of our customers.
            </p>
            <p>
                Whether you're opening your first account, expanding your business, or planning your retirement,
                My Bank is your partner in every financial journey.<br /><br />
                <a href="Accounts.aspx" class="account-link">CLICK HERE TO CREATE YOUR ACCOUNT</a>
            </p>
        </div>
    </div>
    
    </asp:Content>
