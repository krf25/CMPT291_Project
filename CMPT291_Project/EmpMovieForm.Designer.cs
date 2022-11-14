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
            this.copies_movie_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.movie_cast_box = new System.Windows.Forms.RichTextBox();
            this.genre_movie_box = new System.Windows.Forms.TextBox();
            this.movie_text_box = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.movieID_label = new System.Windows.Forms.TabPage();
            this.update_btn = new System.Windows.Forms.Button();
            this.movie_id_box_update = new System.Windows.Forms.TextBox();
            this.copies_box_update = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gen_movies_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.movie_name_label = new System.Windows.Forms.Label();
            this.genre_movie_label = new System.Windows.Forms.Label();
            this.copies_movie_label = new System.Windows.Forms.Label();
            this.movie_cast_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.view_header = new System.Windows.Forms.Label();
            this.copies_label_update = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.movieID_label.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.movieID_label);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.movie_cast_label);
            this.tabPage1.Controls.Add(this.copies_movie_label);
            this.tabPage1.Controls.Add(this.genre_movie_label);
            this.tabPage1.Controls.Add(this.movie_name_label);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.copies_movie_box);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.movie_cast_box);
            this.tabPage1.Controls.Add(this.genre_movie_box);
            this.tabPage1.Controls.Add(this.movie_text_box);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Movie";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // copies_movie_box
            // 
            this.copies_movie_box.Location = new System.Drawing.Point(149, 255);
            this.copies_movie_box.Name = "copies_movie_box";
            this.copies_movie_box.Size = new System.Drawing.Size(100, 23);
            this.copies_movie_box.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Movie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // movie_cast_box
            // 
            this.movie_cast_box.Location = new System.Drawing.Point(329, 119);
            this.movie_cast_box.Name = "movie_cast_box";
            this.movie_cast_box.Size = new System.Drawing.Size(247, 188);
            this.movie_cast_box.TabIndex = 3;
            this.movie_cast_box.Text = "";
            this.movie_cast_box.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // genre_movie_box
            // 
            this.genre_movie_box.Location = new System.Drawing.Point(149, 183);
            this.genre_movie_box.Name = "genre_movie_box";
            this.genre_movie_box.Size = new System.Drawing.Size(100, 23);
            this.genre_movie_box.TabIndex = 2;
            // 
            // movie_text_box
            // 
            this.movie_text_box.Location = new System.Drawing.Point(149, 119);
            this.movie_text_box.Name = "movie_text_box";
            this.movie_text_box.Size = new System.Drawing.Size(100, 23);
            this.movie_text_box.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete Movie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(278, 112);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
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
            this.movieID_label.Location = new System.Drawing.Point(4, 24);
            this.movieID_label.Name = "movieID_label";
            this.movieID_label.Padding = new System.Windows.Forms.Padding(3);
            this.movieID_label.Size = new System.Drawing.Size(768, 398);
            this.movieID_label.TabIndex = 2;
            this.movieID_label.Text = "Update Movie";
            this.movieID_label.UseVisualStyleBackColor = true;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(270, 259);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 9;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // movie_id_box_update
            // 
            this.movie_id_box_update.Location = new System.Drawing.Point(92, 114);
            this.movie_id_box_update.Name = "movie_id_box_update";
            this.movie_id_box_update.Size = new System.Drawing.Size(100, 23);
            this.movie_id_box_update.TabIndex = 7;
            this.movie_id_box_update.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // copies_box_update
            // 
            this.copies_box_update.Location = new System.Drawing.Point(92, 180);
            this.copies_box_update.Name = "copies_box_update";
            this.copies_box_update.Size = new System.Drawing.Size(100, 23);
            this.copies_box_update.TabIndex = 6;
            this.copies_box_update.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.view_header);
            this.tabPage4.Controls.Add(this.gen_movies_btn);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 398);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "View Movies";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gen_movies_btn
            // 
            this.gen_movies_btn.Location = new System.Drawing.Point(281, 132);
            this.gen_movies_btn.Name = "gen_movies_btn";
            this.gen_movies_btn.Size = new System.Drawing.Size(166, 23);
            this.gen_movies_btn.TabIndex = 10;
            this.gen_movies_btn.Text = "Generate Movies";
            this.gen_movies_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter movie details to add new movie";
            // 
            // movie_name_label
            // 
            this.movie_name_label.AutoSize = true;
            this.movie_name_label.Location = new System.Drawing.Point(111, 101);
            this.movie_name_label.Name = "movie_name_label";
            this.movie_name_label.Size = new System.Drawing.Size(65, 15);
            this.movie_name_label.TabIndex = 7;
            this.movie_name_label.Text = "Movie Title";
            this.movie_name_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // genre_movie_label
            // 
            this.genre_movie_label.AutoSize = true;
            this.genre_movie_label.Location = new System.Drawing.Point(111, 164);
            this.genre_movie_label.Name = "genre_movie_label";
            this.genre_movie_label.Size = new System.Drawing.Size(38, 15);
            this.genre_movie_label.TabIndex = 8;
            this.genre_movie_label.Text = "Genre";
            // 
            // copies_movie_label
            // 
            this.copies_movie_label.AutoSize = true;
            this.copies_movie_label.Location = new System.Drawing.Point(111, 237);
            this.copies_movie_label.Name = "copies_movie_label";
            this.copies_movie_label.Size = new System.Drawing.Size(118, 15);
            this.copies_movie_label.TabIndex = 9;
            this.copies_movie_label.Text = "# of Available Copies";
            // 
            // movie_cast_label
            // 
            this.movie_cast_label.AutoSize = true;
            this.movie_cast_label.Location = new System.Drawing.Point(329, 101);
            this.movie_cast_label.Name = "movie_cast_label";
            this.movie_cast_label.Size = new System.Drawing.Size(169, 15);
            this.movie_cast_label.TabIndex = 10;
            this.movie_cast_label.Text = "Movie Cast(comma separated)";
            this.movie_cast_label.Click += new System.EventHandler(this.movie_cast_label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(109, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Movie ID to remove movie from the system";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // view_header
            // 
            this.view_header.AutoSize = true;
            this.view_header.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.view_header.Location = new System.Drawing.Point(200, 51);
            this.view_header.Name = "view_header";
            this.view_header.Size = new System.Drawing.Size(327, 25);
            this.view_header.TabIndex = 11;
            this.view_header.Text = "Display current movies in the system";
            // 
            // copies_label_update
            // 
            this.copies_label_update.AutoSize = true;
            this.copies_label_update.Location = new System.Drawing.Point(72, 162);
            this.copies_label_update.Name = "copies_label_update";
            this.copies_label_update.Size = new System.Drawing.Size(118, 15);
            this.copies_label_update.TabIndex = 10;
            this.copies_label_update.Text = "# of Available Copies";
            this.copies_label_update.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Movie ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(49, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Enter updated movie details";
            // 
            // emp_movie_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "emp_movie_form";
            this.Text = "Movie";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.movieID_label.ResumeLayout(false);
            this.movieID_label.PerformLayout();
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
        private TabPage tabPage4;
        private Button button1;
        private Button button2;
        private TextBox textBox6;
        private Button update_btn;
        private TextBox movie_id_box_update;
        private TextBox copies_box_update;
        private TextBox copies_movie_box;
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
    }
}