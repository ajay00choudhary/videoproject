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
    public partial class returnmovie : Form
    {
        //declaring the object
        issuemovie_class f = new issuemovie_class();
        public returnmovie()
        {
            InitializeComponent();
        }

        private void returnmoviebtn_Click(object sender, EventArgs e)
        {
            //calling the issue movie method
            bool g = f.returnmovie(rmidtxt.Text,daterentedDP.Text);
            //checking the condition
            if (g == true)
            {
                MessageBox.Show("Movie Returned");
            }
        }
    }
}
