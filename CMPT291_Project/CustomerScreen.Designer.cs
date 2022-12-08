namespace CMPT291_Project
{
    partial class CustomerScreen
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
            this.CustomerTabs = new System.Windows.Forms.TabControl();
            this.Movie = new System.Windows.Forms.TabPage();
            this.MovieMenu = new System.Windows.Forms.TabControl();
            this.MovieSearch = new System.Windows.Forms.TabPage();
            this.MovieDisplay = new System.Windows.Forms.DataGridView();
            this.mName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MovieType = new System.Windows.Forms.ComboBox();
            this.BestSellers = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.RecomendedMovies = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.MovieQueued = new System.Windows.Forms.TabPage();
            this.MovieQueueGrid = new System.Windows.Forms.DataGridView();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueuedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueuedType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchMovieQueueButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.AddMovieId = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.RemoveMovieId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CustomerHistory = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.RateMIDBox = new System.Windows.Forms.TextBox();
            this.RateMovieButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OverDueMovieCheckBox = new System.Windows.Forms.CheckBox();
            this.HeldMovieCheckBox = new System.Windows.Forms.CheckBox();
            this.ViewRentalButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerRentalGrid = new System.Windows.Forms.DataGridView();
            this.RentMovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentCopyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentMovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerDetails = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CustomerTabs.SuspendLayout();
            this.Movie.SuspendLayout();
            this.MovieMenu.SuspendLayout();
            this.MovieSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.BestSellers.SuspendLayout();
            this.panel4.SuspendLayout();
            this.RecomendedMovies.SuspendLayout();
            this.panel5.SuspendLayout();
            this.MovieQueued.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieQueueGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.CustomerHistory.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerRentalGrid)).BeginInit();
            this.CustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerTabs
            // 
            this.CustomerTabs.Controls.Add(this.Movie);
            this.CustomerTabs.Controls.Add(this.MovieQueued);
            this.CustomerTabs.Controls.Add(this.CustomerHistory);
            this.CustomerTabs.Controls.Add(this.CustomerDetails);
            this.CustomerTabs.Location = new System.Drawing.Point(12, 12);
            this.CustomerTabs.Name = "CustomerTabs";
            this.CustomerTabs.SelectedIndex = 0;
            this.CustomerTabs.Size = new System.Drawing.Size(776, 426);
            this.CustomerTabs.TabIndex = 0;
            // 
            // Movie
            // 
            this.Movie.Controls.Add(this.MovieMenu);
            this.Movie.Location = new System.Drawing.Point(4, 24);
            this.Movie.Name = "Movie";
            this.Movie.Size = new System.Drawing.Size(768, 398);
            this.Movie.TabIndex = 0;
            this.Movie.Text = "Movies";
            this.Movie.UseVisualStyleBackColor = true;
            // 
            // MovieMenu
            // 
            this.MovieMenu.Controls.Add(this.MovieSearch);
            this.MovieMenu.Controls.Add(this.BestSellers);
            this.MovieMenu.Controls.Add(this.RecomendedMovies);
            this.MovieMenu.Location = new System.Drawing.Point(0, 3);
            this.MovieMenu.Name = "MovieMenu";
            this.MovieMenu.SelectedIndex = 0;
            this.MovieMenu.Size = new System.Drawing.Size(768, 402);
            this.MovieMenu.TabIndex = 0;
            // 
            // MovieSearch
            // 
            this.MovieSearch.Controls.Add(this.MovieDisplay);
            this.MovieSearch.Controls.Add(this.button2);
            this.MovieSearch.Controls.Add(this.panel1);
            this.MovieSearch.Location = new System.Drawing.Point(4, 24);
            this.MovieSearch.Name = "MovieSearch";
            this.MovieSearch.Padding = new System.Windows.Forms.Padding(3);
            this.MovieSearch.Size = new System.Drawing.Size(760, 374);
            this.MovieSearch.TabIndex = 0;
            this.MovieSearch.Text = "Movie Search";
            this.MovieSearch.UseVisualStyleBackColor = true;
            // 
            // MovieDisplay
            // 
            this.MovieDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mName,
            this.mType,
            this.NumCopies,
            this.mRating});
            this.MovieDisplay.Location = new System.Drawing.Point(6, 4);
            this.MovieDisplay.Margin = new System.Windows.Forms.Padding(1);
            this.MovieDisplay.Name = "MovieDisplay";
            this.MovieDisplay.RowHeadersWidth = 123;
            this.MovieDisplay.RowTemplate.Height = 57;
            this.MovieDisplay.Size = new System.Drawing.Size(748, 236);
            this.MovieDisplay.TabIndex = 1;
            this.MovieDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mName
            // 
            this.mName.HeaderText = "Movie Title";
            this.mName.MinimumWidth = 15;
            this.mName.Name = "mName";
            this.mName.Width = 300;
            // 
            // mType
            // 
            this.mType.HeaderText = "Genre";
            this.mType.MinimumWidth = 15;
            this.mType.Name = "mType";
            this.mType.Width = 300;
            // 
            // NumCopies
            // 
            this.NumCopies.HeaderText = "Available Copies";
            this.NumCopies.MinimumWidth = 15;
            this.NumCopies.Name = "NumCopies";
            this.NumCopies.Width = 300;
            // 
            // mRating
            // 
            this.mRating.HeaderText = "Movie Rating";
            this.mRating.MinimumWidth = 15;
            this.mRating.Name = "mRating";
            this.mRating.Width = 300;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(634, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.MovieType);
            this.panel1.Location = new System.Drawing.Point(6, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 90);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Movie Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(15, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Movie Type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(443, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(122, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Available Copies";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(251, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(177, 35);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(268, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 30);
            this.label11.TabIndex = 4;
            this.label11.Text = "Actor full name \r\nseperated by commas";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // MovieType
            // 
            this.MovieType.FormattingEnabled = true;
            this.MovieType.Items.AddRange(new object[] {
            "",
            "Action",
            "Adventure",
            "Biography",
            "Comedy",
            "Drama",
            "Fantasy",
            "Mystery",
            "Romance",
            "Sci-Fi",
            "Thriller",
            "War",
            "Western"});
            this.MovieType.Location = new System.Drawing.Point(3, 54);
            this.MovieType.Name = "MovieType";
            this.MovieType.Size = new System.Drawing.Size(111, 23);
            this.MovieType.Sorted = true;
            this.MovieType.TabIndex = 0;
            this.MovieType.Text = "--Select Genre--";
            this.MovieType.SelectedIndexChanged += new System.EventHandler(this.MovieType_SelectedIndexChanged_1);
            // 
            // BestSellers
            // 
            this.BestSellers.Controls.Add(this.button5);
            this.BestSellers.Controls.Add(this.panel4);
            this.BestSellers.Location = new System.Drawing.Point(4, 24);
            this.BestSellers.Name = "BestSellers";
            this.BestSellers.Padding = new System.Windows.Forms.Padding(3);
            this.BestSellers.Size = new System.Drawing.Size(760, 374);
            this.BestSellers.TabIndex = 1;
            this.BestSellers.Text = "Best Sellers";
            this.BestSellers.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(216, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 46);
            this.button5.TabIndex = 1;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.checkBox2);
            this.panel4.Location = new System.Drawing.Point(6, 311);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(172, 47);
            this.panel4.TabIndex = 0;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(13, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(143, 25);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Avaliable Copies";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // RecomendedMovies
            // 
            this.RecomendedMovies.Controls.Add(this.button4);
            this.RecomendedMovies.Controls.Add(this.panel5);
            this.RecomendedMovies.Location = new System.Drawing.Point(4, 24);
            this.RecomendedMovies.Name = "RecomendedMovies";
            this.RecomendedMovies.Size = new System.Drawing.Size(760, 374);
            this.RecomendedMovies.TabIndex = 2;
            this.RecomendedMovies.Text = "Recomended Movies";
            this.RecomendedMovies.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(199, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 51);
            this.button4.TabIndex = 2;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Controls.Add(this.checkBox3);
            this.panel5.Location = new System.Drawing.Point(3, 312);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 55);
            this.panel5.TabIndex = 1;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox3.Location = new System.Drawing.Point(15, 16);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(143, 25);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Available Copies";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // MovieQueued
            // 
            this.MovieQueued.Controls.Add(this.MovieQueueGrid);
            this.MovieQueued.Controls.Add(this.label8);
            this.MovieQueued.Controls.Add(this.panel3);
            this.MovieQueued.Location = new System.Drawing.Point(4, 24);
            this.MovieQueued.Name = "MovieQueued";
            this.MovieQueued.Size = new System.Drawing.Size(768, 398);
            this.MovieQueued.TabIndex = 1;
            this.MovieQueued.Text = "Movie queued";
            this.MovieQueued.UseVisualStyleBackColor = true;
            // 
            // MovieQueueGrid
            // 
            this.MovieQueueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieQueueGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieID,
            this.QueuedName,
            this.QueuedType,
            this.movieRating});
            this.MovieQueueGrid.Location = new System.Drawing.Point(9, 30);
            this.MovieQueueGrid.Name = "MovieQueueGrid";
            this.MovieQueueGrid.RowTemplate.Height = 25;
            this.MovieQueueGrid.Size = new System.Drawing.Size(731, 253);
            this.MovieQueueGrid.TabIndex = 11;
            // 
            // MovieID
            // 
            this.MovieID.HeaderText = "MID";
            this.MovieID.Name = "MovieID";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(9, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Queued Movies";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.SearchMovieQueueButton);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.AddMovieId);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.RemoveMovieId);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(9, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 97);
            this.panel3.TabIndex = 10;
            // 
            // SearchMovieQueueButton
            // 
            this.SearchMovieQueueButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchMovieQueueButton.Location = new System.Drawing.Point(609, 27);
            this.SearchMovieQueueButton.Name = "SearchMovieQueueButton";
            this.SearchMovieQueueButton.Size = new System.Drawing.Size(122, 60);
            this.SearchMovieQueueButton.TabIndex = 7;
            this.SearchMovieQueueButton.Text = "Refresh Queue";
            this.SearchMovieQueueButton.UseVisualStyleBackColor = true;
            this.SearchMovieQueueButton.Click += new System.EventHandler(this.SearchMovieQueueButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(464, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(341, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Movie ID";
            // 
            // AddMovieId
            // 
            this.AddMovieId.Location = new System.Drawing.Point(341, 51);
            this.AddMovieId.Name = "AddMovieId";
            this.AddMovieId.Size = new System.Drawing.Size(100, 23);
            this.AddMovieId.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(135, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove Movie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RemoveMovieId
            // 
            this.RemoveMovieId.Location = new System.Drawing.Point(15, 51);
            this.RemoveMovieId.Name = "RemoveMovieId";
            this.RemoveMovieId.Size = new System.Drawing.Size(100, 23);
            this.RemoveMovieId.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(15, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Movie ID";
            // 
            // CustomerHistory
            // 
            this.CustomerHistory.Controls.Add(this.panel6);
            this.CustomerHistory.Controls.Add(this.panel2);
            this.CustomerHistory.Controls.Add(this.CustomerRentalGrid);
            this.CustomerHistory.Location = new System.Drawing.Point(4, 24);
            this.CustomerHistory.Name = "CustomerHistory";
            this.CustomerHistory.Size = new System.Drawing.Size(768, 398);
            this.CustomerHistory.TabIndex = 3;
            this.CustomerHistory.Text = "Rental History";
            this.CustomerHistory.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.RateMIDBox);
            this.panel6.Controls.Add(this.RateMovieButton);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Location = new System.Drawing.Point(575, 223);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(185, 139);
            this.panel6.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 15);
            this.label17.TabIndex = 4;
            this.label17.Text = "MID";
            // 
            // RateMIDBox
            // 
            this.RateMIDBox.Location = new System.Drawing.Point(32, 37);
            this.RateMIDBox.Name = "RateMIDBox";
            this.RateMIDBox.Size = new System.Drawing.Size(100, 23);
            this.RateMIDBox.TabIndex = 3;
            // 
            // RateMovieButton
            // 
            this.RateMovieButton.Location = new System.Drawing.Point(50, 102);
            this.RateMovieButton.Name = "RateMovieButton";
            this.RateMovieButton.Size = new System.Drawing.Size(75, 23);
            this.RateMovieButton.TabIndex = 2;
            this.RateMovieButton.Text = "RateMovie";
            this.RateMovieButton.UseVisualStyleBackColor = true;
            this.RateMovieButton.Click += new System.EventHandler(this.RateMovieButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "RateMovie";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.OverDueMovieCheckBox);
            this.panel2.Controls.Add(this.HeldMovieCheckBox);
            this.panel2.Controls.Add(this.ViewRentalButton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(575, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 139);
            this.panel2.TabIndex = 4;
            // 
            // OverDueMovieCheckBox
            // 
            this.OverDueMovieCheckBox.AutoSize = true;
            this.OverDueMovieCheckBox.Location = new System.Drawing.Point(22, 70);
            this.OverDueMovieCheckBox.Name = "OverDueMovieCheckBox";
            this.OverDueMovieCheckBox.Size = new System.Drawing.Size(110, 19);
            this.OverDueMovieCheckBox.TabIndex = 3;
            this.OverDueMovieCheckBox.Text = "OverDueMovies";
            this.OverDueMovieCheckBox.UseVisualStyleBackColor = true;
            // 
            // HeldMovieCheckBox
            // 
            this.HeldMovieCheckBox.AutoSize = true;
            this.HeldMovieCheckBox.Location = new System.Drawing.Point(22, 34);
            this.HeldMovieCheckBox.Name = "HeldMovieCheckBox";
            this.HeldMovieCheckBox.Size = new System.Drawing.Size(89, 19);
            this.HeldMovieCheckBox.TabIndex = 2;
            this.HeldMovieCheckBox.Text = "HeldMovies";
            this.HeldMovieCheckBox.UseVisualStyleBackColor = true;
            // 
            // ViewRentalButton
            // 
            this.ViewRentalButton.Location = new System.Drawing.Point(50, 95);
            this.ViewRentalButton.Name = "ViewRentalButton";
            this.ViewRentalButton.Size = new System.Drawing.Size(75, 23);
            this.ViewRentalButton.TabIndex = 1;
            this.ViewRentalButton.Text = "View";
            this.ViewRentalButton.UseVisualStyleBackColor = true;
            this.ViewRentalButton.Click += new System.EventHandler(this.ViewRentalButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "RentalHistory";
            // 
            // CustomerRentalGrid
            // 
            this.CustomerRentalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerRentalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentMovieID,
            this.rentCopyID,
            this.rentMovieName,
            this.CheckOutDate,
            this.ReturnDate});
            this.CustomerRentalGrid.Location = new System.Drawing.Point(8, 3);
            this.CustomerRentalGrid.Name = "CustomerRentalGrid";
            this.CustomerRentalGrid.RowTemplate.Height = 25;
            this.CustomerRentalGrid.Size = new System.Drawing.Size(555, 392);
            this.CustomerRentalGrid.TabIndex = 3;
            // 
            // RentMovieID
            // 
            this.RentMovieID.HeaderText = "MID";
            this.RentMovieID.Name = "RentMovieID";
            this.RentMovieID.Width = 60;
            // 
            // rentCopyID
            // 
            this.rentCopyID.HeaderText = "CPID";
            this.rentCopyID.Name = "rentCopyID";
            // 
            // rentMovieName
            // 
            this.rentMovieName.HeaderText = "Movie Name";
            this.rentMovieName.Name = "rentMovieName";
            this.rentMovieName.Width = 150;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.HeaderText = "CheckOutDate";
            this.CheckOutDate.Name = "CheckOutDate";
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.Name = "ReturnDate";
            // 
            // CustomerDetails
            // 
            this.CustomerDetails.Controls.Add(this.label5);
            this.CustomerDetails.Controls.Add(this.label4);
            this.CustomerDetails.Controls.Add(this.label3);
            this.CustomerDetails.Controls.Add(this.Email);
            this.CustomerDetails.Controls.Add(this.label1);
            this.CustomerDetails.Location = new System.Drawing.Point(4, 24);
            this.CustomerDetails.Name = "CustomerDetails";
            this.CustomerDetails.Size = new System.Drawing.Size(768, 398);
            this.CustomerDetails.TabIndex = 2;
            this.CustomerDetails.Text = "Account Details";
            this.CustomerDetails.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Account Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(381, 13);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(62, 25);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email:";
            this.Email.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.CustomerTabs);
            this.Name = "CustomerScreen";
            this.Text = "Menu";
            this.CustomerTabs.ResumeLayout(false);
            this.Movie.ResumeLayout(false);
            this.MovieMenu.ResumeLayout(false);
            this.MovieSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MovieDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BestSellers.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.RecomendedMovies.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.MovieQueued.ResumeLayout(false);
            this.MovieQueued.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieQueueGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.CustomerHistory.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerRentalGrid)).EndInit();
            this.CustomerDetails.ResumeLayout(false);
            this.CustomerDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl CustomerTabs;
        private TabPage Movie;
        private TabPage MovieQueued;
        private TabPage CustomerHistory;
        private OpenFileDialog openFileDialog1;
        private TabControl MovieMenu;
        private TabPage MovieSearch;
        private TabPage BestSellers;
        private TabPage RecomendedMovies;
        private TextBox textBox1;
        private TabPage CustomerDetails;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label Email;
        private Label label1;
        private Panel panel1;
        private CheckBox checkBox1;
        private ComboBox MovieType;
        private Button button2;
        private Label label10;
        private Label label11;
        private RichTextBox richTextBox1;
        private Button button5;
        private Panel panel4;
        private CheckBox checkBox2;
        private Button button4;
        private Panel panel5;
        private CheckBox checkBox3;
        private Label label2;
        private DataGridView MovieDisplay;
        private DataGridViewTextBoxColumn mName;
        private DataGridViewTextBoxColumn mType;
        private DataGridViewTextBoxColumn NumCopies;
        private DataGridViewTextBoxColumn mRating;
        private DataGridView MovieQueueGrid;
        private DataGridViewTextBoxColumn MovieID;
        private DataGridViewTextBoxColumn QueuedName;
        private DataGridViewTextBoxColumn QueuedType;
        private DataGridViewTextBoxColumn movieRating;
        private Label label8;
        private Panel panel3;
        private Button SearchMovieQueueButton;
        private Button button1;
        private Label label9;
        private TextBox AddMovieId;
        private Button button3;
        private TextBox RemoveMovieId;
        private Label label12;
        private Panel panel6;
        private Label label17;
        private TextBox RateMIDBox;
        private Button RateMovieButton;
        private Label label16;
        private Panel panel2;
        private CheckBox OverDueMovieCheckBox;
        private CheckBox HeldMovieCheckBox;
        private Button ViewRentalButton;
        private Label label6;
        private DataGridView CustomerRentalGrid;
        private DataGridViewTextBoxColumn RentMovieID;
        private DataGridViewTextBoxColumn rentCopyID;
        private DataGridViewTextBoxColumn rentMovieName;
        private DataGridViewTextBoxColumn CheckOutDate;
        private DataGridViewTextBoxColumn ReturnDate;
    }
}