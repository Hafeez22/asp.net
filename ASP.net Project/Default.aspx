<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.net_Project.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Noto+Sans&display=swap" rel="stylesheet">
    <div class="total-default">
        <div class="default-1">
            <p class="text-center">
                <asp:Label ID="LabelDefaultText1" runat="server" Text="Default Text 1"></asp:Label></p>
        </div>
        <div class="default-2">
            <p class="text-lg-start text-center">
                <asp:Label ID="LabelDefaultText2" runat="server" Text="Default Text 2"></asp:Label></p>
        </div>
    </div>

    <style>
        .total-default {
            border:1px solid black;
            margin:50px;
        }
        .default-1 {
            border:1px solid black;
            font-size:30px;
            font-family: 'Noto Sans', sans-serif;
        }
        .default-2 {
            margin:10px;
            font-size:40px;
            border:1px solid black;
            font-family: 'Noto Sans', sans-serif;
        }
    </style>
</asp:Content>
