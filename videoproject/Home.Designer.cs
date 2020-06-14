namespace videoproject
{
    partial class Home
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
            this.welcomelbl = new System.Windows.Forms.Label();
            this.aboutlbl = new System.Windows.Forms.Label();
            this.Clickbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomelbl
            // 
            this.welcomelbl.AutoSize = true;
            this.welcomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelbl.Location = new System.Drawing.Point(77, 37);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(513, 32);
            this.welcomelbl.TabIndex = 0;
            this.welcomelbl.Text = "Welcome to the world of Video rental";
            // 
            // aboutlbl
            // 
            this.aboutlbl.AutoSize = true;
            this.aboutlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutlbl.Location = new System.Drawing.Point(103, 86);
            this.aboutlbl.Name = "aboutlbl";
            this.aboutlbl.Size = new System.Drawing.Size(386, 32);
            this.aboutlbl.TabIndex = 1;
            this.aboutlbl.Text = "It Records the video rentals";
            // 
            // Clickbtn
            // 
            this.Clickbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clickbtn.Location = new System.Drawing.Point(83, 139);
            this.Clickbtn.Name = "Clickbtn";
            this.Clickbtn.Size = new System.Drawing.Size(429, 70);
            this.Clickbtn.TabIndex = 2;
            this.Clickbtn.Text = "Click to start the application";
            this.Clickbtn.UseVisualStyleBackColor = true;
            this.Clickbtn.Click += new System.EventHandler(this.Clickbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(83, 215);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(429, 70);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Click to Exit the application";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(632, 378);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.Clickbtn);
            this.Controls.Add(this.aboutlbl);
            this.Controls.Add(this.welcomelbl);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.Label aboutlbl;
        private System.Windows.Forms.Button Clickbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}