<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchCustomerInfoUI.aspx.cs" Inherits="BankAccountInfoApp.UI.SearchCustomerInfoUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h2 class="alert bg-primary text-center">Search Customer and Account Info</h2>
        <hr />
        <div class="row">
            <div class="col-md-8 col-md-offset-2">
                <div class="form-horizontal">
                    <div class="form-inline">
                        <label class="col-md-4 control-label">Account No :</label>
                        <input id="inputAccNo" runat="server" class="col-md-6 form-control" />
                    </div>                  
                    <div class="col-md-offset-4">
                        &nbsp;
                        <asp:Button ID="btnSearch" runat="server" BackColor="#009933" ForeColor="White" OnClick="btnSearch_Click" Text="Search" BorderColor="#33CC33" Height="31px" Width="66px" />
                    </div>             
                </div>
            </div>
        </div>
        <br />
        <asp:GridView ID="gridCustomersAccInfo" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" CellPadding="15" CellSpacing="2" Font-Size="Medium" ForeColor="#333333" GridLines="None" Height="196px" Width="748px">
             <AlternatingRowStyle BackColor="White" />
             <Columns>
                 <asp:TemplateField HeaderText="Account Number">
                     <ItemTemplate>
                         <%#Eval("AccNo") %>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Customer Name">
                     <ItemTemplate>
                         <%#Eval("Name") %>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Opening Date">
                     <ItemTemplate>
                         <%#Eval("OpeningDate") %>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Balance">
                     <ItemTemplate>
                         <%#Eval("Balance") %>
                     </ItemTemplate>
                 </asp:TemplateField>
             </Columns>
             <EditRowStyle BackColor="#7C6F57" />
             <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
             <RowStyle BackColor="#E3EAEB" />
             <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
             <SortedAscendingCellStyle BackColor="#F8FAFA" />
             <SortedAscendingHeaderStyle BackColor="#246B61" />
             <SortedDescendingCellStyle BackColor="#D4DFE1" />
             <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </div>
    
</asp:Content>
