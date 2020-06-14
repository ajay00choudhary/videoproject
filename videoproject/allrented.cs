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
    public partial class allrented : Form
    {
        public allrented()
        {
            InitializeComponent();
        }

        private void allrented_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'video_databaseDataSet1.RentedMovies' table. You can move, or remove it, as needed.
            this.rentedMoviesTableAdapter.Fill(this.video_databaseDataSet1.RentedMovies);

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            //disposing the form
            this.Dispose();
        }
    }
}
