using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace videoproject
{
    class movies_class
    {
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        DataSet d = new DataSet();
        public DataSet allmovies()
        {
            string str = connections();
            con.Close();
            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Movies";
            adap.SelectCommand = com;
            com.Connection = con;
            con.Open();
            adap.Fill(d);
            return (d);
        }
        public DataSet moviedata(string movieid)
        {
            string str = connections();
            con.Close();
            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Movies where movieid=" + movieid;
            adap.SelectCommand = com;
            com.Connection = con;
            con.Open();
            adap.Fill(d);
            return (d);
        }
        //function to update movie
        public bool updatemovie(string movieid, string rating, string title, string year, string copies, string plot, string genre)
        {
            con.Close();
            string str = connections();
            int year1 = Convert.ToInt16(year);
            string rent = "";
            if (2019 - year1 > 5)
            {
                rent = "2";
            }
            else
            {
                rent = "5";
            }

            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "update Movies set Rating='" + rating + "',Title='" + title + "',Year='" + year + "',Rental_Cost=" + rent + ",Copies='" + copies + "',Genre='" + genre + "' where MovieID=" + movieid;

            adap.UpdateCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        //function to delete movie
        public bool deletemovie(string movieid)
        {
            con.Close();
            string str = connections();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "delete Movies where MovieID=" + movieid;

            adap.DeleteCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        //insert new movie
        public bool insertnewmovie(string movieid, string rating, string title, string year, string copies, string plot, string genre)
        {
            con.Close();
            string str = connections();
            int year1 = Convert.ToInt16(year);
            string rent = "";
            if (2019 - year1 > 5)
            {
                rent = "2";
            }
            else
            {
                rent = "5";
            }

            con.ConnectionString = connections();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Movies values('" + rating + "','" + title + "','" + year + "'," + rent + ",'" + copies + "','" + plot + "','" + genre + "')";

            adap.InsertCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        public int getmaxmovieid()
        {
            string str = connections();
            con.Close();
            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "select max(MovieID) from Movies";
            adap.SelectCommand = com;
            com.Connection = con;
            con.Open();
            adap.Fill(d);
            int id = Convert.ToInt16(d.Tables[0].Rows[0][0]);
            return (id);
        }
        string connections()
        {
            string str = Application.StartupPath.ToString().Substring(0, Application.StartupPath.ToString().IndexOf("bin"));
            return (@"Data Source = (LocalDB)\MSSQLLocalDB;;AttachDbFilename=" + str + "video_database.mdf;Integrated Security=True; Connect Timeout = 30");
        }
    }
}
