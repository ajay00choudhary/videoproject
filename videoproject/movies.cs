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
    public partial class movies : Form
    {
        public movies()
        {
            InitializeComponent();
        }

        private void listmoviebtn_Click(object sender, EventArgs e)
        {
            //creating object of movie list class
            movieslist f = new movieslist();
           // showing  the form
            f.Show();
        }

        private void movierecordwizebtn_Click(object sender, EventArgs e)
        {
            //creating the object of movie record wize
            movierecordwize d = new movierecordwize();
            //showing the movie record wize
            d.Show();
        }
    }
}
