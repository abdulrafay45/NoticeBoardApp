namespace NoticeBoardApp
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.label1 = new System.Windows.Forms.Label();
            this.UserBtn = new System.Windows.Forms.Button();
            this.AdminBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 65);
            this.label1.TabIndex = 44;
            this.label1.Text = "Welcome to Notice Board App";
            // 
            // UserBtn
            // 
            this.UserBtn.BackColor = System.Drawing.Color.Transparent;
            this.UserBtn.FlatAppearance.BorderSize = 3;
            this.UserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserBtn.Font = new System.Drawing.Font("Arial Black", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UserBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserBtn.Image = ((System.Drawing.Image)(resources.GetObject("UserBtn.Image")));
            this.UserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserBtn.Location = new System.Drawing.Point(256, 346);
            this.UserBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(296, 121);
            this.UserBtn.TabIndex = 43;
            this.UserBtn.Text = "User";
            this.UserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserBtn.UseVisualStyleBackColor = false;
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // AdminBTN
            // 
            this.AdminBTN.BackColor = System.Drawing.Color.Transparent;
            this.AdminBTN.FlatAppearance.BorderSize = 3;
            this.AdminBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminBTN.Font = new System.Drawing.Font("Arial Black", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AdminBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AdminBTN.Image = ((System.Drawing.Image)(resources.GetObject("AdminBTN.Image")));
            this.AdminBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminBTN.Location = new System.Drawing.Point(256, 147);
            this.AdminBTN.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.AdminBTN.Name = "AdminBTN";
            this.AdminBTN.Size = new System.Drawing.Size(296, 121);
            this.AdminBTN.TabIndex = 42;
            this.AdminBTN.Text = "Admin";
            this.AdminBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdminBTN.UseVisualStyleBackColor = false;
            this.AdminBTN.Click += new System.EventHandler(this.AdminBTN_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserBtn);
            this.Controls.Add(this.AdminBTN);
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button UserBtn;
        private Button AdminBTN;
    }
}