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
    public partial class rentedout : Form
    {
        public rentedout()
        {
            InitializeComponent();
        }

        private void rentedout_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'video_databaseDataSet2.RentedMovies' table. You can move, or remove it, as needed.
            this.rentedMoviesTableAdapter.Fill(this.video_databaseDataSet2.RentedMovies);

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            //exiting the current form
            this.Dispose();
        }
    }
}
