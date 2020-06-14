namespace videoproject
{
    partial class issuemovie
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
            this.rmidlbl = new System.Windows.Forms.Label();
            this.movieidlbl = new System.Windows.Forms.Label();
            this.custidlbl = new System.Windows.Forms.Label();
            this.daterentedlbl = new System.Windows.Forms.Label();
            this.rmidtxt = new System.Windows.Forms.TextBox();
            this.movieidtxt = new System.Windows.Forms.TextBox();
            this.custidtxt = new System.Windows.Forms.TextBox();
            this.daterentedDP = new System.Windows.Forms.DateTimePicker();
            this.issuemoviebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rmidlbl
            // 
            this.rmidlbl.AutoSize = true;
            this.rmidlbl.Location = new System.Drawing.Point(115, 55);
            this.rmidlbl.Name = "rmidlbl";
            this.rmidlbl.Size = new System.Drawing.Size(42, 17);
            this.rmidlbl.TabIndex = 0;
            this.rmidlbl.Text = "RMID";
            // 
            // movieidlbl
            // 
            this.movieidlbl.AutoSize = true;
            this.movieidlbl.Location = new System.Drawing.Point(118, 95);
            this.movieidlbl.Name = "movieidlbl";
            this.movieidlbl.Size = new System.Drawing.Size(58, 17);
            this.movieidlbl.TabIndex = 1;
            this.movieidlbl.Text = "MovieID";
            // 
            // custidlbl
            // 
            this.custidlbl.AutoSize = true;
            this.custidlbl.Location = new System.Drawing.Point(118, 134);
            this.custidlbl.Name = "custidlbl";
            this.custidlbl.Size = new System.Drawing.Size(49, 17);
            this.custidlbl.TabIndex = 2;
            this.custidlbl.Text = "CustID";
            // 
            // daterentedlbl
            // 
            this.daterentedlbl.AutoSize = true;
            this.daterentedlbl.Location = new System.Drawing.Point(118, 177);
            this.daterentedlbl.Name = "daterentedlbl";
            this.daterentedlbl.Size = new System.Drawing.Size(84, 17);
            this.daterentedlbl.TabIndex = 3;
            this.daterentedlbl.Text = "DateRented";
            // 
            // rmidtxt
            // 
            this.rmidtxt.Location = new System.Drawing.Point(253, 55);
            this.rmidtxt.Name = "rmidtxt";
            this.rmidtxt.Size = new System.Drawing.Size(150, 22);
            this.rmidtxt.TabIndex = 5;
            // 
            // movieidtxt
            // 
            this.movieidtxt.Location = new System.Drawing.Point(253, 95);
            this.movieidtxt.Name = "movieidtxt";
            this.movieidtxt.Size = new System.Drawing.Size(150, 22);
            this.movieidtxt.TabIndex = 6;
            // 
            // custidtxt
            // 
            this.custidtxt.Location = new System.Drawing.Point(253, 134);
            this.custidtxt.Name = "custidtxt";
            this.custidtxt.Size = new System.Drawing.Size(150, 22);
            this.custidtxt.TabIndex = 7;
            // 
            // daterentedDP
            // 
            this.daterentedDP.Location = new System.Drawing.Point(253, 177);
            this.daterentedDP.Name = "daterentedDP";
            this.daterentedDP.Size = new System.Drawing.Size(150, 22);
            this.daterentedDP.TabIndex = 10;
            // 
            // issuemoviebtn
            // 
            this.issuemoviebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.issuemoviebtn.Location = new System.Drawing.Point(183, 242);
            this.issuemoviebtn.Name = "issuemoviebtn";
            this.issuemoviebtn.Size = new System.Drawing.Size(127, 53);
            this.issuemoviebtn.TabIndex = 12;
            this.issuemoviebtn.Text = "Issue Movie";
            this.issuemoviebtn.UseVisualStyleBackColor = false;
            this.issuemoviebtn.Click += new System.EventHandler(this.issuemoviebtn_Click);
            // 
            // issuemovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(490, 400);
            this.Controls.Add(this.issuemoviebtn);
            this.Controls.Add(this.daterentedDP);
            this.Controls.Add(this.custidtxt);
            this.Controls.Add(this.movieidtxt);
            this.Controls.Add(this.rmidtxt);
            this.Controls.Add(this.daterentedlbl);
            this.Controls.Add(this.custidlbl);
            this.Controls.Add(this.movieidlbl);
            this.Controls.Add(this.rmidlbl);
            this.Name = "issuemovie";
            this.Text = "issuemovie";
            this.Load += new System.EventHandler(this.issuemovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rmidlbl;
        private System.Windows.Forms.Label movieidlbl;
        private System.Windows.Forms.Label custidlbl;
        private System.Windows.Forms.Label daterentedlbl;
        private System.Windows.Forms.TextBox rmidtxt;
        private System.Windows.Forms.TextBox movieidtxt;
        private System.Windows.Forms.TextBox custidtxt;
        private System.Windows.Forms.DateTimePicker daterentedDP;
        private System.Windows.Forms.Button issuemoviebtn;
    }
}