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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CIDBox = new System.Windows.Forms.TextBox();
            this.CopyIDBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ReturnOID = new System.Windows.Forms.TextBox();
            this.RentalControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RentalControl1
            // 
            this.RentalControl1.Controls.Add(this.tabPage1);
            this.RentalControl1.Controls.Add(this.tabPage2);
            this.RentalControl1.Location = new System.Drawing.Point(12, 12);
            this.RentalControl1.Name = "RentalControl1";
            this.RentalControl1.SelectedIndex = 0;
            this.RentalControl1.Size = new System.Drawing.Size(590, 426);
            this.RentalControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OrderButton);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CIDBox);
            this.tabPage1.Controls.Add(this.CopyIDBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Rental";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(388, 198);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(107, 23);
            this.OrderButton.TabIndex = 12;
            this.OrderButton.Text = "Submit Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Copy ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.CIDBox.Location = new System.Drawing.Point(266, 134);
            this.CIDBox.Name = "CIDBox";
            this.CIDBox.Size = new System.Drawing.Size(100, 23);
            this.CIDBox.TabIndex = 3;
            // 
            // CopyIDBox
            // 
            this.CopyIDBox.Location = new System.Drawing.Point(80, 134);
            this.CopyIDBox.Name = "CopyIDBox";
            this.CopyIDBox.Size = new System.Drawing.Size(100, 23);
            this.CopyIDBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ReturnButton);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.ReturnOID);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(582, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Return Rental";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(228, 240);
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
            this.label8.Location = new System.Drawing.Point(235, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Order ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(180, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Enter new order details";
            // 
            // ReturnOID
            // 
            this.ReturnOID.Location = new System.Drawing.Point(235, 152);
            this.ReturnOID.Name = "ReturnOID";
            this.ReturnOID.Size = new System.Drawing.Size(100, 23);
            this.ReturnOID.TabIndex = 14;
            // 
            // EmpRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.RentalControl1);
            this.Name = "EmpRental";
            this.Text = "Rental";
            this.RentalControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl RentalControl1;
        private TabPage tabPage1;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox CIDBox;
        private TextBox CopyIDBox;
        private TabPage tabPage2;
        private Button OrderButton;
        private Button ReturnButton;
        private Label label8;
        private Label label10;
        private TextBox ReturnOID;
    }
}