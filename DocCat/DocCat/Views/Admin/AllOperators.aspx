<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllOperators.aspx.cs" Inherits="DocCat.Views.Admin.AllOperators" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h3>Всички Оператори</h3>
    <div class="clear"></div>
    <asp:GridView ID="OperatorsGV"
        runat="server"
        CssClass="table table-striped table-bordered table-condensed table-hover"
        ItemType="DocCat.ViewModels.OperatorsVM"
        AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Клиент" />
            <asp:BoundField DataField="SavedDocumentsCount" HeaderText="Брой обработени документи" />
        </Columns>
    </asp:GridView>

</asp:Content>
