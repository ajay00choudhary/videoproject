using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace videoproject
{
    class customer_class
    {
        public DataSet listcustomer()
        {
            con.Close();
            string str = connections();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Customer";
            adapter.SelectCommand = com;
            com.Connection = con;
            con.Open();
            adapter.Fill(d);
            return (d);
        }
        public bool addcustomer(string fname, string lname, string address, string phone)
        {
            con.Close();
            string str = connections();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Customer (FirstName,LastName,Address,Phone)values('"+fname +"','"+lname+"','"+address+"','"+phone+"')";
            adapter.InsertCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery(); 
            return (true);
        }
        //function to update customer 
        public bool updatecustomer(string custid, string fname, string lname, string address, string phone)
        {
            con.Close();
            string str = connections();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "update Customer set FirstName='" + fname + "',LastName='" + lname + "',Address='" + address + "',Phone='" + phone + "' where CustID=" + custid;

            adapter.UpdateCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        //function to delete customer
        public bool deletecustomer(string custid)
        {
            con.Close();
            string str = connections();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from Customer where CustID=" + custid;

            adapter.DeleteCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        string connections()
        {
            //Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "C:\Users\00kum\OneDrive\Desktop\New folder\videoproject\videoproject\video_database.mdf"; Integrated Security = True; Connect Timeout = 30
           string str=Application.StartupPath.ToString().Substring(0,Application.StartupPath.ToString().IndexOf("bin"));
           return (@"Data Source = (LocalDB)\MSSQLLocalDB;;AttachDbFilename=" + str + "video_database.mdf;Integrated Security=True; Connect Timeout = 30");
        }
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        DataSet d = new DataSet();
    }
}
