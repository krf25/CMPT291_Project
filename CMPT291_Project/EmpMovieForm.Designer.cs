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
            this.ViewMovie = new System.Windows.Forms.TabPage();
            this.view_header = new System.Windows.Forms.Label();
            this.gen_movies_btn = new System.Windows.Forms.Button();
            this.AddMovie = new System.Windows.Forms.TabPage();
            this.movie_cast_label = new System.Windows.Forms.Label();
            this.copies_movie_label = new System.Windows.Forms.Label();
            this.genre_movie_label = new System.Windows.Forms.Label();
            this.movie_name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.movie_cast_box = new System.Windows.Forms.RichTextBox();
            this.genre_movie_box = new System.Windows.Forms.TextBox();
            this.movie_text_box = new System.Windows.Forms.TextBox();
            this.EditMovie = new System.Windows.Forms.TabPage();
            this.DeleteMovie = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteMovieButton = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.AddActor = new System.Windows.Forms.TabPage();
            this.EditActor = new System.Windows.Forms.TabPage();
            this.RemoveActor = new System.Windows.Forms.TabPage();
            this.ViewCopies = new System.Windows.Forms.TabPage();
            this.CopyTypeSearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CopyDisplay = new System.Windows.Forms.DataGridView();
            this.CPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.FindCopies = new System.Windows.Forms.Button();
            this.MovieIDSearch = new System.Windows.Forms.TextBox();
            this.AddEditCopies = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditCPIDButton = new System.Windows.Forms.Button();
            this.CopyStateEdit = new System.Windows.Forms.TextBox();
            this.CopyIDEdit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EditCopyButton = new System.Windows.Forms.Button();
            this.CopyTypeEdit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddCopiesButton = new System.Windows.Forms.Button();
            this.Add_NumCopies_Box = new System.Windows.Forms.TextBox();
            this.Add_CopyType_Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Add_MID_Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RemoveCopy = new System.Windows.Forms.TabPage();
            this.RemoveCopiesButton = new System.Windows.Forms.Button();
            this.CPID_Delete_Box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ViewMovie.SuspendLayout();
            this.AddMovie.SuspendLayout();
            this.DeleteMovie.SuspendLayout();
            this.ViewCopies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CopyDisplay)).BeginInit();
            this.AddEditCopies.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.RemoveCopy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ViewMovie);
            this.tabControl1.Controls.Add(this.AddMovie);
            this.tabControl1.Controls.Add(this.EditMovie);
            this.tabControl1.Controls.Add(this.DeleteMovie);
            this.tabControl1.Controls.Add(this.AddActor);
            this.tabControl1.Controls.Add(this.EditActor);
            this.tabControl1.Controls.Add(this.RemoveActor);
            this.tabControl1.Controls.Add(this.ViewCopies);
            this.tabControl1.Controls.Add(this.AddEditCopies);
            this.tabControl1.Controls.Add(this.RemoveCopy);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 441);
            this.tabControl1.TabIndex = 0;
            // 
            // ViewMovie
            // 
            this.ViewMovie.Controls.Add(this.view_header);
            this.ViewMovie.Controls.Add(this.gen_movies_btn);
            this.ViewMovie.Location = new System.Drawing.Point(4, 24);
            this.ViewMovie.Name = "ViewMovie";
            this.ViewMovie.Padding = new System.Windows.Forms.Padding(3);
            this.ViewMovie.Size = new System.Drawing.Size(777, 413);
            this.ViewMovie.TabIndex = 3;
            this.ViewMovie.Text = "View Movies";
            this.ViewMovie.UseVisualStyleBackColor = true;
            // 
            // view_header
            // 
            this.view_header.AutoSize = true;
            this.view_header.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.view_header.Location = new System.Drawing.Point(175, 129);
            this.view_header.Name = "view_header";
            this.view_header.Size = new System.Drawing.Size(327, 25);
            this.view_header.TabIndex = 11;
            this.view_header.Text = "Display current movies in the system";
            // 
            // gen_movies_btn
            // 
            this.gen_movies_btn.Location = new System.Drawing.Point(256, 210);
            this.gen_movies_btn.Name = "gen_movies_btn";
            this.gen_movies_btn.Size = new System.Drawing.Size(166, 23);
            this.gen_movies_btn.TabIndex = 10;
            this.gen_movies_btn.Text = "Generate Movies";
            this.gen_movies_btn.UseVisualStyleBackColor = true;
            // 
            // AddMovie
            // 
            this.AddMovie.Controls.Add(this.movie_cast_label);
            this.AddMovie.Controls.Add(this.copies_movie_label);
            this.AddMovie.Controls.Add(this.genre_movie_label);
            this.AddMovie.Controls.Add(this.movie_name_label);
            this.AddMovie.Controls.Add(this.label1);
            this.AddMovie.Controls.Add(this.AddMovieButton);
            this.AddMovie.Controls.Add(this.movie_cast_box);
            this.AddMovie.Controls.Add(this.genre_movie_box);
            this.AddMovie.Controls.Add(this.movie_text_box);
            this.AddMovie.Location = new System.Drawing.Point(4, 24);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Padding = new System.Windows.Forms.Padding(3);
            this.AddMovie.Size = new System.Drawing.Size(777, 413);
            this.AddMovie.TabIndex = 0;
            this.AddMovie.Text = "Add Movie";
            this.AddMovie.UseVisualStyleBackColor = true;
            this.AddMovie.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // movie_cast_label
            // 
            this.movie_cast_label.AutoSize = true;
            this.movie_cast_label.Location = new System.Drawing.Point(363, 106);
            this.movie_cast_label.Name = "movie_cast_label";
            this.movie_cast_label.Size = new System.Drawing.Size(169, 15);
            this.movie_cast_label.TabIndex = 10;
            this.movie_cast_label.Text = "Movie Cast(comma separated)";
            this.movie_cast_label.Click += new System.EventHandler(this.movie_cast_label_Click);
            // 
            // copies_movie_label
            // 
            this.copies_movie_label.AutoSize = true;
            this.copies_movie_label.Location = new System.Drawing.Point(145, 242);
            this.copies_movie_label.Name = "copies_movie_label";
            this.copies_movie_label.Size = new System.Drawing.Size(0, 15);
            this.copies_movie_label.TabIndex = 9;
            // 
            // genre_movie_label
            // 
            this.genre_movie_label.AutoSize = true;
            this.genre_movie_label.Location = new System.Drawing.Point(145, 189);
            this.genre_movie_label.Name = "genre_movie_label";
            this.genre_movie_label.Size = new System.Drawing.Size(38, 15);
            this.genre_movie_label.TabIndex = 8;
            this.genre_movie_label.Text = "Genre";
            // 
            // movie_name_label
            // 
            this.movie_name_label.AutoSize = true;
            this.movie_name_label.Location = new System.Drawing.Point(145, 106);
            this.movie_name_label.Name = "movie_name_label";
            this.movie_name_label.Size = new System.Drawing.Size(65, 15);
            this.movie_name_label.TabIndex = 7;
            this.movie_name_label.Text = "Movie Title";
            this.movie_name_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter movie details to add new movie";
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.Location = new System.Drawing.Point(183, 288);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(75, 23);
            this.AddMovieButton.TabIndex = 4;
            this.AddMovieButton.Text = "Add Movie";
            this.AddMovieButton.UseVisualStyleBackColor = true;
            // 
            // movie_cast_box
            // 
            this.movie_cast_box.Location = new System.Drawing.Point(363, 124);
            this.movie_cast_box.Name = "movie_cast_box";
            this.movie_cast_box.Size = new System.Drawing.Size(247, 188);
            this.movie_cast_box.TabIndex = 3;
            this.movie_cast_box.Text = "";
            this.movie_cast_box.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // genre_movie_box
            // 
            this.genre_movie_box.Location = new System.Drawing.Point(183, 207);
            this.genre_movie_box.Name = "genre_movie_box";
            this.genre_movie_box.Size = new System.Drawing.Size(100, 23);
            this.genre_movie_box.TabIndex = 2;
            // 
            // movie_text_box
            // 
            this.movie_text_box.Location = new System.Drawing.Point(183, 124);
            this.movie_text_box.Name = "movie_text_box";
            this.movie_text_box.Size = new System.Drawing.Size(100, 23);
            this.movie_text_box.TabIndex = 0;
            // 
            // EditMovie
            // 
            this.EditMovie.Location = new System.Drawing.Point(4, 24);
            this.EditMovie.Name = "EditMovie";
            this.EditMovie.Size = new System.Drawing.Size(777, 413);
            this.EditMovie.TabIndex = 10;
            this.EditMovie.Text = "Edit Movie";
            this.EditMovie.UseVisualStyleBackColor = true;
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.Controls.Add(this.label2);
            this.DeleteMovie.Controls.Add(this.DeleteMovieButton);
            this.DeleteMovie.Controls.Add(this.textBox6);
            this.DeleteMovie.Location = new System.Drawing.Point(4, 24);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteMovie.Size = new System.Drawing.Size(777, 413);
            this.DeleteMovie.TabIndex = 1;
            this.DeleteMovie.Text = "Delete Movie";
            this.DeleteMovie.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(149, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Movie ID to remove movie from the system";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // DeleteMovieButton
            // 
            this.DeleteMovieButton.Location = new System.Drawing.Point(332, 217);
            this.DeleteMovieButton.Name = "DeleteMovieButton";
            this.DeleteMovieButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteMovieButton.TabIndex = 9;
            this.DeleteMovieButton.Text = "Delete ";
            this.DeleteMovieButton.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(318, 174);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 5;
            // 
            // AddActor
            // 
            this.AddActor.Location = new System.Drawing.Point(4, 24);
            this.AddActor.Name = "AddActor";
            this.AddActor.Padding = new System.Windows.Forms.Padding(3);
            this.AddActor.Size = new System.Drawing.Size(777, 413);
            this.AddActor.TabIndex = 7;
            this.AddActor.Text = "Add Actor";
            this.AddActor.UseVisualStyleBackColor = true;
            // 
            // EditActor
            // 
            this.EditActor.Location = new System.Drawing.Point(4, 24);
            this.EditActor.Name = "EditActor";
            this.EditActor.Size = new System.Drawing.Size(777, 413);
            this.EditActor.TabIndex = 9;
            this.EditActor.Text = "Edit Actor";
            this.EditActor.UseVisualStyleBackColor = true;
            // 
            // RemoveActor
            // 
            this.RemoveActor.Location = new System.Drawing.Point(4, 24);
            this.RemoveActor.Name = "RemoveActor";
            this.RemoveActor.Size = new System.Drawing.Size(777, 413);
            this.RemoveActor.TabIndex = 8;
            this.RemoveActor.Text = "Remove Actor";
            this.RemoveActor.UseVisualStyleBackColor = true;
            // 
            // ViewCopies
            // 
            this.ViewCopies.Controls.Add(this.CopyTypeSearch);
            this.ViewCopies.Controls.Add(this.label14);
            this.ViewCopies.Controls.Add(this.CopyDisplay);
            this.ViewCopies.Controls.Add(this.label3);
            this.ViewCopies.Controls.Add(this.FindCopies);
            this.ViewCopies.Controls.Add(this.MovieIDSearch);
            this.ViewCopies.Location = new System.Drawing.Point(4, 24);
            this.ViewCopies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewCopies.Name = "ViewCopies";
            this.ViewCopies.Size = new System.Drawing.Size(777, 413);
            this.ViewCopies.TabIndex = 4;
            this.ViewCopies.Text = "View Copies";
            this.ViewCopies.UseVisualStyleBackColor = true;
            this.ViewCopies.Click += new System.EventHandler(this.ViewCopies_Click);
            // 
            // CopyTypeSearch
            // 
            this.CopyTypeSearch.Location = new System.Drawing.Point(560, 194);
            this.CopyTypeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CopyTypeSearch.Name = "CopyTypeSearch";
            this.CopyTypeSearch.Size = new System.Drawing.Size(110, 23);
            this.CopyTypeSearch.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(560, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Copy Type";
            // 
            // CopyDisplay
            // 
            this.CopyDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CopyDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPID,
            this.MID,
            this.mType,
            this.State});
            this.CopyDisplay.Location = new System.Drawing.Point(33, 20);
            this.CopyDisplay.Name = "CopyDisplay";
            this.CopyDisplay.RowTemplate.Height = 25;
            this.CopyDisplay.Size = new System.Drawing.Size(445, 352);
            this.CopyDisplay.TabIndex = 3;
            // 
            // CPID
            // 
            this.CPID.HeaderText = "CPID";
            this.CPID.Name = "CPID";
            // 
            // MID
            // 
            this.MID.HeaderText = "MID";
            this.MID.Name = "MID";
            // 
            // mType
            // 
            this.mType.HeaderText = "mType";
            this.mType.Name = "mType";
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(560, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Movie ID";
            // 
            // FindCopies
            // 
            this.FindCopies.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindCopies.Location = new System.Drawing.Point(590, 331);
            this.FindCopies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindCopies.Name = "FindCopies";
            this.FindCopies.Size = new System.Drawing.Size(150, 41);
            this.FindCopies.TabIndex = 1;
            this.FindCopies.Text = "Find";
            this.FindCopies.UseVisualStyleBackColor = true;
            this.FindCopies.Click += new System.EventHandler(this.FindCopies_Click);
            // 
            // MovieIDSearch
            // 
            this.MovieIDSearch.Location = new System.Drawing.Point(560, 94);
            this.MovieIDSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieIDSearch.Name = "MovieIDSearch";
            this.MovieIDSearch.Size = new System.Drawing.Size(110, 23);
            this.MovieIDSearch.TabIndex = 0;
            // 
            // AddEditCopies
            // 
            this.AddEditCopies.Controls.Add(this.label5);
            this.AddEditCopies.Controls.Add(this.label4);
            this.AddEditCopies.Controls.Add(this.panel2);
            this.AddEditCopies.Controls.Add(this.panel1);
            this.AddEditCopies.Location = new System.Drawing.Point(4, 24);
            this.AddEditCopies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddEditCopies.Name = "AddEditCopies";
            this.AddEditCopies.Size = new System.Drawing.Size(777, 413);
            this.AddEditCopies.TabIndex = 5;
            this.AddEditCopies.Text = "Add/Edit Copies";
            this.AddEditCopies.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(401, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enter copy Id then any changes to edit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter copy detail to add copy";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.EditCPIDButton);
            this.panel2.Controls.Add(this.CopyStateEdit);
            this.panel2.Controls.Add(this.CopyIDEdit);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.EditCopyButton);
            this.panel2.Controls.Add(this.CopyTypeEdit);
            this.panel2.Location = new System.Drawing.Point(414, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 269);
            this.panel2.TabIndex = 18;
            // 
            // EditCPIDButton
            // 
            this.EditCPIDButton.Location = new System.Drawing.Point(177, 40);
            this.EditCPIDButton.Name = "EditCPIDButton";
            this.EditCPIDButton.Size = new System.Drawing.Size(97, 24);
            this.EditCPIDButton.TabIndex = 19;
            this.EditCPIDButton.Text = "Edit";
            this.EditCPIDButton.UseVisualStyleBackColor = true;
            this.EditCPIDButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CopyStateEdit
            // 
            this.CopyStateEdit.Location = new System.Drawing.Point(177, 120);
            this.CopyStateEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CopyStateEdit.Name = "CopyStateEdit";
            this.CopyStateEdit.Size = new System.Drawing.Size(110, 23);
            this.CopyStateEdit.TabIndex = 18;
            // 
            // CopyIDEdit
            // 
            this.CopyIDEdit.Location = new System.Drawing.Point(24, 40);
            this.CopyIDEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CopyIDEdit.Name = "CopyIDEdit";
            this.CopyIDEdit.Size = new System.Drawing.Size(110, 23);
            this.CopyIDEdit.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "CPID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(177, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 17;
            this.label15.Text = "Copy State";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Copy Type";
            // 
            // EditCopyButton
            // 
            this.EditCopyButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditCopyButton.Location = new System.Drawing.Point(92, 189);
            this.EditCopyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditCopyButton.Name = "EditCopyButton";
            this.EditCopyButton.Size = new System.Drawing.Size(129, 51);
            this.EditCopyButton.TabIndex = 16;
            this.EditCopyButton.Text = "Confirm Edit";
            this.EditCopyButton.UseVisualStyleBackColor = true;
            this.EditCopyButton.Click += new System.EventHandler(this.EditCopyButton_Click);
            // 
            // CopyTypeEdit
            // 
            this.CopyTypeEdit.Location = new System.Drawing.Point(24, 120);
            this.CopyTypeEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CopyTypeEdit.Name = "CopyTypeEdit";
            this.CopyTypeEdit.Size = new System.Drawing.Size(110, 23);
            this.CopyTypeEdit.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.AddCopiesButton);
            this.panel1.Controls.Add(this.Add_NumCopies_Box);
            this.panel1.Controls.Add(this.Add_CopyType_Box);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Add_MID_Box);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(32, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 269);
            this.panel1.TabIndex = 17;
            // 
            // AddCopiesButton
            // 
            this.AddCopiesButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCopiesButton.Location = new System.Drawing.Point(180, 145);
            this.AddCopiesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCopiesButton.Name = "AddCopiesButton";
            this.AddCopiesButton.Size = new System.Drawing.Size(93, 35);
            this.AddCopiesButton.TabIndex = 8;
            this.AddCopiesButton.Text = "Add";
            this.AddCopiesButton.UseVisualStyleBackColor = true;
            this.AddCopiesButton.Click += new System.EventHandler(this.AddCopiesButton_Click);
            // 
            // Add_NumCopies_Box
            // 
            this.Add_NumCopies_Box.Location = new System.Drawing.Point(12, 145);
            this.Add_NumCopies_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_NumCopies_Box.Name = "Add_NumCopies_Box";
            this.Add_NumCopies_Box.Size = new System.Drawing.Size(110, 23);
            this.Add_NumCopies_Box.TabIndex = 7;
            // 
            // Add_CopyType_Box
            // 
            this.Add_CopyType_Box.Location = new System.Drawing.Point(180, 40);
            this.Add_CopyType_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_CopyType_Box.Name = "Add_CopyType_Box";
            this.Add_CopyType_Box.Size = new System.Drawing.Size(110, 23);
            this.Add_CopyType_Box.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Number of copies";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(180, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Copy Type";
            // 
            // Add_MID_Box
            // 
            this.Add_MID_Box.Location = new System.Drawing.Point(12, 40);
            this.Add_MID_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_MID_Box.Name = "Add_MID_Box";
            this.Add_MID_Box.Size = new System.Drawing.Size(110, 23);
            this.Add_MID_Box.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Movie ID";
            // 
            // RemoveCopy
            // 
            this.RemoveCopy.Controls.Add(this.RemoveCopiesButton);
            this.RemoveCopy.Controls.Add(this.CPID_Delete_Box);
            this.RemoveCopy.Controls.Add(this.label12);
            this.RemoveCopy.Controls.Add(this.label11);
            this.RemoveCopy.Location = new System.Drawing.Point(4, 24);
            this.RemoveCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveCopy.Name = "RemoveCopy";
            this.RemoveCopy.Size = new System.Drawing.Size(777, 413);
            this.RemoveCopy.TabIndex = 6;
            this.RemoveCopy.Text = "Remove Copy";
            this.RemoveCopy.UseVisualStyleBackColor = true;
            // 
            // RemoveCopiesButton
            // 
            this.RemoveCopiesButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveCopiesButton.Location = new System.Drawing.Point(336, 248);
            this.RemoveCopiesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveCopiesButton.Name = "RemoveCopiesButton";
            this.RemoveCopiesButton.Size = new System.Drawing.Size(109, 46);
            this.RemoveCopiesButton.TabIndex = 3;
            this.RemoveCopiesButton.Text = "Remove";
            this.RemoveCopiesButton.UseVisualStyleBackColor = true;
            this.RemoveCopiesButton.Click += new System.EventHandler(this.RemoveCopiesButton_Click);
            // 
            // CPID_Delete_Box
            // 
            this.CPID_Delete_Box.Location = new System.Drawing.Point(335, 168);
            this.CPID_Delete_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CPID_Delete_Box.Name = "CPID_Delete_Box";
            this.CPID_Delete_Box.Size = new System.Drawing.Size(110, 23);
            this.CPID_Delete_Box.TabIndex = 2;
            this.CPID_Delete_Box.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(259, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(264, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Remove copy from database";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Copy ID";
            // 
            // emp_movie_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 465);
            this.Controls.Add(this.tabControl1);
            this.Name = "emp_movie_form";
            this.Text = "Movie";
            this.tabControl1.ResumeLayout(false);
            this.ViewMovie.ResumeLayout(false);
            this.ViewMovie.PerformLayout();
            this.AddMovie.ResumeLayout(false);
            this.AddMovie.PerformLayout();
            this.DeleteMovie.ResumeLayout(false);
            this.DeleteMovie.PerformLayout();
            this.ViewCopies.ResumeLayout(false);
            this.ViewCopies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CopyDisplay)).EndInit();
            this.AddEditCopies.ResumeLayout(false);
            this.AddEditCopies.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RemoveCopy.ResumeLayout(false);
            this.RemoveCopy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage AddMovie;
        private RichTextBox movie_cast_box;
        private TextBox genre_movie_box;
        private TextBox movie_text_box;
        private TabPage DeleteMovie;
        private TabPage ViewMovie;
        private Button AddMovieButton;
        private Button DeleteMovieButton;
        private TextBox textBox6;
        private Button gen_movies_btn;
        private Label movie_cast_label;
        private Label copies_movie_label;
        private Label genre_movie_label;
        private Label movie_name_label;
        private Label label1;
        private Label label2;
        private Label view_header;
        private TabPage ViewCopies;
        private Label label3;
        private Button FindCopies;
        private TextBox MovieIDSearch;
        private TabPage AddEditCopies;
        private Button AddCopiesButton;
        private TextBox Add_NumCopies_Box;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox Add_CopyType_Box;
        private TextBox Add_MID_Box;
        private Label label4;
        private TabPage RemoveCopy;
        private Button RemoveCopiesButton;
        private TextBox CPID_Delete_Box;
        private Label label12;
        private Label label11;
        private TabPage AddActor;
        private TabPage RemoveActor;
        private TabPage EditActor;
        private TabPage EditMovie;
        private DataGridView CopyDisplay;
        private TextBox CopyTypeSearch;
        private Label label14;
        private DataGridViewTextBoxColumn CPID;
        private DataGridViewTextBoxColumn MID;
        private DataGridViewTextBoxColumn mType;
        private DataGridViewTextBoxColumn State;
        private Label label5;
        private Panel panel2;
        private Button EditCPIDButton;
        private TextBox CopyStateEdit;
        private TextBox CopyIDEdit;
        private Label label13;
        private Label label15;
        private Label label10;
        private Button EditCopyButton;
        private TextBox CopyTypeEdit;
        private Panel panel1;
    }
}