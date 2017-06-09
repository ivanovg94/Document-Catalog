<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewDocument.aspx.cs" Inherits="DocCat.Views.NewDocument" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




    <h2>Запазване на нов документ</h2>
    <div class="container">
        <div class="col-md-6 ">
            <h3>Данни на документа</h3>

            <div class="form-horizontal">
                <fieldset>
                    <div class="form-group">
                        <label class="col-lg-3 control-label">Име на документ</label>
                        <div class="col-lg-6">
                            <asp:TextBox ID="DocNameTb" CssClass="form-control" placeholder="Име на документа" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-lg-3 control-label">Вид документ</label>
                        <div class="col-lg-6">
                            <asp:DropDownList ID="DocTypeDdl" CssClass="form-control" runat="server"></asp:DropDownList>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-lg-3 control-label">Описание</label>
                        <div class="col-lg-6">
                            <asp:TextBox ID="DocDescrTb" CssClass="form-control" placeholder="Описание" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-lg-3 control-label">Дата на издаване</label>
                        <div class="col-lg-6">
                            <asp:Calendar ID="Calendar" runat="server"></asp:Calendar>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-lg-3 control-label">Издаден на</label>
                        <div class="col-lg-6">
                            <asp:TextBox ID="IssueToTb" CssClass="form-control" placeholder="Име на клиент" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-lg-3 control-label">Издаден от</label>
                        <div class="col-lg-6">
                            <asp:DropDownList ID="IsueByDdl" CssClass="form-control" placeholder="Име на организация" runat="server"></asp:DropDownList>
                        </div>
                    </div>

                    <h4>Дигитално копие</h4>

                    <div class="form-group">
                        <label class="col-lg-3 control-label">Сървър</label>
                        <div class="col-lg-6">
                            <asp:TextBox ID="ServerNameTb" CssClass="form-control" placeholder="Име на сървър" runat="server"></asp:TextBox>
                            <asp:FileUpload ID="FileUpload" runat="server" />

                            </div>
                    </div>



                </fieldset>
            </div>
        </div>

        <div class="col-md-6 ">
            <h3>Локация</h3>



            <div class="form-horizontal">
                <fieldset>
                    <div class="form-group">
                        <label class="col-lg-3 control-label">Начин на съхранение</label>
                        <div class="col-lg-6">
                            <asp:DropDownList ID="SaveTypeDdl" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="SaveTypeDdl_SelectedIndexChanged" runat="server"></asp:DropDownList>
                        </div>
                    </div>

                    <hr />

                    <asp:Panel ID="LocationDetails" Visible="false" runat="server">
                        <h4>Физическа локация</h4>
                        <div class="form-group">
                            <label class="col-lg-3 control-label">Име на склад</label>
                            <div class="col-lg-6">
                                <div class="col-lg-10">
                                    <asp:DropDownList ID="WhDdl" CssClass="form-control" AutoPostBack="true" runat="server" OnSelectedIndexChanged="WhDdl_SelectedIndexChanged"></asp:DropDownList>
                                </div>
                                <div class="col-lg-2 control-label">
                                    <asp:Label ID="WhCurrentCapL" CssClass="control-label" runat="server" Text="00"></asp:Label>/<asp:Label ID="WhMaxCapL" CssClass="control-label" runat="server" Text="00"></asp:Label>
                                </div>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-lg-3 control-label">Номер на стелаж</label>
                            <div class="col-lg-6">
                                <div class="col-lg-10">
                                    <asp:DropDownList ID="ShDdl" CssClass="form-control" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ShDdl_SelectedIndexChanged"></asp:DropDownList>
                                </div>
                                <div class="col-lg-2 control-label">
                                    <asp:Label ID="ShCurrentCapL" CssClass="control-label" runat="server" Text="00"></asp:Label>/<asp:Label ID="ShMaxCapL" CssClass="control-label" runat="server" Text="00"></asp:Label>
                                </div>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-lg-3 control-label">Номер на ред</label>
                            <div class="col-lg-6">
                                <div class="col-lg-10">
                                    <asp:DropDownList ID="RowDdl" CssClass="form-control" AutoPostBack="true" runat="server" OnSelectedIndexChanged="RowDdl_SelectedIndexChanged"></asp:DropDownList>
                                </div>
                                <div class="col-lg-2 control-label">
                                    <asp:Label ID="RowCurrentCapL" CssClass="control-label" runat="server" Text="00"></asp:Label>/<asp:Label ID="RowMaxCapL" CssClass="control-label" runat="server" Text="00"></asp:Label>
                                </div>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-lg-3 control-label">Номер на кутия</label>
                            <div class="col-lg-6">
                                <div class="col-lg-10">
                                    <asp:DropDownList ID="BoxDdl" CssClass="form-control" AutoPostBack="true" runat="server" OnSelectedIndexChanged="BoxDdl_SelectedIndexChanged"></asp:DropDownList>
                                </div>
                                <div class="col-lg-2 control-label">
                                    <asp:Label ID="BoxCurrentCapL" CssClass="control-label" runat="server" Text="00"></asp:Label>/<asp:Label ID="BoxMaxCapL" CssClass="control-label" runat="server" Text="00"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <hr />
                    </asp:Panel>

                    <div class="form-group">
                        <div class="col-sm-4 col-sm-offset-4">
                            <asp:Button ID="CancelBtn" runat="server" Text="Cancel" CssClass="btn btn-default" />
                            <asp:Button ID="SaveBtn" runat="server" Text="Save" CssClass="btn btn-success" OnClick="SaveBtn_Click" />
                        </div>
                    </div>
                </fieldset>
            </div>
        </div>
    </div>
</asp:Content>
