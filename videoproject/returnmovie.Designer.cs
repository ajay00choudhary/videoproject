namespace videoproject
{
    partial class returnmovie
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
            this.returnmoviebtn = new System.Windows.Forms.Button();
            this.daterentedDP = new System.Windows.Forms.DateTimePicker();
            this.rmidtxt = new System.Windows.Forms.TextBox();
            this.Movierentedlbl = new System.Windows.Forms.Label();
            this.rmidlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnmoviebtn
            // 
            this.returnmoviebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnmoviebtn.Location = new System.Drawing.Point(185, 155);
            this.returnmoviebtn.Name = "returnmoviebtn";
            this.returnmoviebtn.Size = new System.Drawing.Size(127, 53);
            this.returnmoviebtn.TabIndex = 21;
            this.returnmoviebtn.Text = "Return Movie";
            this.returnmoviebtn.UseVisualStyleBackColor = true;
            this.returnmoviebtn.Click += new System.EventHandler(this.returnmoviebtn_Click);
            // 
            // daterentedDP
            // 
            this.daterentedDP.Location = new System.Drawing.Point(233, 94);
            this.daterentedDP.Name = "daterentedDP";
            this.daterentedDP.Size = new System.Drawing.Size(150, 22);
            this.daterentedDP.TabIndex = 20;
            // 
            // rmidtxt
            // 
            this.rmidtxt.Location = new System.Drawing.Point(234, 48);
            this.rmidtxt.Name = "rmidtxt";
            this.rmidtxt.Size = new System.Drawing.Size(150, 22);
            this.rmidtxt.TabIndex = 17;
            // 
            // Movierentedlbl
            // 
            this.Movierentedlbl.AutoSize = true;
            this.Movierentedlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movierentedlbl.Location = new System.Drawing.Point(98, 94);
            this.Movierentedlbl.Name = "Movierentedlbl";
            this.Movierentedlbl.Size = new System.Drawing.Size(96, 17);
            this.Movierentedlbl.TabIndex = 16;
            this.Movierentedlbl.Text = "Return Date";
            // 
            // rmidlbl
            // 
            this.rmidlbl.AutoSize = true;
            this.rmidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmidlbl.Location = new System.Drawing.Point(96, 48);
            this.rmidlbl.Name = "rmidlbl";
            this.rmidlbl.Size = new System.Drawing.Size(46, 17);
            this.rmidlbl.TabIndex = 13;
            this.rmidlbl.Text = "RMID";
            // 
            // returnmovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(474, 380);
            this.Controls.Add(this.returnmoviebtn);
            this.Controls.Add(this.daterentedDP);
            this.Controls.Add(this.rmidtxt);
            this.Controls.Add(this.Movierentedlbl);
            this.Controls.Add(this.rmidlbl);
            this.Name = "returnmovie";
            this.Text = "returnmovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnmoviebtn;
        private System.Windows.Forms.DateTimePicker daterentedDP;
        private System.Windows.Forms.TextBox rmidtxt;
        private System.Windows.Forms.Label Movierentedlbl;
        private System.Windows.Forms.Label rmidlbl;
    }
}