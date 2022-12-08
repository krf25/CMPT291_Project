namespace CMPT291_Project
{
    partial class Rental
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
            this.Movies = new System.Windows.Forms.TabControl();
            this.Rent = new System.Windows.Forms.TabPage();
            this.CopyGrid = new System.Windows.Forms.DataGridView();
            this.CopyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopySearch = new System.Windows.Forms.Button();
            this.AvailableCheckBox = new System.Windows.Forms.CheckBox();
            this.RentButton = new System.Windows.Forms.Button();
            this.CPIDRent = new System.Windows.Forms.TextBox();
            this.CopyTypeSearch = new System.Windows.Forms.TextBox();
            this.MIDSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MovieSearch = new System.Windows.Forms.Button();
            this.AvailableCheck = new System.Windows.Forms.CheckBox();
            this.MovieTypeSearch = new System.Windows.Forms.TextBox();
            this.MovieNameSerach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MovieGrid = new System.Windows.Forms.DataGridView();
            this.MID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MovieQueueButton = new System.Windows.Forms.Button();
            this.MovieQueueGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueuedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueuedType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movies.SuspendLayout();
            this.Rent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CopyGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieQueueGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Movies
            // 
            this.Movies.Controls.Add(this.Rent);
            this.Movies.Controls.Add(this.tabPage2);
            this.Movies.Controls.Add(this.tabPage1);
            this.Movies.Location = new System.Drawing.Point(12, 12);
            this.Movies.Name = "Movies";
            this.Movies.SelectedIndex = 0;
            this.Movies.Size = new System.Drawing.Size(776, 426);
            this.Movies.TabIndex = 0;
            // 
            // Rent
            // 
            this.Rent.Controls.Add(this.CopyGrid);
            this.Rent.Controls.Add(this.CopySearch);
            this.Rent.Controls.Add(this.AvailableCheckBox);
            this.Rent.Controls.Add(this.RentButton);
            this.Rent.Controls.Add(this.CPIDRent);
            this.Rent.Controls.Add(this.CopyTypeSearch);
            this.Rent.Controls.Add(this.MIDSearch);
            this.Rent.Controls.Add(this.label3);
            this.Rent.Controls.Add(this.label2);
            this.Rent.Controls.Add(this.label1);
            this.Rent.Location = new System.Drawing.Point(4, 24);
            this.Rent.Name = "Rent";
            this.Rent.Padding = new System.Windows.Forms.Padding(3);
            this.Rent.Size = new System.Drawing.Size(768, 398);
            this.Rent.TabIndex = 0;
            this.Rent.Text = "Rent";
            this.Rent.UseVisualStyleBackColor = true;
            // 
            // CopyGrid
            // 
            this.CopyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CopyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CopyID,
            this.MovieID,
            this.movieName,
            this.cState,
            this.cType,
            this.Availability,
            this.ReturnDate});
            this.CopyGrid.Location = new System.Drawing.Point(6, 6);
            this.CopyGrid.Name = "CopyGrid";
            this.CopyGrid.RowTemplate.Height = 25;
            this.CopyGrid.Size = new System.Drawing.Size(570, 386);
            this.CopyGrid.TabIndex = 10;
            // 
            // CopyID
            // 
            this.CopyID.HeaderText = "CPID";
            this.CopyID.Name = "CopyID";
            this.CopyID.Width = 40;
            // 
            // MovieID
            // 
            this.MovieID.HeaderText = "MID";
            this.MovieID.Name = "MovieID";
            this.MovieID.Width = 40;
            // 
            // movieName
            // 
            this.movieName.HeaderText = "Name";
            this.movieName.Name = "movieName";
            this.movieName.Width = 140;
            // 
            // cState
            // 
            this.cState.HeaderText = "State";
            this.cState.Name = "cState";
            this.cState.Width = 70;
            // 
            // cType
            // 
            this.cType.HeaderText = "Type";
            this.cType.Name = "cType";
            this.cType.Width = 60;
            // 
            // Availability
            // 
            this.Availability.HeaderText = "Availability";
            this.Availability.Name = "Availability";
            this.Availability.Width = 70;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.Name = "ReturnDate";
            // 
            // CopySearch
            // 
            this.CopySearch.Location = new System.Drawing.Point(630, 224);
            this.CopySearch.Name = "CopySearch";
            this.CopySearch.Size = new System.Drawing.Size(83, 38);
            this.CopySearch.TabIndex = 9;
            this.CopySearch.Text = "Search";
            this.CopySearch.UseVisualStyleBackColor = true;
            this.CopySearch.Click += new System.EventHandler(this.CopySearch_Click_1);
            // 
            // AvailableCheckBox
            // 
            this.AvailableCheckBox.AutoSize = true;
            this.AvailableCheckBox.Location = new System.Drawing.Point(630, 199);
            this.AvailableCheckBox.Name = "AvailableCheckBox";
            this.AvailableCheckBox.Size = new System.Drawing.Size(74, 19);
            this.AvailableCheckBox.TabIndex = 8;
            this.AvailableCheckBox.Text = "Available";
            this.AvailableCheckBox.UseVisualStyleBackColor = true;
            // 
            // RentButton
            // 
            this.RentButton.Location = new System.Drawing.Point(630, 331);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(83, 36);
            this.RentButton.TabIndex = 7;
            this.RentButton.Text = "Rent";
            this.RentButton.UseVisualStyleBackColor = true;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // CPIDRent
            // 
            this.CPIDRent.Location = new System.Drawing.Point(630, 302);
            this.CPIDRent.Name = "CPIDRent";
            this.CPIDRent.Size = new System.Drawing.Size(100, 23);
            this.CPIDRent.TabIndex = 6;
            // 
            // CopyTypeSearch
            // 
            this.CopyTypeSearch.Location = new System.Drawing.Point(630, 144);
            this.CopyTypeSearch.Name = "CopyTypeSearch";
            this.CopyTypeSearch.Size = new System.Drawing.Size(100, 23);
            this.CopyTypeSearch.TabIndex = 5;
            // 
            // MIDSearch
            // 
            this.MIDSearch.Location = new System.Drawing.Point(630, 70);
            this.MIDSearch.Name = "MIDSearch";
            this.MIDSearch.Size = new System.Drawing.Size(100, 23);
            this.MIDSearch.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copy ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copy Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MovieSearch);
            this.tabPage2.Controls.Add(this.AvailableCheck);
            this.tabPage2.Controls.Add(this.MovieTypeSearch);
            this.tabPage2.Controls.Add(this.MovieNameSerach);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.MovieGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MovieSearch
            // 
            this.MovieSearch.Location = new System.Drawing.Point(558, 286);
            this.MovieSearch.Name = "MovieSearch";
            this.MovieSearch.Size = new System.Drawing.Size(83, 39);
            this.MovieSearch.TabIndex = 7;
            this.MovieSearch.Text = "Search";
            this.MovieSearch.UseVisualStyleBackColor = true;
            this.MovieSearch.Click += new System.EventHandler(this.MovieSearch_Click);
            // 
            // AvailableCheck
            // 
            this.AvailableCheck.AutoSize = true;
            this.AvailableCheck.Location = new System.Drawing.Point(558, 230);
            this.AvailableCheck.Name = "AvailableCheck";
            this.AvailableCheck.Size = new System.Drawing.Size(74, 19);
            this.AvailableCheck.TabIndex = 6;
            this.AvailableCheck.Text = "Available";
            this.AvailableCheck.UseVisualStyleBackColor = true;
            // 
            // MovieTypeSearch
            // 
            this.MovieTypeSearch.Location = new System.Drawing.Point(558, 164);
            this.MovieTypeSearch.Name = "MovieTypeSearch";
            this.MovieTypeSearch.Size = new System.Drawing.Size(100, 23);
            this.MovieTypeSearch.TabIndex = 5;
            // 
            // MovieNameSerach
            // 
            this.MovieNameSerach.Location = new System.Drawing.Point(558, 75);
            this.MovieNameSerach.Name = "MovieNameSerach";
            this.MovieNameSerach.Size = new System.Drawing.Size(100, 23);
            this.MovieNameSerach.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Movie Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // MovieGrid
            // 
            this.MovieGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MID,
            this.mName,
            this.mType,
            this.mRating});
            this.MovieGrid.Location = new System.Drawing.Point(54, 9);
            this.MovieGrid.Name = "MovieGrid";
            this.MovieGrid.RowTemplate.Height = 25;
            this.MovieGrid.Size = new System.Drawing.Size(411, 386);
            this.MovieGrid.TabIndex = 0;
            // 
            // MID
            // 
            this.MID.HeaderText = "MID";
            this.MID.Name = "MID";
            this.MID.Width = 40;
            // 
            // mName
            // 
            this.mName.HeaderText = "Name";
            this.mName.Name = "mName";
            this.mName.Width = 150;
            // 
            // mType
            // 
            this.mType.HeaderText = "Type";
            this.mType.Name = "mType";
            this.mType.Width = 80;
            // 
            // mRating
            // 
            this.mRating.HeaderText = "Rating";
            this.mRating.Name = "mRating";
            this.mRating.Width = 70;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MovieQueueGrid);
            this.tabPage1.Controls.Add(this.MovieQueueButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 398);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Customer Movie Queue";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MovieQueueButton
            // 
            this.MovieQueueButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieQueueButton.Location = new System.Drawing.Point(335, 323);
            this.MovieQueueButton.Name = "MovieQueueButton";
            this.MovieQueueButton.Size = new System.Drawing.Size(110, 49);
            this.MovieQueueButton.TabIndex = 1;
            this.MovieQueueButton.Text = "Search";
            this.MovieQueueButton.UseVisualStyleBackColor = true;
            this.MovieQueueButton.Click += new System.EventHandler(this.MovieQueueButton_Click);
            // 
            // MovieQueueGrid
            // 
            this.MovieQueueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieQueueGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.QueuedName,
            this.QueuedType,
            this.movieRating});
            this.MovieQueueGrid.Location = new System.Drawing.Point(19, 31);
            this.MovieQueueGrid.Name = "MovieQueueGrid";
            this.MovieQueueGrid.RowTemplate.Height = 25;
            this.MovieQueueGrid.Size = new System.Drawing.Size(731, 253);
            this.MovieQueueGrid.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "MID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // QueuedName
            // 
            this.QueuedName.HeaderText = "MovieName";
            this.QueuedName.Name = "QueuedName";
            this.QueuedName.Width = 300;
            // 
            // QueuedType
            // 
            this.QueuedType.HeaderText = "MType";
            this.QueuedType.Name = "QueuedType";
            // 
            // movieRating
            // 
            this.movieRating.HeaderText = "mRating";
            this.movieRating.Name = "movieRating";
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Movies);
            this.Name = "Rental";
            this.Text = "Rent";
            this.Movies.ResumeLayout(false);
            this.Rent.ResumeLayout(false);
            this.Rent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CopyGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MovieQueueGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl Movies;
        private TabPage Rent;
        private CheckBox AvailableCheckBox;
        private Button RentButton;
        private TextBox CPIDRent;
        private TextBox CopyTypeSearch;
        private TextBox MIDSearch;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Button MovieSearch;
        private CheckBox AvailableCheck;
        private TextBox MovieTypeSearch;
        private TextBox MovieNameSerach;
        private Label label5;
        private Label label4;
        private DataGridView MovieGrid;
        private Button CopySearch;
        private DataGridViewTextBoxColumn MID;
        private DataGridViewTextBoxColumn mName;
        private DataGridViewTextBoxColumn mType;
        private DataGridViewTextBoxColumn mRating;
        private DataGridView CopyGrid;
        private DataGridViewTextBoxColumn CopyID;
        private DataGridViewTextBoxColumn MovieID;
        private DataGridViewTextBoxColumn movieName;
        private DataGridViewTextBoxColumn cState;
        private DataGridViewTextBoxColumn cType;
        private DataGridViewTextBoxColumn Availability;
        private DataGridViewTextBoxColumn ReturnDate;
        private TabPage tabPage1;
        private Button MovieQueueButton;
        private DataGridView MovieQueueGrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn QueuedName;
        private DataGridViewTextBoxColumn QueuedType;
        private DataGridViewTextBoxColumn movieRating;
    }
}