<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewDocType.aspx.cs" Inherits="DocCat.Views.Admin.NewDocType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Нов тип документ</h2>
    <div class="clear"></div>
    <div class="container">
        <div <%--class="row"--%>>
            <div class="col-md-8 ">

                <div class="form-horizontal">
                    <fieldset>
                        <div class="form-group">
                            <label class="col-lg-3 control-label">Наименование на типа</label>
                            <div class="col-lg-6">
                                <asp:TextBox ID="DocTypeNameTb" CssClass="form-control" placeholder="Име на типа" runat="server" ></asp:TextBox>
                            </div>
                            <asp:Label ID="resultLbl" Visible="false" runat="server" Text="Вече съществува!"></asp:Label>
                        </div>

                        <div class="form-group">
                            <div class="col-sm-4 col-sm-offset-4">
                                <asp:Button ID="CancelBtn" runat="server" Text="Cancel" CssClass="btn btn-default" OnClick="CancelBtn_Click" />
                                <asp:Button ID="SaveBtn" runat="server" Text="Save" CssClass="btn btn-success" OnClick="SaveBtn_Click" />
                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>

    </div>


</asp:Content>
