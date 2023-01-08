namespace NoticeBoardApp
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.SignupBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(108, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 33);
            this.label2.TabIndex = 63;
            this.label2.Text = "PASSWORD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(108, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 62;
            this.label1.Text = "USERNAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(287, 254);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(405, 31);
            this.password.TabIndex = 61;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(287, 200);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(405, 31);
            this.username.TabIndex = 60;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.RoyalBlue;
            this.Login.FlatAppearance.BorderSize = 3;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Arial Black", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login.Location = new System.Drawing.Point(287, 316);
            this.Login.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(405, 83);
            this.Login.TabIndex = 66;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // SignupBTN
            // 
            this.SignupBTN.BackColor = System.Drawing.Color.Transparent;
            this.SignupBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignupBTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.SignupBTN.FlatAppearance.BorderSize = 0;
            this.SignupBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupBTN.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SignupBTN.ForeColor = System.Drawing.Color.Red;
            this.SignupBTN.Location = new System.Drawing.Point(572, 420);
            this.SignupBTN.Name = "SignupBTN";
            this.SignupBTN.Size = new System.Drawing.Size(120, 45);
            this.SignupBTN.TabIndex = 68;
            this.SignupBTN.Text = "SignUp";
            this.SignupBTN.UseVisualStyleBackColor = false;
            this.SignupBTN.Click += new System.EventHandler(this.SignupBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(287, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 33);
            this.label3.TabIndex = 67;
            this.label3.Text = "Don\'t have account?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 58F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(45, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(730, 82);
            this.label5.TabIndex = 69;
            this.label5.Text = "Login to your account";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SignupBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox password;
        private TextBox username;
        private Button Login;
        private Button SignupBTN;
        private Label label3;
        private Label label5;
    }
}