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
    public partial class customerlist : Form
    {
        public customerlist()
        {
            InitializeComponent();
        }

        private void customerlist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'video_databaseDS.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.video_databaseDS.Customer);

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            //disposing the list form
            this.Dispose();
        }
    }
}
