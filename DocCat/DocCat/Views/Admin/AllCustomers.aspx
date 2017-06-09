<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllCustomers.aspx.cs" Inherits="DocCat.Views.Admin.AllCustomers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Всички Клиенти</h3>
    <div class="clear"></div>
    <asp:GridView ID="ClientsGV"
        runat="server"
        CssClass="table table-striped table-bordered table-condensed table-hover"
        ItemType="DocCat.ViewModels.CustomersVM"
        AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Клиент" />
            <asp:BoundField DataField="Bulstat" HeaderText="Булстат" />
            <asp:BoundField DataField="Address" HeaderText="Адрес" />
            <asp:BoundField DataField="Phone" HeaderText="Телефон" />
            <asp:BoundField DataField="DocumentCount" HeaderText="Брой документи" />
        </Columns>
    </asp:GridView>

</asp:Content>
