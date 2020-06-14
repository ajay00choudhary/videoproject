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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Customerbtn_Click(object sender, EventArgs e)
        {
            //creating customer form object
            customer f = new customer();
            //showing the form
            f.Show();
        }

        private void moviesbtn_Click(object sender, EventArgs e)
        {
            //creating movie form object
            movies f = new movies();
            //showing moview form object
            f.Show();
        }

        private void rentalbtn_Click(object sender, EventArgs e)
        {
            //creating movie rental form object
            moviesrental f = new moviesrental();
            //showing the form
            f.Show();
        }
    }
}
