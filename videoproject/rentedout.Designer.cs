namespace videoproject
{
    partial class rentedout
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rentedoutgrid = new System.Windows.Forms.DataGridView();
            this.video_databaseDataSet2 = new videoproject.video_databaseDataSet2();
            this.rentedMoviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentedMoviesTableAdapter = new videoproject.video_databaseDataSet2TableAdapters.RentedMoviesTableAdapter();
            this.rMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieIDFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rentedoutgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rentedoutgrid
            // 
            this.rentedoutgrid.AutoGenerateColumns = false;
            this.rentedoutgrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rentedoutgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentedoutgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rMIDDataGridViewTextBoxColumn,
            this.movieIDFKDataGridViewTextBoxColumn,
            this.custIDFKDataGridViewTextBoxColumn,
            this.dateRentedDataGridViewTextBoxColumn,
            this.dateReturnedDataGridViewTextBoxColumn});
            this.rentedoutgrid.DataSource = this.rentedMoviesBindingSource;
            this.rentedoutgrid.Location = new System.Drawing.Point(43, 13);
            this.rentedoutgrid.Name = "rentedoutgrid";
            this.rentedoutgrid.RowTemplate.Height = 24;
            this.rentedoutgrid.Size = new System.Drawing.Size(543, 266);
            this.rentedoutgrid.TabIndex = 0;
            // 
            // video_databaseDataSet2
            // 
            this.video_databaseDataSet2.DataSetName = "video_databaseDataSet2";
            this.video_databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentedMoviesBindingSource
            // 
            this.rentedMoviesBindingSource.DataMember = "RentedMovies";
            this.rentedMoviesBindingSource.DataSource = this.video_databaseDataSet2;
            // 
            // rentedMoviesTableAdapter
            // 
            this.rentedMoviesTableAdapter.ClearBeforeFill = true;
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
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(260, 286);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(120, 39);
            this.exitbtn.TabIndex = 1;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // rentedout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(613, 331);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.rentedoutgrid);
            this.Name = "rentedout";
            this.Text = "rentedout";
            this.Load += new System.EventHandler(this.rentedout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentedoutgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView rentedoutgrid;
        private video_databaseDataSet2 video_databaseDataSet2;
        private System.Windows.Forms.BindingSource rentedMoviesBindingSource;
        private video_databaseDataSet2TableAdapters.RentedMoviesTableAdapter rentedMoviesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRentedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button exitbtn;
    }
}