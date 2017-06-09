<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DocCat.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2>Създаване на нов потребител</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="UserTypeDdl" CssClass="col-md-2 control-label">Тип потребител</asp:Label>
            <div class="col-lg-3">
                <asp:DropDownList ID="UserTypeDdl" CssClass="form-control" AutoPostBack="true" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="UserTypeDdl"
                    CssClass="text-danger" ErrorMessage="Задължително поле!" />
            </div>
        </div>

        <div  class="form-group">
            <asp:Label ID="NameLbl" runat="server" AssociatedControlID="NameTb" CssClass="col-md-2 control-label">x</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="NameTb" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="NameTb"
                    CssClass="text-danger" ErrorMessage="Задължително поле!" />
            </div>
        </div>
        <div runat="server" id="customerInfoDiv">
        <div class="form-group">
            <asp:Label ID="BulstatLbl" runat="server" AssociatedControlID="BulstatTb" CssClass="col-md-2 control-label">Булстат</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="BulstatTb" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="BulstatTb"
                    CssClass="text-danger" ErrorMessage="Задължително поле!" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="AddressLbl" runat="server" AssociatedControlID="AddressTb" CssClass="col-md-2 control-label">Адрес</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="AddressTb" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="AddressTb"
                    CssClass="text-danger" ErrorMessage="Задължително поле!" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="PhoneLbl" runat="server" AssociatedControlID="PhoneTb" CssClass="col-md-2 control-label">Телефон</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="PhoneTb" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="PhoneTb"
                    CssClass="text-danger" ErrorMessage="Задължително поле!" />
            </div>
        </div>
            </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="Задължително поле!" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Парола</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="Задължително поле!" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Въведете паролата отново</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="Задължително поле!" />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="Паролите не съвпадат!" />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
