namespace videoproject
{
    partial class movies
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
            this.listmoviebtn = new System.Windows.Forms.Button();
            this.movierecordwizebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listmoviebtn
            // 
            this.listmoviebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listmoviebtn.Location = new System.Drawing.Point(188, 61);
            this.listmoviebtn.Name = "listmoviebtn";
            this.listmoviebtn.Size = new System.Drawing.Size(259, 73);
            this.listmoviebtn.TabIndex = 0;
            this.listmoviebtn.Text = "Movie List";
            this.listmoviebtn.UseVisualStyleBackColor = false;
            this.listmoviebtn.Click += new System.EventHandler(this.listmoviebtn_Click);
            // 
            // movierecordwizebtn
            // 
            this.movierecordwizebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.movierecordwizebtn.Location = new System.Drawing.Point(188, 158);
            this.movierecordwizebtn.Name = "movierecordwizebtn";
            this.movierecordwizebtn.Size = new System.Drawing.Size(259, 73);
            this.movierecordwizebtn.TabIndex = 1;
            this.movierecordwizebtn.Text = "Movies record by record";
            this.movierecordwizebtn.UseVisualStyleBackColor = false;
            this.movierecordwizebtn.Click += new System.EventHandler(this.movierecordwizebtn_Click);
            // 
            // movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(622, 352);
            this.Controls.Add(this.movierecordwizebtn);
            this.Controls.Add(this.listmoviebtn);
            this.Name = "movies";
            this.Text = "movies";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listmoviebtn;
        private System.Windows.Forms.Button movierecordwizebtn;
    }
}