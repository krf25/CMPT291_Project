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
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.RentMovie = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.CopyIdRent = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.RentCopy = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.MovieIdCopy = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SearchCopy = new System.Windows.Forms.Button();
            this.ReturnCopies = new System.Windows.Forms.TabPage();
            this.Return_Button = new System.Windows.Forms.Button();
            this.Rating = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MovieQueued = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.AddMovieId = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.RemoveMovieId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CustomerHistory = new System.Windows.Forms.TabPage();
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
            this.panel1.SuspendLayout();
            this.BestSellers.SuspendLayout();
            this.panel4.SuspendLayout();
            this.RecomendedMovies.SuspendLayout();
            this.panel5.SuspendLayout();
            this.RentMovie.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.ReturnCopies.SuspendLayout();
            this.MovieQueued.SuspendLayout();
            this.panel3.SuspendLayout();
            this.CustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerTabs
            // 
            this.CustomerTabs.Controls.Add(this.Movie);
            this.CustomerTabs.Controls.Add(this.RentMovie);
            this.CustomerTabs.Controls.Add(this.ReturnCopies);
            this.CustomerTabs.Controls.Add(this.MovieQueued);
            this.CustomerTabs.Controls.Add(this.CustomerHistory);
            this.CustomerTabs.Controls.Add(this.CustomerDetails);
            this.CustomerTabs.Location = new System.Drawing.Point(14, 16);
            this.CustomerTabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerTabs.Name = "CustomerTabs";
            this.CustomerTabs.SelectedIndex = 0;
            this.CustomerTabs.Size = new System.Drawing.Size(887, 568);
            this.CustomerTabs.TabIndex = 0;
            // 
            // Movie
            // 
            this.Movie.Controls.Add(this.MovieMenu);
            this.Movie.Location = new System.Drawing.Point(4, 29);
            this.Movie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Movie.Name = "Movie";
            this.Movie.Size = new System.Drawing.Size(879, 535);
            this.Movie.TabIndex = 0;
            this.Movie.Text = "Movies";
            this.Movie.UseVisualStyleBackColor = true;
            // 
            // MovieMenu
            // 
            this.MovieMenu.Controls.Add(this.MovieSearch);
            this.MovieMenu.Controls.Add(this.BestSellers);
            this.MovieMenu.Controls.Add(this.RecomendedMovies);
            this.MovieMenu.Location = new System.Drawing.Point(0, 4);
            this.MovieMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieMenu.Name = "MovieMenu";
            this.MovieMenu.SelectedIndex = 0;
            this.MovieMenu.Size = new System.Drawing.Size(878, 536);
            this.MovieMenu.TabIndex = 0;
            // 
            // MovieSearch
            // 
            this.MovieSearch.Controls.Add(this.button2);
            this.MovieSearch.Controls.Add(this.panel1);
            this.MovieSearch.Location = new System.Drawing.Point(4, 29);
            this.MovieSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieSearch.Name = "MovieSearch";
            this.MovieSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieSearch.Size = new System.Drawing.Size(870, 503);
            this.MovieSearch.TabIndex = 0;
            this.MovieSearch.Text = "Movie Search";
            this.MovieSearch.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(709, 395);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.MovieType);
            this.panel1.Location = new System.Drawing.Point(7, 371);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 120);
            this.panel1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(17, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "Movie Type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(506, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 27);
            this.textBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(139, 75);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Available Copies";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(287, 56);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(202, 45);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 40);
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
            "Comedy",
            "Romance",
            "Anime"});
            this.MovieType.Location = new System.Drawing.Point(17, 72);
            this.MovieType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieType.Name = "MovieType";
            this.MovieType.Size = new System.Drawing.Size(113, 28);
            this.MovieType.TabIndex = 0;
            // 
            // BestSellers
            // 
            this.BestSellers.Controls.Add(this.button5);
            this.BestSellers.Controls.Add(this.panel4);
            this.BestSellers.Location = new System.Drawing.Point(4, 29);
            this.BestSellers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BestSellers.Name = "BestSellers";
            this.BestSellers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BestSellers.Size = new System.Drawing.Size(870, 503);
            this.BestSellers.TabIndex = 1;
            this.BestSellers.Text = "Best Sellers";
            this.BestSellers.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(247, 416);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 61);
            this.button5.TabIndex = 1;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.checkBox2);
            this.panel4.Location = new System.Drawing.Point(7, 415);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 63);
            this.panel4.TabIndex = 0;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(15, 16);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(178, 32);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Avaliable Copies";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // RecomendedMovies
            // 
            this.RecomendedMovies.Controls.Add(this.button4);
            this.RecomendedMovies.Controls.Add(this.panel5);
            this.RecomendedMovies.Location = new System.Drawing.Point(4, 29);
            this.RecomendedMovies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RecomendedMovies.Name = "RecomendedMovies";
            this.RecomendedMovies.Size = new System.Drawing.Size(870, 503);
            this.RecomendedMovies.TabIndex = 2;
            this.RecomendedMovies.Text = "Recomended Movies";
            this.RecomendedMovies.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(227, 421);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 68);
            this.button4.TabIndex = 2;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Controls.Add(this.checkBox3);
            this.panel5.Location = new System.Drawing.Point(3, 416);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 73);
            this.panel5.TabIndex = 1;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox3.Location = new System.Drawing.Point(17, 21);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(178, 32);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Available Copies";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // RentMovie
            // 
            this.RentMovie.Controls.Add(this.panel7);
            this.RentMovie.Controls.Add(this.label13);
            this.RentMovie.Controls.Add(this.panel6);
            this.RentMovie.Location = new System.Drawing.Point(4, 29);
            this.RentMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RentMovie.Name = "RentMovie";
            this.RentMovie.Size = new System.Drawing.Size(879, 535);
            this.RentMovie.TabIndex = 4;
            this.RentMovie.Text = "Rent Movie";
            this.RentMovie.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Controls.Add(this.CopyIdRent);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.RentCopy);
            this.panel7.Location = new System.Drawing.Point(447, 384);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(389, 129);
            this.panel7.TabIndex = 1;
            // 
            // CopyIdRent
            // 
            this.CopyIdRent.Location = new System.Drawing.Point(23, 73);
            this.CopyIdRent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CopyIdRent.Name = "CopyIdRent";
            this.CopyIdRent.Size = new System.Drawing.Size(114, 27);
            this.CopyIdRent.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(23, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 28);
            this.label15.TabIndex = 4;
            this.label15.Text = "Copy Id";
            // 
            // RentCopy
            // 
            this.RentCopy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RentCopy.Location = new System.Drawing.Point(169, 37);
            this.RentCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RentCopy.Name = "RentCopy";
            this.RentCopy.Size = new System.Drawing.Size(197, 67);
            this.RentCopy.TabIndex = 3;
            this.RentCopy.Text = "Rent out copy";
            this.RentCopy.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(17, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 32);
            this.label13.TabIndex = 1;
            this.label13.Text = "Avaliable Copies";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.MovieIdCopy);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.SearchCopy);
            this.panel6.Location = new System.Drawing.Point(19, 384);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(389, 129);
            this.panel6.TabIndex = 0;
            // 
            // MovieIdCopy
            // 
            this.MovieIdCopy.Location = new System.Drawing.Point(24, 73);
            this.MovieIdCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieIdCopy.Name = "MovieIdCopy";
            this.MovieIdCopy.Size = new System.Drawing.Size(114, 27);
            this.MovieIdCopy.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(24, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 28);
            this.label14.TabIndex = 1;
            this.label14.Text = "Movie Id";
            // 
            // SearchCopy
            // 
            this.SearchCopy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchCopy.Location = new System.Drawing.Point(144, 37);
            this.SearchCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchCopy.Name = "SearchCopy";
            this.SearchCopy.Size = new System.Drawing.Size(223, 67);
            this.SearchCopy.TabIndex = 0;
            this.SearchCopy.Text = "Search for copies";
            this.SearchCopy.UseVisualStyleBackColor = true;
            // 
            // ReturnCopies
            // 
            this.ReturnCopies.Controls.Add(this.Return_Button);
            this.ReturnCopies.Controls.Add(this.Rating);
            this.ReturnCopies.Controls.Add(this.label7);
            this.ReturnCopies.Controls.Add(this.label6);
            this.ReturnCopies.Controls.Add(this.textBox2);
            this.ReturnCopies.Controls.Add(this.label2);
            this.ReturnCopies.Controls.Add(this.panel2);
            this.ReturnCopies.Location = new System.Drawing.Point(4, 29);
            this.ReturnCopies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReturnCopies.Name = "ReturnCopies";
            this.ReturnCopies.Size = new System.Drawing.Size(879, 535);
            this.ReturnCopies.TabIndex = 0;
            this.ReturnCopies.Text = "Return Movies";
            this.ReturnCopies.UseVisualStyleBackColor = true;
            // 
            // Return_Button
            // 
            this.Return_Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Return_Button.Location = new System.Drawing.Point(728, 433);
            this.Return_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(130, 69);
            this.Return_Button.TabIndex = 5;
            this.Return_Button.Text = "Return";
            this.Return_Button.UseVisualStyleBackColor = true;
            // 
            // Rating
            // 
            this.Rating.FormattingEnabled = true;
            this.Rating.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Rating.Location = new System.Drawing.Point(611, 472);
            this.Rating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(75, 28);
            this.Rating.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(611, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Rating";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(458, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Copy ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(458, 472);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 27);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Held Movies";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(438, 401);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 113);
            this.panel2.TabIndex = 6;
            // 
            // MovieQueued
            // 
            this.MovieQueued.Controls.Add(this.label8);
            this.MovieQueued.Controls.Add(this.panel3);
            this.MovieQueued.Location = new System.Drawing.Point(4, 29);
            this.MovieQueued.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieQueued.Name = "MovieQueued";
            this.MovieQueued.Size = new System.Drawing.Size(879, 535);
            this.MovieQueued.TabIndex = 1;
            this.MovieQueued.Text = "Movie queued";
            this.MovieQueued.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(17, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Queued Movies";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.AddMovieId);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.RemoveMovieId);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(17, 397);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 129);
            this.panel3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(664, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Movie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(504, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Movie ID";
            // 
            // AddMovieId
            // 
            this.AddMovieId.Location = new System.Drawing.Point(504, 68);
            this.AddMovieId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddMovieId.Name = "AddMovieId";
            this.AddMovieId.Size = new System.Drawing.Size(114, 27);
            this.AddMovieId.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(201, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 80);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove Movie";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // RemoveMovieId
            // 
            this.RemoveMovieId.Location = new System.Drawing.Point(32, 68);
            this.RemoveMovieId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveMovieId.Name = "RemoveMovieId";
            this.RemoveMovieId.Size = new System.Drawing.Size(114, 27);
            this.RemoveMovieId.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(32, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 32);
            this.label12.TabIndex = 6;
            this.label12.Text = "Movie ID";
            // 
            // CustomerHistory
            // 
            this.CustomerHistory.Location = new System.Drawing.Point(4, 29);
            this.CustomerHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerHistory.Name = "CustomerHistory";
            this.CustomerHistory.Size = new System.Drawing.Size(879, 535);
            this.CustomerHistory.TabIndex = 3;
            this.CustomerHistory.Text = "Rental History";
            this.CustomerHistory.UseVisualStyleBackColor = true;
            // 
            // CustomerDetails
            // 
            this.CustomerDetails.Controls.Add(this.label5);
            this.CustomerDetails.Controls.Add(this.label4);
            this.CustomerDetails.Controls.Add(this.label3);
            this.CustomerDetails.Controls.Add(this.Email);
            this.CustomerDetails.Controls.Add(this.label1);
            this.CustomerDetails.Location = new System.Drawing.Point(4, 29);
            this.CustomerDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerDetails.Name = "CustomerDetails";
            this.CustomerDetails.Size = new System.Drawing.Size(879, 535);
            this.CustomerDetails.TabIndex = 2;
            this.CustomerDetails.Text = "Account Details";
            this.CustomerDetails.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Account Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(435, 17);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(76, 32);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email:";
            this.Email.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.CustomerTabs);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerScreen";
            this.Text = "Menu";
            this.CustomerTabs.ResumeLayout(false);
            this.Movie.ResumeLayout(false);
            this.MovieMenu.ResumeLayout(false);
            this.MovieSearch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BestSellers.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.RecomendedMovies.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.RentMovie.ResumeLayout(false);
            this.RentMovie.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ReturnCopies.ResumeLayout(false);
            this.ReturnCopies.PerformLayout();
            this.MovieQueued.ResumeLayout(false);
            this.MovieQueued.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.CustomerDetails.ResumeLayout(false);
            this.CustomerDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl CustomerTabs;
        private TabPage Movie;
        private TabPage ReturnCopies;
        private TabPage MovieQueued;
        private TabPage CustomerHistory;
        private OpenFileDialog openFileDialog1;
        private TabControl MovieMenu;
        private TabPage MovieSearch;
        private TabPage BestSellers;
        private TabPage RecomendedMovies;
        private TextBox textBox1;
        private ComboBox Rating;
        private Label label7;
        private Label label6;
        private TextBox textBox2;
        private Label label2;
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
        private Button Return_Button;
        private Label label9;
        private Button button1;
        private TextBox AddMovieId;
        private Label label8;
        private Label label10;
        private Label label11;
        private RichTextBox richTextBox1;
        private TextBox RemoveMovieId;
        private Button button3;
        private Button button5;
        private Panel panel4;
        private CheckBox checkBox2;
        private Button button4;
        private Panel panel5;
        private CheckBox checkBox3;
        private TabPage RentMovie;
        private Panel panel7;
        private TextBox CopyIdRent;
        private Label label15;
        private Button RentCopy;
        private Label label13;
        private Panel panel6;
        private TextBox MovieIdCopy;
        private Label label14;
        private Button SearchCopy;
        private Panel panel2;
        private Panel panel3;
        private Label label12;
    }
}