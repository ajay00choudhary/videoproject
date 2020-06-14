namespace videoproject
{
    partial class customer
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
            this.listcustomerbtn = new System.Windows.Forms.Button();
            this.recordwisecusotmerbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listcustomerbtn
            // 
            this.listcustomerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listcustomerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listcustomerbtn.Location = new System.Drawing.Point(137, 65);
            this.listcustomerbtn.Name = "listcustomerbtn";
            this.listcustomerbtn.Size = new System.Drawing.Size(273, 91);
            this.listcustomerbtn.TabIndex = 0;
            this.listcustomerbtn.Text = "Show List";
            this.listcustomerbtn.UseVisualStyleBackColor = false;
            this.listcustomerbtn.Click += new System.EventHandler(this.listcustomerbtn_Click);
            // 
            // recordwisecusotmerbtn
            // 
            this.recordwisecusotmerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.recordwisecusotmerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordwisecusotmerbtn.Location = new System.Drawing.Point(137, 177);
            this.recordwisecusotmerbtn.Name = "recordwisecusotmerbtn";
            this.recordwisecusotmerbtn.Size = new System.Drawing.Size(273, 95);
            this.recordwisecusotmerbtn.TabIndex = 1;
            this.recordwisecusotmerbtn.Text = "Show Record by record";
            this.recordwisecusotmerbtn.UseVisualStyleBackColor = false;
            this.recordwisecusotmerbtn.Click += new System.EventHandler(this.recordwisecusotmerbtn_Click);
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(645, 426);
            this.Controls.Add(this.recordwisecusotmerbtn);
            this.Controls.Add(this.listcustomerbtn);
            this.Name = "customer";
            this.Text = "customer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listcustomerbtn;
        private System.Windows.Forms.Button recordwisecusotmerbtn;
    }
}