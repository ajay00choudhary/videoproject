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
    public partial class movieslist : Form
    {
        public movieslist()
        {
            InitializeComponent();
        }

        private void movieslist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'video_databaseDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.video_databaseDataSet.Movies);

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            //disposing the frame
            this.Dispose();
        }
    }
}
