<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllLocations.aspx.cs" Inherits="DocCat.Views.Admin.AllLocations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Всички Локации</h3>
    <div class="clear"></div>
    <asp:GridView ID="LocationGV"
        runat="server"
        CssClass="table table-striped table-bordered table-condensed table-hover"
        ItemType="DocCat.ViewModels.LocationsVM"
        AutoGenerateColumns="false">

        <Columns>
            <asp:BoundField DataField="WhName" HeaderText="Име на склад" />
            <asp:BoundField DataField="CurrentCap" HeaderText="Документи" />
            <asp:BoundField DataField="MaxCap" HeaderText="Капацитет" />
        </Columns>
    </asp:GridView>


</asp:Content>
