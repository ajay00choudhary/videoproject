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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void listcustomerbtn_Click(object sender, EventArgs e)
        {
            //creating the object of customer form
            customerlist g = new customerlist();
            //showing the customer form
            g.Show();

        }

        private void recordwisecusotmerbtn_Click(object sender, EventArgs e)
        {
            //creating cusotmer record wise form object
            customerrecordwise g = new customerrecordwise();
            //showing form
            g.Show();
        }
    }
}
