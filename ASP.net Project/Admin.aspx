<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="ASP.net_Project.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="whole-input">
        <h4 style="text-align: center; margin-top: 30px; padding-left:60px; color:white;">Admin Panel</h4><br />
        <div class="row">
            <asp:Label ID="LabelDefaultaText1" runat="server" Text="Default Text 1" for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg" ForeColor="#CCCCCC"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="TextBoxDefaultText1" placeholder="Default Text 1" type="text" class="form-control form-control-lg" runat="server"></asp:TextBox>
            </div>
        </div>
        <br />

        <div class="row">
            <asp:Label ID="LabelDefaultText2" for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg" runat="server" Text="Default Text 2" ForeColor="#CCCCCC"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="TextBoxDefaultText2" type="text" class="form-control form-control-lg" placeholder="Default Text 2" runat="server"></asp:TextBox>
            </div>
        </div>
        <br />

        <div class="row">
            <asp:Label ID="LabelHeaderText" for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg" runat="server" Text="Header Text" ForeColor="#CCCCCC"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="TextBoxHeaderText" type="text" class="form-control form-control-lg" placeholder="Header Text" runat="server"></asp:TextBox>
            </div>
        </div>
        <br />

        <div class="row">
            <asp:Label ID="LabelFooterText" runat="server" Text="Footer Text" for="colFormLabelLg" class="col-sm-2 col-form-label col-form-label-lg" ForeColor="#CCCCCC"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="TextBoxFooterText" runat="server" type="text" class="form-control form-control-lg" placeholder="Footer Text"></asp:TextBox><br />
            </div>
            <div class="d-grid gap-2 col-6 mx-auto">
                <asp:Button ID="ButtonSaveSettings" type="button" class="btn btn-primary" runat="server" Text="Save Settings" OnClick="ButtonSaveSettings_Click" />
            </div>
        </div>
    </div>

    <style>
        .row {
        
            
        }
        .whole-input {
            margin: 20px;
            margin-left:150px;
            background-color: #101010;
            margin-right:250px;
            padding-left: 200px;
            border:2px solid black;
            border-radius:10px;
             box-shadow: 10px 10px 5px grey;
            width: 870px;
            height:fit-content ;
        }

        .form-control {
            
        }

        .col-sm-2 {
            margin-top: 3px;
        }

        .d-grid {
            margin-left: 100px;
        }
        h4 {
            padding-right:400px;
        }
        .mx-auto {
            padding-bottom: 20px;
            padding-left:30px;
        }
    </style>
</asp:Content>
