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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            //it will despose the application
            this.Dispose();
        }

        private void Clickbtn_Click(object sender, EventArgs e)
        {
            
            
            //creating object of options form
            Options f = new Options();
            //showing the options form
            f.Show();
        }
    }
}
