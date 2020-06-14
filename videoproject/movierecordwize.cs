using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace videoproject
{
    public partial class movierecordwize : Form
    {
        DataSet d;
        //declaring movie class object
        movies_class f = new movies_class();
        int i = 0;
        public movierecordwize()
        {
            InitializeComponent();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            //exiting the current frame
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //accessing all the movies
            d = f.allmovies();
            //showing the data in text fields
            movieidtxt.Text = d.Tables[0].Rows[i][0].ToString();
            ratingtxt.Text = d.Tables[0].Rows[i][1].ToString();
            titletxt.Text = d.Tables[0].Rows[i][2].ToString();
            yeartxt.Text = d.Tables[0].Rows[i][3].ToString();
            rentalcosttxt.Text = d.Tables[0].Rows[i][4].ToString();
            copiestxt.Text = d.Tables[0].Rows[i][5].ToString();
            plottxt.Text = d.Tables[0].Rows[i][6].ToString();
            genretxt.Text = d.Tables[0].Rows[i][7].ToString();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //increment the row counter
            i++;
            //showing the movie data in text fields
            movieidtxt.Text = d.Tables[0].Rows[i][0].ToString();
            ratingtxt.Text = d.Tables[0].Rows[i][1].ToString();
            titletxt.Text = d.Tables[0].Rows[i][2].ToString();
            yeartxt.Text = d.Tables[0].Rows[i][3].ToString();
            rentalcosttxt.Text = d.Tables[0].Rows[i][4].ToString();
            copiestxt.Text = d.Tables[0].Rows[i][5].ToString();
            plottxt.Text = d.Tables[0].Rows[i][6].ToString();
            genretxt.Text = d.Tables[0].Rows[i][7].ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //decrement the row counter
            i--;
            //showing the movie data
            movieidtxt.Text = d.Tables[0].Rows[i][0].ToString();
            ratingtxt.Text = d.Tables[0].Rows[i][1].ToString();
            titletxt.Text = d.Tables[0].Rows[i][2].ToString();
            yeartxt.Text = d.Tables[0].Rows[i][3].ToString();
            rentalcosttxt.Text = d.Tables[0].Rows[i][4].ToString();
            copiestxt.Text = d.Tables[0].Rows[i][5].ToString();
            plottxt.Text = d.Tables[0].Rows[i][6].ToString();
            genretxt.Text = d.Tables[0].Rows[i][7].ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //inserting new movie 
            bool g = f.insertnewmovie(movieidtxt.Text, ratingtxt.Text, titletxt.Text, yeartxt.Text, copiestxt.Text, plottxt.Text, genretxt.Text);
            if (g == true)
            {
                MessageBox.Show("New Movie Added");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool g = f.deletemovie(movieidtxt.Text);
            if (g == true)
            {
                MessageBox.Show("Movie Deleted");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool g = f.updatemovie(movieidtxt.Text, ratingtxt.Text, titletxt.Text, yeartxt.Text, copiestxt.Text, plottxt.Text, genretxt.Text);
            if (g == true)
            {
                MessageBox.Show("Movie Deleted");
            }
        }
    }
}
