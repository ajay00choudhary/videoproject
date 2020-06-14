namespace videoproject
{
    partial class Options
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
            this.Customerbtn = new System.Windows.Forms.Button();
            this.moviesbtn = new System.Windows.Forms.Button();
            this.rentalbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customerbtn
            // 
            this.Customerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customerbtn.Location = new System.Drawing.Point(120, 32);
            this.Customerbtn.Name = "Customerbtn";
            this.Customerbtn.Size = new System.Drawing.Size(244, 82);
            this.Customerbtn.TabIndex = 0;
            this.Customerbtn.Text = "Customer";
            this.Customerbtn.UseVisualStyleBackColor = true;
            this.Customerbtn.Click += new System.EventHandler(this.Customerbtn_Click);
            // 
            // moviesbtn
            // 
            this.moviesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviesbtn.Location = new System.Drawing.Point(120, 135);
            this.moviesbtn.Name = "moviesbtn";
            this.moviesbtn.Size = new System.Drawing.Size(244, 96);
            this.moviesbtn.TabIndex = 1;
            this.moviesbtn.Text = "Movies";
            this.moviesbtn.UseVisualStyleBackColor = true;
            this.moviesbtn.Click += new System.EventHandler(this.moviesbtn_Click);
            // 
            // rentalbtn
            // 
            this.rentalbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalbtn.Location = new System.Drawing.Point(120, 248);
            this.rentalbtn.Name = "rentalbtn";
            this.rentalbtn.Size = new System.Drawing.Size(244, 100);
            this.rentalbtn.TabIndex = 2;
            this.rentalbtn.Text = "Movies Rental";
            this.rentalbtn.UseVisualStyleBackColor = true;
            this.rentalbtn.Click += new System.EventHandler(this.rentalbtn_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(454, 383);
            this.Controls.Add(this.rentalbtn);
            this.Controls.Add(this.moviesbtn);
            this.Controls.Add(this.Customerbtn);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Customerbtn;
        private System.Windows.Forms.Button moviesbtn;
        private System.Windows.Forms.Button rentalbtn;
    }
}