namespace videoproject
{
    partial class allrented
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
            this.components = new System.ComponentModel.Container();
            this.Allrentedgrid = new System.Windows.Forms.DataGridView();
            this.rMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieIDFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentedMoviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.video_databaseDataSet1 = new videoproject.video_databaseDataSet1();
            this.rentedMoviesTableAdapter = new videoproject.video_databaseDataSet1TableAdapters.RentedMoviesTableAdapter();
            this.Exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Allrentedgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Allrentedgrid
            // 
            this.Allrentedgrid.AutoGenerateColumns = false;
            this.Allrentedgrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Allrentedgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Allrentedgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rMIDDataGridViewTextBoxColumn,
            this.movieIDFKDataGridViewTextBoxColumn,
            this.custIDFKDataGridViewTextBoxColumn,
            this.dateRentedDataGridViewTextBoxColumn,
            this.dateReturnedDataGridViewTextBoxColumn});
            this.Allrentedgrid.DataSource = this.rentedMoviesBindingSource;
            this.Allrentedgrid.Location = new System.Drawing.Point(80, 0);
            this.Allrentedgrid.Name = "Allrentedgrid";
            this.Allrentedgrid.RowTemplate.Height = 24;
            this.Allrentedgrid.Size = new System.Drawing.Size(542, 243);
            this.Allrentedgrid.TabIndex = 0;
            // 
            // rMIDDataGridViewTextBoxColumn
            // 
            this.rMIDDataGridViewTextBoxColumn.DataPropertyName = "RMID";
            this.rMIDDataGridViewTextBoxColumn.HeaderText = "RMID";
            this.rMIDDataGridViewTextBoxColumn.Name = "rMIDDataGridViewTextBoxColumn";
            this.rMIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieIDFKDataGridViewTextBoxColumn
            // 
            this.movieIDFKDataGridViewTextBoxColumn.DataPropertyName = "MovieIDFK";
            this.movieIDFKDataGridViewTextBoxColumn.HeaderText = "MovieIDFK";
            this.movieIDFKDataGridViewTextBoxColumn.Name = "movieIDFKDataGridViewTextBoxColumn";
            // 
            // custIDFKDataGridViewTextBoxColumn
            // 
            this.custIDFKDataGridViewTextBoxColumn.DataPropertyName = "CustIDFK";
            this.custIDFKDataGridViewTextBoxColumn.HeaderText = "CustIDFK";
            this.custIDFKDataGridViewTextBoxColumn.Name = "custIDFKDataGridViewTextBoxColumn";
            // 
            // dateRentedDataGridViewTextBoxColumn
            // 
            this.dateRentedDataGridViewTextBoxColumn.DataPropertyName = "DateRented";
            this.dateRentedDataGridViewTextBoxColumn.HeaderText = "DateRented";
            this.dateRentedDataGridViewTextBoxColumn.Name = "dateRentedDataGridViewTextBoxColumn";
            // 
            // dateReturnedDataGridViewTextBoxColumn
            // 
            this.dateReturnedDataGridViewTextBoxColumn.DataPropertyName = "DateReturned";
            this.dateReturnedDataGridViewTextBoxColumn.HeaderText = "DateReturned";
            this.dateReturnedDataGridViewTextBoxColumn.Name = "dateReturnedDataGridViewTextBoxColumn";
            // 
            // rentedMoviesBindingSource
            // 
            this.rentedMoviesBindingSource.DataMember = "RentedMovies";
            this.rentedMoviesBindingSource.DataSource = this.video_databaseDataSet1;
            // 
            // video_databaseDataSet1
            // 
            this.video_databaseDataSet1.DataSetName = "video_databaseDataSet1";
            this.video_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentedMoviesTableAdapter
            // 
            this.rentedMoviesTableAdapter.ClearBeforeFill = true;
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(287, 259);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(109, 42);
            this.Exitbtn.TabIndex = 1;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // allrented
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(702, 381);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Allrentedgrid);
            this.Name = "allrented";
            this.Text = "allrented";
            this.Load += new System.EventHandler(this.allrented_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Allrentedgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_databaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Allrentedgrid;
        private video_databaseDataSet1 video_databaseDataSet1;
        private System.Windows.Forms.BindingSource rentedMoviesBindingSource;
        private video_databaseDataSet1TableAdapters.RentedMoviesTableAdapter rentedMoviesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRentedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Exitbtn;
    }
}