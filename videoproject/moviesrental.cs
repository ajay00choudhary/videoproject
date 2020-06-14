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
    public partial class moviesrental : Form
    {
        public moviesrental()
        {
            InitializeComponent();
        }

        private void AllRentbtn_Click(object sender, EventArgs e)
        {
            //declaring the object
            allrented f = new allrented();
            //showing the form
            f.Show();
        }

        private void rentedoutbtn_Click(object sender, EventArgs e)
        {
            //declaring the object of return movie
            rentedout f = new rentedout();
            //showing the form
            f.Show();
            
        }

        private void Issuemoviebtn_Click(object sender, EventArgs e)
        {
            //declaring the object of the issue movie class
            issuemovie f = new issuemovie();
            //showing the form
            f.Show();
        }

        private void returnmoviebtn_Click(object sender, EventArgs e)
        {
            //declaring the object of the return movie form
            returnmovie f = new returnmovie();
            //showing the form
            f.Show();
        }
    }
}
