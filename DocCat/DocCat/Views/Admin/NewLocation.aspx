<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewLocation.aspx.cs" Inherits="DocCat.Views.Admin.NewLocation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>New Warehouse</h2>
    <div class="clear"></div>
    <div class="container">
        <div <%--class="row"--%>>
            <div class="col-md-8 ">

                <div class="form-horizontal">
                    <fieldset>
                        <div class="form-group">
                            <label class="col-lg-3 control-label">Име на склад</label>
                            <div class="col-lg-6">
                                <asp:TextBox ID="WarehouseNameTb" CssClass="form-control" placeholder="Име" runat="server"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-lg-3 control-label">Капацитет на склад</label>
                            <div class="col-lg-6">
                                <asp:TextBox ID="WhCapTb" CssClass="form-control" placeholder="Капацитет" runat="server"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-lg-3 control-label">Капацитет на стелаж</label>
                            <div class="col-lg-6">
                                <asp:TextBox ID="ShCapTb" CssClass="form-control" placeholder="Капацитет" runat="server"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-lg-3 control-label">Капацитет на ред</label>
                            <div class="col-lg-6">
                                <asp:TextBox ID="RowCapTb" CssClass="form-control" placeholder="Капацитет" runat="server"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-lg-3 control-label">Капацитет на кутия</label>
                            <div class="col-lg-6">
                                <asp:TextBox ID="BoxCapTb" CssClass="form-control" placeholder="Капацитет" runat="server"></asp:TextBox>
                            </div>
                        </div>


                        <div class="form-group">
                            <div class="col-sm-4 col-sm-offset-4">
                                <asp:Button ID="CancelBtn" runat="server" Text="Cancel" CssClass="btn btn-default" />
                                <asp:Button ID="SaveBtn" runat="server" Text="Save" CssClass="btn btn-success" OnClick="SaveBtn_Click"/>
                            </div>
                        </div>


                    </fieldset>
                </div>
            </div>
        </div>

    </div>


</asp:Content>
