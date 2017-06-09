<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyDocuments.aspx.cs" Inherits="DocCat.Views.Customer.MyDocuments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:GridView ID="DocumentsGV"
        runat="server"
        CssClass="table table-striped table-bordered table-condensed table-hover"
        OnRowDataBound="DocumentsGV_RowDataBound"
        ItemType="DocCat.ViewModels.CustomerDocsVM"
        AutoGenerateColumns="false">


        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="Име" />
            <asp:BoundField DataField="Type" HeaderText="Тип" />
            <asp:BoundField DataField="IssueTo" HeaderText="Издаден на" />
            <asp:BoundField DataField="Date" HeaderText="Дата на издаване" />
            <asp:BoundField DataField="ShortDescription" HeaderText="Описание" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="btnDetails" runat="server" Text="Детайли" CommandName="Details"
                        CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="btnRequest" runat="server" Text="Заяви" CommandName="Request"
                        CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="btnDownload" runat="server" Text="Изтегли" CommandName="Download"
                        CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>




</asp:Content>
