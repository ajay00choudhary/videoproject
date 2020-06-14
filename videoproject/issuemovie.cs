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
    public partial class issuemovie : Form
    {
        //declaring the object
        issuemovie_class f=new issuemovie_class();
        public issuemovie()
        {
            InitializeComponent();
        }

        private void issuemoviebtn_Click(object sender, EventArgs e)
        {
            //calling the issue movie method
            bool g= f.issuemovie(movieidtxt.Text, custidtxt.Text, daterentedDP.Text);
            //checking the condition
            if (g == true)
            {
                MessageBox.Show("Movie Issued");
            }
        }

        private void issuemovie_Load(object sender, EventArgs e)
        {

        }
    }
}
