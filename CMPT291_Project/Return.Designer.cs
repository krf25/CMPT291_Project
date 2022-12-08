namespace CMPT291_Project
{
    partial class Return
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
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.OID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderIDReturnBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderGrid
            // 
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OID,
            this.CPID,
            this.MID,
            this.movieName,
            this.CheckOutDate,
            this.ReturnDate});
            this.OrderGrid.Location = new System.Drawing.Point(12, 12);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.RowTemplate.Height = 25;
            this.OrderGrid.Size = new System.Drawing.Size(596, 339);
            this.OrderGrid.TabIndex = 0;
            // 
            // OID
            // 
            this.OID.HeaderText = "OID";
            this.OID.Name = "OID";
            this.OID.Width = 70;
            // 
            // CPID
            // 
            this.CPID.HeaderText = "CPID";
            this.CPID.Name = "CPID";
            this.CPID.Width = 50;
            // 
            // MID
            // 
            this.MID.HeaderText = "MID";
            this.MID.Name = "MID";
            this.MID.Width = 50;
            // 
            // movieName
            // 
            this.movieName.HeaderText = "Movie Name";
            this.movieName.Name = "movieName";
            this.movieName.Width = 150;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.HeaderText = "CheckOutDate";
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.Width = 110;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "OrderIDReturn";
            // 
            // OrderIDReturnBox
            // 
            this.OrderIDReturnBox.Location = new System.Drawing.Point(629, 200);
            this.OrderIDReturnBox.Name = "OrderIDReturnBox";
            this.OrderIDReturnBox.Size = new System.Drawing.Size(100, 23);
            this.OrderIDReturnBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "ViewRentedMovies";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrderIDReturnBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderGrid);
            this.Name = "Return";
            this.Text = "Return";
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView OrderGrid;
        private Label label1;
        private TextBox OrderIDReturnBox;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn OID;
        private DataGridViewTextBoxColumn CPID;
        private DataGridViewTextBoxColumn MID;
        private DataGridViewTextBoxColumn movieName;
        private DataGridViewTextBoxColumn CheckOutDate;
        private DataGridViewTextBoxColumn ReturnDate;
    }
}