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
    class issuemovie_class
    {
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        DataSet d = new DataSet();


        //function to issue movie
        public bool issuemovie(string movieid, string custid, string daterented)
        {
            con.Close();
            string str = connections();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into RentedMovies (MovieIDFK,CustIDFK,DateRented)values(" + movieid + "," + custid + ",'" + daterented + "')";

            adap.InsertCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        //function to return movie
        public bool returnmovie(string rmid, string returndate)
        {
            con.Close();
            string str = connections();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "update RentedMovies set DateReturned='" + returndate + "' where RMID=" + rmid;

            adap.UpdateCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        //function to show current
        public DataSet showcurrent()
        {
            string str = connections();
            con.Close();
            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Movies where year='2019'";
            adap.SelectCommand = com;
            com.Connection = con;
            con.Open();
            adap.Fill(d);
            return (d);
        }
        //function to show most popular
        public DataSet mostpopular()
        {
            string str = connections();
            con.Close();
            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Movies where  MovieID in (select MovieIDFK from RentedMovies)";
            adap.SelectCommand = com;
            com.Connection = con;
            con.Open();
            adap.Fill(d);
            return (d);
        }
        string connections()
        {
            string str = Application.StartupPath.ToString().Substring(0, Application.StartupPath.ToString().IndexOf("bin"));
            return (@"Data Source = (LocalDB)\MSSQLLocalDB;;AttachDbFilename=" + str + "video_database.mdf;Integrated Security=True; Connect Timeout = 30");
        }
    }
}
