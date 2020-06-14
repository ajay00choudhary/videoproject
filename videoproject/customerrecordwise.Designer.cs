namespace videoproject
{
    partial class customerrecordwise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Customermsglbl = new System.Windows.Forms.Label();
            this.Customeridlbl = new System.Windows.Forms.Label();
            this.Fnamelbl = new System.Windows.Forms.Label();
            this.lastnamelbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.phonelbl = new System.Windows.Forms.Label();
            this.customeridtext = new System.Windows.Forms.TextBox();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.lstnametxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.loadbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.previousbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.addcustomertbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customermsglbl
            // 
            this.Customermsglbl.AutoSize = true;
            this.Customermsglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customermsglbl.Location = new System.Drawing.Point(137, 20);
            this.Customermsglbl.Name = "Customermsglbl";
            this.Customermsglbl.Size = new System.Drawing.Size(460, 32);
            this.Customermsglbl.TabIndex = 0;
            this.Customermsglbl.Text = "Customers Data record by record";
            // 
            // Customeridlbl
            // 
            this.Customeridlbl.AutoSize = true;
            this.Customeridlbl.Location = new System.Drawing.Point(234, 81);
            this.Customeridlbl.Name = "Customeridlbl";
            this.Customeridlbl.Size = new System.Drawing.Size(81, 17);
            this.Customeridlbl.TabIndex = 1;
            this.Customeridlbl.Text = "CustomerID";
            // 
            // Fnamelbl
            // 
            this.Fnamelbl.AutoSize = true;
            this.Fnamelbl.Location = new System.Drawing.Point(234, 119);
            this.Fnamelbl.Name = "Fnamelbl";
            this.Fnamelbl.Size = new System.Drawing.Size(76, 17);
            this.Fnamelbl.TabIndex = 2;
            this.Fnamelbl.Text = "First Name";
            // 
            // lastnamelbl
            // 
            this.lastnamelbl.AutoSize = true;
            this.lastnamelbl.Location = new System.Drawing.Point(234, 158);
            this.lastnamelbl.Name = "lastnamelbl";
            this.lastnamelbl.Size = new System.Drawing.Size(76, 17);
            this.lastnamelbl.TabIndex = 3;
            this.lastnamelbl.Text = "Last Name";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Location = new System.Drawing.Point(237, 199);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(60, 17);
            this.addresslbl.TabIndex = 4;
            this.addresslbl.Text = "Address";
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Location = new System.Drawing.Point(237, 235);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(49, 17);
            this.phonelbl.TabIndex = 5;
            this.phonelbl.Text = "Phone";
            // 
            // customeridtext
            // 
            this.customeridtext.Enabled = false;
            this.customeridtext.Location = new System.Drawing.Point(372, 81);
            this.customeridtext.Name = "customeridtext";
            this.customeridtext.Size = new System.Drawing.Size(100, 22);
            this.customeridtext.TabIndex = 6;
            // 
            // firstnametxt
            // 
            this.firstnametxt.Location = new System.Drawing.Point(372, 119);
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(100, 22);
            this.firstnametxt.TabIndex = 7;
            // 
            // lstnametxt
            // 
            this.lstnametxt.Location = new System.Drawing.Point(372, 158);
            this.lstnametxt.Name = "lstnametxt";
            this.lstnametxt.Size = new System.Drawing.Size(100, 22);
            this.lstnametxt.TabIndex = 8;
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(372, 199);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(100, 22);
            this.addresstxt.TabIndex = 9;
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(372, 235);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(100, 22);
            this.phonetxt.TabIndex = 10;
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(240, 281);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(75, 35);
            this.loadbtn.TabIndex = 11;
            this.loadbtn.Text = "Load Record";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(322, 281);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(71, 35);
            this.nextbtn.TabIndex = 12;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // previousbtn
            // 
            this.previousbtn.Location = new System.Drawing.Point(400, 281);
            this.previousbtn.Name = "previousbtn";
            this.previousbtn.Size = new System.Drawing.Size(80, 35);
            this.previousbtn.TabIndex = 13;
            this.previousbtn.Text = "Previous";
            this.previousbtn.UseVisualStyleBackColor = true;
            this.previousbtn.Click += new System.EventHandler(this.previousbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(400, 322);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(80, 35);
            this.exitbtn.TabIndex = 16;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(322, 322);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(71, 35);
            this.deletebtn.TabIndex = 15;
            this.deletebtn.Text = "delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(240, 322);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 35);
            this.Updatebtn.TabIndex = 14;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // addcustomertbtn
            // 
            this.addcustomertbtn.Location = new System.Drawing.Point(240, 363);
            this.addcustomertbtn.Name = "addcustomertbtn";
            this.addcustomertbtn.Size = new System.Drawing.Size(240, 34);
            this.addcustomertbtn.TabIndex = 17;
            this.addcustomertbtn.Text = "Add";
            this.addcustomertbtn.UseVisualStyleBackColor = true;
            this.addcustomertbtn.Click += new System.EventHandler(this.addcustomertbtn_Click);
            // 
            // customerrecordwise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(674, 426);
            this.Controls.Add(this.addcustomertbtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.previousbtn);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.lstnametxt);
            this.Controls.Add(this.firstnametxt);
            this.Controls.Add(this.customeridtext);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.lastnamelbl);
            this.Controls.Add(this.Fnamelbl);
            this.Controls.Add(this.Customeridlbl);
            this.Controls.Add(this.Customermsglbl);
            this.Name = "customerrecordwise";
            this.Text = "customerrecordwise";
            this.Load += new System.EventHandler(this.customerrecordwise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Customermsglbl;
        private System.Windows.Forms.Label Customeridlbl;
        private System.Windows.Forms.Label Fnamelbl;
        private System.Windows.Forms.Label lastnamelbl;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.TextBox customeridtext;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.TextBox lstnametxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Button previousbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button addcustomertbtn;
    }
}