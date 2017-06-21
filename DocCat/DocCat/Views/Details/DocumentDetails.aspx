<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DocumentDetails.aspx.cs" Inherits="DocCat.Views.Details.DocumentDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Детайли за                
            <asp:Label ID="CurrentDocNameL" runat="server" Text=""></asp:Label>
    </h4>
    <div class="col-lg-12">

        <div class="col-lg-6 ">
            <div class="panel panel-default">
                <div class="panel-heading">
                    Основна информация
                </div>
                <div class="panel-body">

                    <div class="row">
                        <label class="col-lg-6 control-label">Тип</label>
                        <div class="col-lg-6">
                            <div class="pull-right">
                                <asp:Label ID="TypeL" runat="server" Text="1"></asp:Label>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <label class="col-lg-6 control-label">Издаден на</label>
                        <div class="col-lg-6">
                            <div class="pull-right">
                                <asp:Label ID="IssuedToL" runat="server" Text="1"></asp:Label>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <label class="col-lg-6 control-label">Издаден от</label>
                        <div class="col-lg-6">
                            <div class="pull-right">
                                <asp:Label ID="IssuedByL" runat="server" Text="1"></asp:Label>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <label class="col-lg-6 control-label">Обработен от</label>
                        <div class="col-lg-6">
                            <div class="pull-right">
                                <asp:Label ID="SavedByL" runat="server" Text="1"></asp:Label>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <label class="col-lg-6 control-label">Дата</label>
                        <div class="col-lg-6">
                            <div class="pull-right">
                                <asp:Label ID="DateL" runat="server" Text="1"></asp:Label>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <label class="col-lg-6 control-label">Статус</label>
                        <div class="col-lg-6">
                            <div class="pull-right">
                                <asp:Label ID="RequestStatusL" runat="server" Text="1"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="col-lg-6 ">
            <div class="panel panel-default">
                <div class="panel-heading">
                    Локация
                </div>
                <div class="panel-body">

                    <div class="row">
                        <label class="col-lg-6 control-label">Склад</label>
                        <div class="col-lg-6">
                            <div class="pull-right">
                                <asp:Label ID="StorageL" runat="server" Text="1"></asp:Label>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <label class="col-lg-6 control-label">Стелаж</label>
                        <div class="col-lg-6">
                            <div class="pull-right">
                                <asp:Label ID="ShelfL" runat="server" Text="1"></asp:Label>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <label class="col-lg-6 control-label">Ред</label>
                        <div class="col-lg-6">
                            <div class="pull-right">
                                <asp:Label ID="RowL" runat="server" Text="1"></asp:Label>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <label class="col-lg-6 control-label">Кутия</label>
                        <div class="col-lg-6">
                            <div class="pull-right">
                                <asp:Label ID="BoxL" runat="server" Text="1"></asp:Label>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <label class="col-lg-6 control-label">Дигитален път</label>
                        <div class="col-lg-6">
                            <div class="pull-right">
                                <asp:Label ID="DigithalPath" runat="server" Text="1"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="col-lg-12">
        <div class="panel panel-default">
            <div class="panel-heading">
                Описание
            </div>
            <div class="panel-body">
                <asp:Label ID="DescriptionL" runat="server" Text="1"></asp:Label>
            </div>
        </div>
    </div>
    <div class="col-lg-6">
        <div class="pull-right">
            <asp:Button ID="DownloadBtn" CssClass="btn btn-default" runat="server" Text="Изтегли" />
            <asp:Button ID="RequestBtn" runat="server" CssClass="btn btn-default" Text="Заяви" OnClick="RequestBtn_Click" />
            <asp:Button ID="ApproveBtn" runat="server" CssClass="btn btn-default" Text="Одобри" OnClick="Approve_Click"  />
        </div>
    </div>

</asp:Content>
