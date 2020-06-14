namespace videoproject
{
    partial class moviesrental
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
            this.AllRentbtn = new System.Windows.Forms.Button();
            this.rentedoutbtn = new System.Windows.Forms.Button();
            this.Issuemoviebtn = new System.Windows.Forms.Button();
            this.returnmoviebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllRentbtn
            // 
            this.AllRentbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AllRentbtn.Location = new System.Drawing.Point(122, 35);
            this.AllRentbtn.Name = "AllRentbtn";
            this.AllRentbtn.Size = new System.Drawing.Size(250, 77);
            this.AllRentbtn.TabIndex = 0;
            this.AllRentbtn.Text = "All rented";
            this.AllRentbtn.UseVisualStyleBackColor = false;
            this.AllRentbtn.Click += new System.EventHandler(this.AllRentbtn_Click);
            // 
            // rentedoutbtn
            // 
            this.rentedoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rentedoutbtn.Location = new System.Drawing.Point(122, 118);
            this.rentedoutbtn.Name = "rentedoutbtn";
            this.rentedoutbtn.Size = new System.Drawing.Size(250, 79);
            this.rentedoutbtn.TabIndex = 1;
            this.rentedoutbtn.Text = "Rented Out";
            this.rentedoutbtn.UseVisualStyleBackColor = false;
            this.rentedoutbtn.Click += new System.EventHandler(this.rentedoutbtn_Click);
            // 
            // Issuemoviebtn
            // 
            this.Issuemoviebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Issuemoviebtn.Location = new System.Drawing.Point(122, 203);
            this.Issuemoviebtn.Name = "Issuemoviebtn";
            this.Issuemoviebtn.Size = new System.Drawing.Size(250, 83);
            this.Issuemoviebtn.TabIndex = 2;
            this.Issuemoviebtn.Text = "Issue Movie";
            this.Issuemoviebtn.UseVisualStyleBackColor = false;
            this.Issuemoviebtn.Click += new System.EventHandler(this.Issuemoviebtn_Click);
            // 
            // returnmoviebtn
            // 
            this.returnmoviebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.returnmoviebtn.Location = new System.Drawing.Point(122, 292);
            this.returnmoviebtn.Name = "returnmoviebtn";
            this.returnmoviebtn.Size = new System.Drawing.Size(250, 84);
            this.returnmoviebtn.TabIndex = 3;
            this.returnmoviebtn.Text = "Return Movie";
            this.returnmoviebtn.UseVisualStyleBackColor = false;
            this.returnmoviebtn.Click += new System.EventHandler(this.returnmoviebtn_Click);
            // 
            // moviesrental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(476, 434);
            this.Controls.Add(this.returnmoviebtn);
            this.Controls.Add(this.Issuemoviebtn);
            this.Controls.Add(this.rentedoutbtn);
            this.Controls.Add(this.AllRentbtn);
            this.Name = "moviesrental";
            this.Text = "moviesrental";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AllRentbtn;
        private System.Windows.Forms.Button rentedoutbtn;
        private System.Windows.Forms.Button Issuemoviebtn;
        private System.Windows.Forms.Button returnmoviebtn;
    }
}