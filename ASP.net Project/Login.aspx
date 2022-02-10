<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASP.net_Project.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container">
        <div class="login-card">
            <div class="modal-title " style="color: white;">LOGIN</div>

            <div class="input-box">
                <label style="color: white;">Username</label>
                <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>

            </div>
            <div class="input-box">
                <label style="color: white;">Password</label>
                <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="submit-btn ">
                <asp:Button ID="ButtonLogin" class="btn btn-success" OnClick="ButtonLogin_Click" runat="server" Text="Login" />
                <asp:Label ID="LabelMessage" runat="server" Text="" ForeColor="#CC99FF" Font-Size="Small"></asp:Label>
            </div>

        </div>
    </div>
    <style>
        .container {
            height: auto 10px;
        }

        .login-card {
            border: 1px solid black;
            border-radius: 10px;
            box-shadow: 10px 10px 5px grey;
            background-color: #101010;
            margin: 100px;
            padding: 50px 150px;
            width: 500px;
            margin-left: 300px;
        }

        .input-box {
            margin-top: 10px;
        }

        .submit-btn {
            margin-top: 10px;
        }
    </style>
</asp:Content>
