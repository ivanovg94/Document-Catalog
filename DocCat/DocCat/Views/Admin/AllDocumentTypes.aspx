<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllDocumentTypes.aspx.cs" Inherits="DocCat.Views.Admin.AllDocumentTypes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Всички Локации</h3>
    <div class="clear"></div>
    <asp:GridView ID="LocationGV"
        runat="server"
        CssClass="table table-striped table-bordered table-condensed table-hover"
        ItemType="DocCat.ViewModels.DocumentTypesVM"
        AutoGenerateColumns="false">

        <Columns>
            <asp:BoundField DataField="TypeName" HeaderText="Тип" />
            <asp:BoundField DataField="DocumentsCount" HeaderText="Брой документи от този тип" />
        </Columns>
    </asp:GridView>

</asp:Content>
