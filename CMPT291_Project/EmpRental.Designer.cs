namespace CMPT291_Project
{
    partial class EmpRental
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
            this.RentalControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OrderButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CIDBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ReturnCID = new System.Windows.Forms.TextBox();
            this.RentalHistory = new System.Windows.Forms.TabPage();
            this.RentalGrid = new System.Windows.Forms.DataGridView();
            this.RentalSearchButton = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MovieNameSearchBox = new System.Windows.Forms.TextBox();
            this.MovieTypeSearchBox = new System.Windows.Forms.TextBox();
            this.FirstNameSearchBox = new System.Windows.Forms.TextBox();
            this.LastNameSearchBox = new System.Windows.Forms.TextBox();
            this.MID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDSearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RentalControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.RentalHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RentalControl1
            // 
            this.RentalControl1.Controls.Add(this.tabPage1);
            this.RentalControl1.Controls.Add(this.tabPage2);
            this.RentalControl1.Controls.Add(this.RentalHistory);
            this.RentalControl1.Location = new System.Drawing.Point(12, 12);
            this.RentalControl1.Name = "RentalControl1";
            this.RentalControl1.SelectedIndex = 0;
            this.RentalControl1.Size = new System.Drawing.Size(637, 443);
            this.RentalControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OrderButton);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CIDBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(629, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Rental";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(274, 279);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(100, 23);
            this.OrderButton.TabIndex = 12;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter new order details";
            // 
            // CIDBox
            // 
            this.CIDBox.Location = new System.Drawing.Point(274, 151);
            this.CIDBox.Name = "CIDBox";
            this.CIDBox.Size = new System.Drawing.Size(100, 23);
            this.CIDBox.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ReturnButton);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.ReturnCID);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(629, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Return Rental";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(252, 254);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(107, 23);
            this.ReturnButton.TabIndex = 22;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "CID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(197, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Enter new order details";
            // 
            // ReturnCID
            // 
            this.ReturnCID.Location = new System.Drawing.Point(252, 169);
            this.ReturnCID.Name = "ReturnCID";
            this.ReturnCID.Size = new System.Drawing.Size(100, 23);
            this.ReturnCID.TabIndex = 14;
            // 
            // RentalHistory
            // 
            this.RentalHistory.Controls.Add(this.CIDSearchBox);
            this.RentalHistory.Controls.Add(this.label2);
            this.RentalHistory.Controls.Add(this.LastNameSearchBox);
            this.RentalHistory.Controls.Add(this.FirstNameSearchBox);
            this.RentalHistory.Controls.Add(this.MovieTypeSearchBox);
            this.RentalHistory.Controls.Add(this.MovieNameSearchBox);
            this.RentalHistory.Controls.Add(this.label6);
            this.RentalHistory.Controls.Add(this.label4);
            this.RentalHistory.Controls.Add(this.label3);
            this.RentalHistory.Controls.Add(this.lable1);
            this.RentalHistory.Controls.Add(this.RentalSearchButton);
            this.RentalHistory.Controls.Add(this.RentalGrid);
            this.RentalHistory.Location = new System.Drawing.Point(4, 24);
            this.RentalHistory.Name = "RentalHistory";
            this.RentalHistory.Padding = new System.Windows.Forms.Padding(3);
            this.RentalHistory.Size = new System.Drawing.Size(629, 415);
            this.RentalHistory.TabIndex = 2;
            this.RentalHistory.Text = "RentalHistory";
            this.RentalHistory.UseVisualStyleBackColor = true;
            // 
            // RentalGrid
            // 
            this.RentalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MID,
            this.CPID,
            this.EID,
            this.MovieName,
            this.MovieType,
            this.CheckOutDate,
            this.ReturnDate});
            this.RentalGrid.Location = new System.Drawing.Point(0, 6);
            this.RentalGrid.Name = "RentalGrid";
            this.RentalGrid.RowTemplate.Height = 25;
            this.RentalGrid.Size = new System.Drawing.Size(490, 403);
            this.RentalGrid.TabIndex = 0;
            // 
            // RentalSearchButton
            // 
            this.RentalSearchButton.Location = new System.Drawing.Point(520, 326);
            this.RentalSearchButton.Name = "RentalSearchButton";
            this.RentalSearchButton.Size = new System.Drawing.Size(75, 23);
            this.RentalSearchButton.TabIndex = 1;
            this.RentalSearchButton.Text = "Search";
            this.RentalSearchButton.UseVisualStyleBackColor = true;
            this.RentalSearchButton.Click += new System.EventHandler(this.RentalSearchButton_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(507, 46);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(75, 15);
            this.lable1.TabIndex = 2;
            this.lable1.Text = "Movie Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Movie Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "FirstName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "LastName";
            // 
            // MovieNameSearchBox
            // 
            this.MovieNameSearchBox.Location = new System.Drawing.Point(507, 64);
            this.MovieNameSearchBox.Name = "MovieNameSearchBox";
            this.MovieNameSearchBox.Size = new System.Drawing.Size(100, 23);
            this.MovieNameSearchBox.TabIndex = 6;
            // 
            // MovieTypeSearchBox
            // 
            this.MovieTypeSearchBox.Location = new System.Drawing.Point(507, 118);
            this.MovieTypeSearchBox.Name = "MovieTypeSearchBox";
            this.MovieTypeSearchBox.Size = new System.Drawing.Size(100, 23);
            this.MovieTypeSearchBox.TabIndex = 7;
            // 
            // FirstNameSearchBox
            // 
            this.FirstNameSearchBox.Location = new System.Drawing.Point(507, 178);
            this.FirstNameSearchBox.Name = "FirstNameSearchBox";
            this.FirstNameSearchBox.Size = new System.Drawing.Size(100, 23);
            this.FirstNameSearchBox.TabIndex = 8;
            // 
            // LastNameSearchBox
            // 
            this.LastNameSearchBox.Location = new System.Drawing.Point(507, 236);
            this.LastNameSearchBox.Name = "LastNameSearchBox";
            this.LastNameSearchBox.Size = new System.Drawing.Size(100, 23);
            this.LastNameSearchBox.TabIndex = 9;
            // 
            // MID
            // 
            this.MID.HeaderText = "MID";
            this.MID.Name = "MID";
            this.MID.Width = 50;
            // 
            // CPID
            // 
            this.CPID.HeaderText = "CPID";
            this.CPID.Name = "CPID";
            this.CPID.Width = 50;
            // 
            // EID
            // 
            this.EID.HeaderText = "EID";
            this.EID.Name = "EID";
            this.EID.Width = 40;
            // 
            // MovieName
            // 
            this.MovieName.HeaderText = "Movie Name";
            this.MovieName.Name = "MovieName";
            this.MovieName.Width = 130;
            // 
            // MovieType
            // 
            this.MovieType.HeaderText = "MovieType";
            this.MovieType.Name = "MovieType";
            this.MovieType.Width = 80;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.HeaderText = "CheckOutDate";
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.Width = 90;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Width = 90;
            // 
            // CIDSearchBox
            // 
            this.CIDSearchBox.Location = new System.Drawing.Point(507, 288);
            this.CIDSearchBox.Name = "CIDSearchBox";
            this.CIDSearchBox.Size = new System.Drawing.Size(100, 23);
            this.CIDSearchBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "CID";
            // 
            // EmpRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 467);
            this.Controls.Add(this.RentalControl1);
            this.Name = "EmpRental";
            this.Text = "Rental";
            this.RentalControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.RentalHistory.ResumeLayout(false);
            this.RentalHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl RentalControl1;
        private TabPage tabPage1;
        private Label label5;
        private Label label1;
        private TextBox CIDBox;
        private TabPage tabPage2;
        private Button OrderButton;
        private Button ReturnButton;
        private Label label8;
        private Label label10;
        private TextBox ReturnCID;
        private TabPage RentalHistory;
        private DataGridView RentalGrid;
        private TextBox LastNameSearchBox;
        private TextBox FirstNameSearchBox;
        private TextBox MovieTypeSearchBox;
        private TextBox MovieNameSearchBox;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label lable1;
        private Button RentalSearchButton;
        private DataGridViewTextBoxColumn MID;
        private DataGridViewTextBoxColumn CPID;
        private DataGridViewTextBoxColumn EID;
        private DataGridViewTextBoxColumn MovieName;
        private DataGridViewTextBoxColumn MovieType;
        private DataGridViewTextBoxColumn CheckOutDate;
        private DataGridViewTextBoxColumn ReturnDate;
        private TextBox CIDSearchBox;
        private Label label2;
    }
}