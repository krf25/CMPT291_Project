namespace CMPT291_Project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.user_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(977, 461);
            this.username.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(458, 55);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(977, 621);
            this.password.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(458, 55);
            this.password.TabIndex = 1;
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user_label.Location = new System.Drawing.Point(783, 461);
            this.user_label.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(152, 65);
            this.user_label.TabIndex = 2;
            this.user_label.Text = "Email";
            this.user_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pass_label.Location = new System.Drawing.Point(726, 621);
            this.pass_label.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(240, 65);
            this.pass_label.TabIndex = 3;
            this.pass_label.Text = "Password";
            this.pass_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(1191, 826);
            this.login_button.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(251, 99);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(734, 826);
            this.register_button.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(251, 99);
            this.register_button.TabIndex = 5;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMPT291_Project.Properties.Resources.moviereel;
            this.ClientSize = new System.Drawing.Size(2286, 1440);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox username;
        private TextBox password;
        private Label user_label;
        private Label pass_label;
        private Button login_button;
        private Button register_button;
    }
}