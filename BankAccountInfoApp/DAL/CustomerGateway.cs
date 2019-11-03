using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using BankAccountInfoApp.Models;

namespace BankAccountInfoApp.DAL
{
    public class CustomerGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["BankAccDB"].ConnectionString;

        public int AddCustomer(Customer customer)
        {
            string query = "INSERT INTO Customers Values('" + customer.Name + "','" + customer.Email + "','" +
                           customer.AccNo + "','" + customer.OpeningDate + "'," + customer.Balance + ")";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }


        public List<Customer> GetCustomers()
        {
            string query = "SELECT * from Customers";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Customer> customerList = new List<Customer>();

            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.Id = Convert.ToInt32(reader["Id"]);
                customer.Name = reader["Name"].ToString();
                customer.Email = reader["Email"].ToString();
                customer.AccNo = reader["AccNo"].ToString();
                customer.OpeningDate = reader["OpeningDate"].ToString();
                customer.Balance = Convert.ToDouble(reader["Balance"]);

                customerList.Add(customer);
            }

            reader.Close();
            connection.Close();

            return customerList;
        }


        public List<Customer> GetSpecificCustomer(string accountNo)
        {
            string query = "SELECT * FROM Customers WHERE AccNo='" + accountNo + "'";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Customer> customerList = new List<Customer>();

            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.Id = Convert.ToInt32(reader["Id"]);
                customer.Name = reader["Name"].ToString();
                customer.Email = reader["Email"].ToString();
                customer.AccNo = reader["AccNo"].ToString();
                customer.OpeningDate = reader["OpeningDate"].ToString();
                customer.Balance = Convert.ToDouble(reader["Balance"]);

                customerList.Add(customer);
            }

            reader.Close();
            connection.Close();

            return customerList;
        }


        public int UpdateDeposit(Customer customer)
        {
            Customer aCustomer = GetExistAccount(customer);
            var balance = aCustomer.Balance;

            string query = "UPDATE Customers SET Balance=" + (balance + customer.Balance) + "WHERE AccNo='" +
                           customer.AccNo + "'";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }


        public int UpdateWithdraw(Customer customer)
        {
            Customer aCustomer = GetExistAccount(customer);
            var balance = aCustomer.Balance;

            string query = "UPDATE Customers SET Balance=" + (balance - customer.Balance) + "WHERE AccNo='" +
                           customer.AccNo + "'";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }


        public Customer GetExistAccount(Customer customer)
        {
            string query = "SELECT * from Customers WHERE AccNo='" + customer.AccNo + "'";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Customer existCustomer = null;

            while (reader.Read())
            {
                existCustomer = new Customer();
                existCustomer.Id = Convert.ToInt32(reader["Id"]);
                existCustomer.Name = reader["Name"].ToString();
                existCustomer.Email = reader["Email"].ToString();
                existCustomer.AccNo = reader["AccNo"].ToString();
                existCustomer.OpeningDate = reader["OpeningDate"].ToString();
                existCustomer.Balance = Convert.ToDouble(reader["Balance"]);
            }

            reader.Close();
            connection.Close();

            return existCustomer;
        }
    }
}