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
    public partial class CustomerUI : System.Web.UI.Page
    {
        CustomerManager customerManager=new CustomerManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string customerName = inputCustomerName.Value;
            string email = inputEmail.Value;
            string accountNo = inputAccountNo.Value;
            string openingDate = inputDate.Value;
            double balance = 0.0;

            Customer customer=new Customer();
            customer.Name = customerName;
            customer.Email = email;
            customer.AccNo = accountNo;
            customer.OpeningDate = openingDate;
            customer.Balance = balance;

            lblShow.InnerText = customerManager.SaveCustomer(customer);
        }
    }
}