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
    public partial class customerrecordwise : Form
    {
        customer_class cust = new customer_class();
        int i = 0;
        DataSet d;
        public customerrecordwise()
        {
            InitializeComponent();
        }

        private void customerrecordwise_Load(object sender, EventArgs e)
        {

        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            //calling the method for dataset object for custmer
            d = cust.listcustomer();
            //showing first record
            customeridtext.Text = d.Tables[0].Rows[i][0].ToString();
            firstnametxt.Text = d.Tables[0].Rows[i][1].ToString();
            lstnametxt.Text = d.Tables[0].Rows[i][2].ToString();
            addresstxt.Text = d.Tables[0].Rows[i][3].ToString();
            phonetxt.Text = d.Tables[0].Rows[i][4].ToString();
            /*.Text = d.Tables[0].Rows[i][0].ToString();
            customeridtext.Text = d.Tables[0].Rows[i][0].ToString();
            customeridtext.Text = d.Tables[0].Rows[i][0].ToString();
            customeridtext.Text = d.Tables[0].Rows[i][0].ToString();
            customeridtext.Text = d.Tables[0].Rows[i][0].ToString();*/
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            i++;
            //increment the counter
            //showing the record
            customeridtext.Text = d.Tables[0].Rows[i][0].ToString();
            firstnametxt.Text = d.Tables[0].Rows[i][1].ToString();
            lstnametxt.Text = d.Tables[0].Rows[i][2].ToString();
            addresstxt.Text = d.Tables[0].Rows[i][3].ToString();
            phonetxt.Text = d.Tables[0].Rows[i][4].ToString();
        }

        private void previousbtn_Click(object sender, EventArgs e)
        {
            //decrement the counter
            i--;
            //showing the record
            customeridtext.Text = d.Tables[0].Rows[i][0].ToString();
            firstnametxt.Text = d.Tables[0].Rows[i][1].ToString();
            lstnametxt.Text = d.Tables[0].Rows[i][2].ToString();
            addresstxt.Text = d.Tables[0].Rows[i][3].ToString();
            phonetxt.Text = d.Tables[0].Rows[i][4].ToString();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            //disposing the form
            this.Dispose();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            //calling the update method
            bool ff=cust.updatecustomer(customeridtext.Text, firstnametxt.Text, lstnametxt.Text, addresstxt.Text, phonetxt.Text);
            //checking the condition
            if (ff == true)
            {
                MessageBox.Show("Record Updated");
            }
        }


        private void deletebtn_Click(object sender, EventArgs e)
        {
            //calling the method
           bool ff= cust.deletecustomer(customeridtext.Text);
            //checking whether customer is deleted
           if (ff == true)
           {
               MessageBox.Show("Record Deleted");
           }


                

        }

        private void addcustomertbtn_Click(object sender, EventArgs e)
        {
            //calling the update method
            bool ff = cust.addcustomer(firstnametxt.Text, lstnametxt.Text, addresstxt.Text, phonetxt.Text);
            //checking the condition
            if (ff == true)
            {
                MessageBox.Show("Record Added");
            }
        }
    }
}
