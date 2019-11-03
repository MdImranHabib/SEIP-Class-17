using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankAccountInfoApp.DAL;
using BankAccountInfoApp.Models;
using Microsoft.Ajax.Utilities;

namespace BankAccountInfoApp.BLL
{
    public class CustomerManager
    {
        CustomerGateway gateway = new CustomerGateway();

        List<Customer> customerList = new List<Customer>();

        public string SaveCustomer(Customer customer)
        {
            if (customer.AccNo.Length >= 8)
            {
                string accountNo = customer.AccNo;
                bool isAccNoExist = CheckAccNo(accountNo);

                if(customer.Name.Length > 0)
                {
                    if (isAccNoExist)
                    {
                        return "This Account No. is already exist! Please use another Account No.";
                    }
                    else
                    {
                        var rowAffected = gateway.AddCustomer(customer);

                        if (rowAffected > 0)
                        {
                            return "Saved Successfully!";
                        }
                        else
                        {
                            return "Save Failed!";
                        }
                    }
                }
                else
                {
                    return "Customer Name can not be null";
                }
            }
            else
            {
                return "Invalid Account No.! it must be at least 8 characters.";
            }
        }


        public List<Customer> ShowCustomers(string accountNo)
        {
            if(accountNo.IsNullOrWhiteSpace())
            {
                return gateway.GetCustomers();
            }
            else
            {
                return gateway.GetSpecificCustomer(accountNo);
            }       
        }


        public string DepositTransaction(Customer customer)
        {
            if (customer.Balance >= 0)
            {
                string accountNo = customer.AccNo;
                bool isAccNoExist = CheckAccNo(accountNo);

                if (isAccNoExist)
                {
                    var rowAffected = gateway.UpdateDeposit(customer);

                    if (rowAffected > 0)
                    {
                        return "Deposit Successfully!";
                    }
                    else
                    {
                        return "Deposit Failed!";
                    }
                }
                else
                {
                    return "This Account doesn't exist!";
                }
            }
            else
            {
                return "Deposite amount can't be less than 0";
            }
        }


        public string WithdrawTransaction(Customer customer)
        {
            string accountNo = customer.AccNo;
            bool isAccNoExist = CheckAccNo(accountNo);

            if (isAccNoExist)
            {
                Customer aCustomer = gateway.GetExistAccount(customer);
                double balance = aCustomer.Balance;

                if (customer.Balance <= balance)
                {
                    var rowAffected = gateway.UpdateWithdraw(customer);

                    if (rowAffected > 0)
                    {
                        return "Withdraw Successfully!";
                    }
                    else
                    {
                        return "Withdraw Failed!";
                    }
                }
                else
                {
                    return "Insufficient Balance";
                }
            }
            else
            {
                return "This Account doesn't exist!";
            }
        }


        private bool CheckAccNo(string accountNo)
        {
            bool status = false;

            customerList = gateway.GetCustomers();

            foreach (var aCustomer in customerList)
            {
                if (aCustomer.AccNo.Contains(accountNo))
                {
                    status = true;
                    break;
                }
                else
                {
                    status = false;
                }
            }

            return status;
        }
    }
}