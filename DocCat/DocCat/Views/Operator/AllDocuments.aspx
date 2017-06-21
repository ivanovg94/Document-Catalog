<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllDocuments.aspx.cs" Inherits="DocCat.Views.Operator.AllDocuments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Всички въведени документи</h3>
    <div class="clear"></div>
    <asp:GridView ID="DocumentsGV"
        runat="server"
        CssClass="table table-striped table-bordered table-condensed table-hover"
        OnRowDataBound="DocumentsGV_RowDataBound"
        OnRowCommand="Grid_RowCommand"
        ItemType="DocCat.ViewModels.OperatorDocsVM"
        AutoGenerateColumns="false">


        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="Име" />
            <asp:BoundField DataField="Type" HeaderText="Тип" />
            <asp:BoundField DataField="IssueBy" HeaderText="Издаден от" />
            <asp:BoundField DataField="Status" HeaderText="Статус" />

            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="btnDetails" runat="server" Text="Детайли" CommandName="Details"
                        CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                </ItemTemplate>
            </asp:TemplateField>
            <%--  <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="btnApprove" runat="server" Text="Одобри заявка" CommandName="Approve"
                        CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                </ItemTemplate>
            </asp:TemplateField>--%>
        </Columns>
    </asp:GridView>


</asp:Content>
