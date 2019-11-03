<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerUI.aspx.cs" Inherits="BankAccountInfoApp.UI.CustomerUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    <h2 class="alert bg-primary text-center">Customer & Account Info Entry</h2>
    <hr />
    <label id="lblShow" runat="server" class="col-md-offset-5 text-center text-success"></label>
    <br />
    <br />
    <div class="row">
        <div class="col-md-8 col-md-offset-2">
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="col-md-4 control-label">Customer Name :</label>
                    <input id="inputCustomerName" runat="server" class="col-md-6 form-control" />
                </div>
                <div class="form-group">
                    <label class="col-md-4 control-label">Email :</label>
                    <input id="inputEmail" runat="server" class="col-md-6 form-control" />
                </div>
                <div class="form-group">
                    <label class="col-md-4 control-label">Account Number :</label>
                    <input id="inputAccountNo" runat="server" class="col-md-6 form-control" />
                </div>
                <div class="form-group">
                    <label class="col-md-4 control-label">Opening Date :</label>
                    <input id="inputDate" runat="server" class="col-md-6 form-control" />
                </div>
                <div class="col-md-offset-4">
                    <asp:Button ID="btnSave" runat="server" BackColor="#009933" ForeColor="White" OnClick="btnSave_Click" Text="Save" BorderColor="#33CC33" Height="28px" Width="66px" />
                </div>             
            </div>
        </div>
    </div>
</div>
</asp:Content>
