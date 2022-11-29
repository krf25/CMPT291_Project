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
            this.MovieQueued.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.MovieSearch.Controls.Add(this.button2);
            this.MovieSearch.Controls.Add(this.panel1);
            this.MovieSearch.Location = new System.Drawing.Point(4, 24);
            this.MovieSearch.Name = "MovieSearch";
            this.MovieSearch.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.MovieSearch.Size = new System.Drawing.Size(760, 374);
            this.MovieSearch.TabIndex = 0;
            this.MovieSearch.Text = "Movie Search";
            this.MovieSearch.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(620, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 57);
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
            this.panel1.Location = new System.Drawing.Point(6, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 90);
            this.panel1.TabIndex = 2;
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
            "Comedy",
            "Romance",
            "Anime"});
            this.MovieType.Location = new System.Drawing.Point(15, 54);
            this.MovieType.Name = "MovieType";
            this.MovieType.Size = new System.Drawing.Size(99, 23);
            this.MovieType.TabIndex = 0;
            // 
            // BestSellers
            // 
            this.BestSellers.Controls.Add(this.button5);
            this.BestSellers.Controls.Add(this.panel4);
            this.BestSellers.Location = new System.Drawing.Point(4, 24);
            this.BestSellers.Name = "BestSellers";
            this.BestSellers.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            this.MovieQueued.Controls.Add(this.label8);
            this.MovieQueued.Controls.Add(this.panel3);
            this.MovieQueued.Location = new System.Drawing.Point(4, 24);
            this.MovieQueued.Name = "MovieQueued";
            this.MovieQueued.Size = new System.Drawing.Size(768, 398);
            this.MovieQueued.TabIndex = 1;
            this.MovieQueued.Text = "Movie queued";
            this.MovieQueued.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(15, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
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
            this.panel3.Location = new System.Drawing.Point(15, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 97);
            this.panel3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(581, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Movie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(441, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Movie ID";
            // 
            // AddMovieId
            // 
            this.AddMovieId.Location = new System.Drawing.Point(441, 51);
            this.AddMovieId.Name = "AddMovieId";
            this.AddMovieId.Size = new System.Drawing.Size(100, 23);
            this.AddMovieId.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(176, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove Movie";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // RemoveMovieId
            // 
            this.RemoveMovieId.Location = new System.Drawing.Point(28, 51);
            this.RemoveMovieId.Name = "RemoveMovieId";
            this.RemoveMovieId.Size = new System.Drawing.Size(100, 23);
            this.RemoveMovieId.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(28, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Movie ID";
            // 
            // CustomerHistory
            // 
            this.CustomerHistory.Location = new System.Drawing.Point(4, 24);
            this.CustomerHistory.Name = "CustomerHistory";
            this.CustomerHistory.Size = new System.Drawing.Size(768, 398);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerTabs);
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
        private Panel panel3;
        private Label label12;
    }
}