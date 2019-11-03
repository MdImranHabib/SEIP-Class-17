using BankAccountInfoApp.BLL;
using BankAccountInfoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankAccountInfoApp.UI
{
    public partial class SearchCustomerInfoUI : System.Web.UI.Page
    {
        CustomerManager customerManager = new CustomerManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string accountNo = inputAccNo.Value;

            gridCustomersAccInfo.DataSource = customerManager.ShowCustomers(accountNo);
            gridCustomersAccInfo.DataBind();
        }
    }
}