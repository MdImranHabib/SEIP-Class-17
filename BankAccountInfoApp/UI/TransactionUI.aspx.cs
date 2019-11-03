using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankAccountInfoApp.BLL;
using BankAccountInfoApp.Models;

namespace BankAccountInfoApp.UI
{
    public partial class TransactionUI : System.Web.UI.Page
    {
        CustomerManager customerManager =new CustomerManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            string accountNo = inputAccNo.Value;
            double amount = Convert.ToDouble(inputAmount.Value);

            Customer customer =new Customer();
            customer.AccNo = accountNo;
            customer.Balance = amount;

            lblShow.InnerText = customerManager.DepositTransaction(customer);
        }

        protected void btnWithdraw_Click(object sender, EventArgs e)
        {
            string accountNo = inputAccNo.Value;
            double amount = Convert.ToDouble(inputAmount.Value);

            Customer customer = new Customer();
            customer.AccNo = accountNo;
            customer.Balance = amount;

            lblShow.InnerText = customerManager.WithdrawTransaction(customer);
        }
    }
}