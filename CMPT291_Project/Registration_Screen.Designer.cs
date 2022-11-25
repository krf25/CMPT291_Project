namespace CMPT291_Group3_Project
{
    partial class Registration_Screen
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
            this.bkround_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.Login_redirect_button = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.password_confirm = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confirm_password_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bkround_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bkround_panel
            // 
            this.bkround_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bkround_panel.Controls.Add(this.label2);
            this.bkround_panel.Controls.Add(this.email);
            this.bkround_panel.Controls.Add(this.Login_redirect_button);
            this.bkround_panel.Controls.Add(this.Register_button);
            this.bkround_panel.Controls.Add(this.password_confirm);
            this.bkround_panel.Controls.Add(this.password);
            this.bkround_panel.Controls.Add(this.confirm_password_label);
            this.bkround_panel.Controls.Add(this.password_label);
            this.bkround_panel.Controls.Add(this.label1);
            this.bkround_panel.Location = new System.Drawing.Point(185, 23);
            this.bkround_panel.Name = "bkround_panel";
            this.bkround_panel.Size = new System.Drawing.Size(459, 356);
            this.bkround_panel.TabIndex = 0;
            this.bkround_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.bkround_panel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Email:";
            // 
            // email
            // 
            this.email.AccessibleName = "email";
            this.email.Location = new System.Drawing.Point(154, 86);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(211, 23);
            this.email.TabIndex = 9;
            // 
            // Login_redirect_button
            // 
            this.Login_redirect_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Login_redirect_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_redirect_button.Location = new System.Drawing.Point(83, 255);
            this.Login_redirect_button.Name = "Login_redirect_button";
            this.Login_redirect_button.Size = new System.Drawing.Size(293, 39);
            this.Login_redirect_button.TabIndex = 8;
            this.Login_redirect_button.Text = "Already have an account? Login";
            this.Login_redirect_button.UseVisualStyleBackColor = false;
            this.Login_redirect_button.Click += new System.EventHandler(this.Login_redirect_button_Click);
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Register_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Register_button.Location = new System.Drawing.Point(83, 210);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(293, 39);
            this.Register_button.TabIndex = 7;
            this.Register_button.Text = "Register Account";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // password_confirm
            // 
            this.password_confirm.Location = new System.Drawing.Point(154, 147);
            this.password_confirm.Name = "password_confirm";
            this.password_confirm.Size = new System.Drawing.Size(211, 23);
            this.password_confirm.TabIndex = 6;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(154, 115);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(211, 23);
            this.password.TabIndex = 5;
            // 
            // confirm_password_label
            // 
            this.confirm_password_label.AutoSize = true;
            this.confirm_password_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm_password_label.Location = new System.Drawing.Point(9, 149);
            this.confirm_password_label.Name = "confirm_password_label";
            this.confirm_password_label.Size = new System.Drawing.Size(140, 21);
            this.confirm_password_label.TabIndex = 3;
            this.confirm_password_label.Text = "Confirm Password:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_label.Location = new System.Drawing.Point(30, 117);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(119, 21);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Enter Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Registration_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMPT291_Project.Properties.Resources.moviereel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bkround_panel);
            this.Name = "Registration_Screen";
            this.Text = "Account Registration";
            this.Load += new System.EventHandler(this.Registration_Screen_Load);
            this.bkround_panel.ResumeLayout(false);
            this.bkround_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel bkround_panel;
        private Label label1;
        private Button Login_redirect_button;
        private Button Register_button;
        private TextBox password_confirm;
        private TextBox password;
        private Label confirm_password_label;
        private Label password_label;
        private Label label2;
        private TextBox email;
    }
}