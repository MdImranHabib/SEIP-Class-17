<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TransactionUI.aspx.cs" Inherits="BankAccountInfoApp.UI.TransactionUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h2 class="alert bg-primary text-center">Transaction</h2>
        <hr />
        <label id="lblShow" runat="server" class="col-md-offset-5 text-center text-success"></label>
        <br />
        <br />
        <div class="row">
            <div class="col-md-8 col-md-offset-2">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-md-4 control-label">Account No :</label>
                        <input id="inputAccNo" runat="server" class="col-md-6 form-control" />
                    </div>
                    <div class="form-group">
                        <label class="col-md-4 control-label">Amount :</label>
                        <input id="inputAmount" runat="server" class="col-md-6 form-control" />
                    </div>
                    <div class="col-md-offset-4">
                        <asp:Button ID="btnDeposit" runat="server" BackColor="#009933" ForeColor="White" OnClick="btnDeposit_Click" Text="Deposit" BorderColor="#33CC33" Height="28px" Width="66px" />
                        &nbsp;
                        <asp:Button ID="btnWithdraw" runat="server" BackColor="#FF9900" ForeColor="White" OnClick="btnWithdraw_Click" Text="Withdraw" BorderColor="#FFCC00" Height="28px" Width="71px" />
                    </div>             
                </div>
            </div>
        </div>
    </div>
</asp:Content>
