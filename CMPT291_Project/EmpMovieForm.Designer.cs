namespace CMPT291_Project
{
    partial class emp_movie_form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.movie_cast_label = new System.Windows.Forms.Label();
            this.copies_movie_label = new System.Windows.Forms.Label();
            this.genre_movie_label = new System.Windows.Forms.Label();
            this.movie_name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.movie_cast_box = new System.Windows.Forms.RichTextBox();
            this.genre_movie_box = new System.Windows.Forms.TextBox();
            this.movie_text_box = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.movieID_label = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.copies_label_update = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.movie_id_box_update = new System.Windows.Forms.TextBox();
            this.copies_box_update = new System.Windows.Forms.TextBox();
            this.ViewMovie = new System.Windows.Forms.TabPage();
            this.view_header = new System.Windows.Forms.Label();
            this.gen_movies_btn = new System.Windows.Forms.Button();
            this.ViewCopies = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.movieID_label.SuspendLayout();
            this.ViewMovie.SuspendLayout();
            this.ViewCopies.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.movieID_label);
            this.tabControl1.Controls.Add(this.ViewMovie);
            this.tabControl1.Controls.Add(this.ViewCopies);
            this.tabControl1.Location = new System.Drawing.Point(14, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.movie_cast_label);
            this.tabPage1.Controls.Add(this.copies_movie_label);
            this.tabPage1.Controls.Add(this.genre_movie_label);
            this.tabPage1.Controls.Add(this.movie_name_label);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.movie_cast_box);
            this.tabPage1.Controls.Add(this.genre_movie_box);
            this.tabPage1.Controls.Add(this.movie_text_box);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(879, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Movie";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // movie_cast_label
            // 
            this.movie_cast_label.AutoSize = true;
            this.movie_cast_label.Location = new System.Drawing.Point(376, 135);
            this.movie_cast_label.Name = "movie_cast_label";
            this.movie_cast_label.Size = new System.Drawing.Size(212, 20);
            this.movie_cast_label.TabIndex = 10;
            this.movie_cast_label.Text = "Movie Cast(comma separated)";
            this.movie_cast_label.Click += new System.EventHandler(this.movie_cast_label_Click);
            // 
            // copies_movie_label
            // 
            this.copies_movie_label.AutoSize = true;
            this.copies_movie_label.Location = new System.Drawing.Point(127, 316);
            this.copies_movie_label.Name = "copies_movie_label";
            this.copies_movie_label.Size = new System.Drawing.Size(0, 20);
            this.copies_movie_label.TabIndex = 9;
            // 
            // genre_movie_label
            // 
            this.genre_movie_label.AutoSize = true;
            this.genre_movie_label.Location = new System.Drawing.Point(127, 245);
            this.genre_movie_label.Name = "genre_movie_label";
            this.genre_movie_label.Size = new System.Drawing.Size(48, 20);
            this.genre_movie_label.TabIndex = 8;
            this.genre_movie_label.Text = "Genre";
            // 
            // movie_name_label
            // 
            this.movie_name_label.AutoSize = true;
            this.movie_name_label.Location = new System.Drawing.Point(127, 135);
            this.movie_name_label.Name = "movie_name_label";
            this.movie_name_label.Size = new System.Drawing.Size(83, 20);
            this.movie_name_label.TabIndex = 7;
            this.movie_name_label.Text = "Movie Title";
            this.movie_name_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter movie details to add new movie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 377);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Movie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // movie_cast_box
            // 
            this.movie_cast_box.Location = new System.Drawing.Point(376, 159);
            this.movie_cast_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movie_cast_box.Name = "movie_cast_box";
            this.movie_cast_box.Size = new System.Drawing.Size(282, 249);
            this.movie_cast_box.TabIndex = 3;
            this.movie_cast_box.Text = "";
            this.movie_cast_box.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // genre_movie_box
            // 
            this.genre_movie_box.Location = new System.Drawing.Point(170, 269);
            this.genre_movie_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genre_movie_box.Name = "genre_movie_box";
            this.genre_movie_box.Size = new System.Drawing.Size(114, 27);
            this.genre_movie_box.TabIndex = 2;
            // 
            // movie_text_box
            // 
            this.movie_text_box.Location = new System.Drawing.Point(170, 159);
            this.movie_text_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movie_text_box.Name = "movie_text_box";
            this.movie_text_box.Size = new System.Drawing.Size(114, 27);
            this.movie_text_box.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(879, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete Movie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(125, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Movie ID to remove movie from the system";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 207);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(318, 149);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(114, 27);
            this.textBox6.TabIndex = 5;
            // 
            // movieID_label
            // 
            this.movieID_label.Controls.Add(this.label6);
            this.movieID_label.Controls.Add(this.label5);
            this.movieID_label.Controls.Add(this.copies_label_update);
            this.movieID_label.Controls.Add(this.update_btn);
            this.movieID_label.Controls.Add(this.movie_id_box_update);
            this.movieID_label.Controls.Add(this.copies_box_update);
            this.movieID_label.Location = new System.Drawing.Point(4, 29);
            this.movieID_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieID_label.Name = "movieID_label";
            this.movieID_label.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieID_label.Size = new System.Drawing.Size(879, 535);
            this.movieID_label.TabIndex = 2;
            this.movieID_label.Text = "Update Movie";
            this.movieID_label.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(56, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Enter updated movie details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Movie ID";
            // 
            // copies_label_update
            // 
            this.copies_label_update.AutoSize = true;
            this.copies_label_update.Location = new System.Drawing.Point(82, 216);
            this.copies_label_update.Name = "copies_label_update";
            this.copies_label_update.Size = new System.Drawing.Size(151, 20);
            this.copies_label_update.TabIndex = 10;
            this.copies_label_update.Text = "# of Available Copies";
            this.copies_label_update.Click += new System.EventHandler(this.label4_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(309, 345);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(86, 31);
            this.update_btn.TabIndex = 9;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // movie_id_box_update
            // 
            this.movie_id_box_update.Location = new System.Drawing.Point(105, 152);
            this.movie_id_box_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movie_id_box_update.Name = "movie_id_box_update";
            this.movie_id_box_update.Size = new System.Drawing.Size(114, 27);
            this.movie_id_box_update.TabIndex = 7;
            this.movie_id_box_update.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // copies_box_update
            // 
            this.copies_box_update.Location = new System.Drawing.Point(105, 240);
            this.copies_box_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.copies_box_update.Name = "copies_box_update";
            this.copies_box_update.Size = new System.Drawing.Size(114, 27);
            this.copies_box_update.TabIndex = 6;
            this.copies_box_update.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // ViewMovie
            // 
            this.ViewMovie.Controls.Add(this.view_header);
            this.ViewMovie.Controls.Add(this.gen_movies_btn);
            this.ViewMovie.Location = new System.Drawing.Point(4, 29);
            this.ViewMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewMovie.Name = "ViewMovie";
            this.ViewMovie.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewMovie.Size = new System.Drawing.Size(879, 535);
            this.ViewMovie.TabIndex = 3;
            this.ViewMovie.Text = "View Movies";
            this.ViewMovie.UseVisualStyleBackColor = true;
            // 
            // view_header
            // 
            this.view_header.AutoSize = true;
            this.view_header.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.view_header.Location = new System.Drawing.Point(229, 68);
            this.view_header.Name = "view_header";
            this.view_header.Size = new System.Drawing.Size(413, 32);
            this.view_header.TabIndex = 11;
            this.view_header.Text = "Display current movies in the system";
            // 
            // gen_movies_btn
            // 
            this.gen_movies_btn.Location = new System.Drawing.Point(321, 176);
            this.gen_movies_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gen_movies_btn.Name = "gen_movies_btn";
            this.gen_movies_btn.Size = new System.Drawing.Size(190, 31);
            this.gen_movies_btn.TabIndex = 10;
            this.gen_movies_btn.Text = "Generate Movies";
            this.gen_movies_btn.UseVisualStyleBackColor = true;
            // 
            // ViewCopies
            // 
            this.ViewCopies.Controls.Add(this.label3);
            this.ViewCopies.Controls.Add(this.button3);
            this.ViewCopies.Controls.Add(this.textBox1);
            this.ViewCopies.Location = new System.Drawing.Point(4, 29);
            this.ViewCopies.Name = "ViewCopies";
            this.ViewCopies.Size = new System.Drawing.Size(879, 535);
            this.ViewCopies.TabIndex = 4;
            this.ViewCopies.Text = "View Copies";
            this.ViewCopies.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 481);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(230, 467);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 55);
            this.button3.TabIndex = 1;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(70, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Movie ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(879, 535);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Add Copies";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(156, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter copy detail to add copy";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(456, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Movie ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Copy Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "num";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(465, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 345);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(465, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 47);
            this.button4.TabIndex = 8;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(879, 535);
            this.tabPage4.TabIndex = 6;
            this.tabPage4.Text = "Remove Copy";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Copy ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(101, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(316, 31);
            this.label12.TabIndex = 1;
            this.label12.Text = "Remove copy from database";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(101, 227);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(101, 334);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 62);
            this.button5.TabIndex = 3;
            this.button5.Text = "Remove";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // emp_movie_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "emp_movie_form";
            this.Text = "Movie";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.movieID_label.ResumeLayout(false);
            this.movieID_label.PerformLayout();
            this.ViewMovie.ResumeLayout(false);
            this.ViewMovie.PerformLayout();
            this.ViewCopies.ResumeLayout(false);
            this.ViewCopies.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private RichTextBox movie_cast_box;
        private TextBox genre_movie_box;
        private TextBox movie_text_box;
        private TabPage tabPage2;
        private TabPage movieID_label;
        private TabPage ViewMovie;
        private Button button1;
        private Button button2;
        private TextBox textBox6;
        private Button update_btn;
        private TextBox movie_id_box_update;
        private TextBox copies_box_update;
        private Button gen_movies_btn;
        private Label movie_cast_label;
        private Label copies_movie_label;
        private Label genre_movie_label;
        private Label movie_name_label;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label copies_label_update;
        private Label view_header;
        private TabPage ViewCopies;
        private Label label3;
        private Button button3;
        private TextBox textBox1;
        private TabPage tabPage3;
        private Button button4;
        private TextBox textBox4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private TabPage tabPage4;
        private Button button5;
        private TextBox textBox5;
        private Label label12;
        private Label label11;
    }
}