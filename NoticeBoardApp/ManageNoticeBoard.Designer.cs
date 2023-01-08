namespace NoticeBoardApp
{
    partial class ManageNoticeBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageNoticeBoard));
            this.TimeTable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeTable
            // 
            this.TimeTable.BackColor = System.Drawing.Color.RoyalBlue;
            this.TimeTable.FlatAppearance.BorderSize = 3;
            this.TimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeTable.Font = new System.Drawing.Font("Arial Black", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TimeTable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TimeTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeTable.Location = new System.Drawing.Point(240, 104);
            this.TimeTable.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.Size = new System.Drawing.Size(330, 143);
            this.TimeTable.TabIndex = 40;
            this.TimeTable.Text = "Manage Time Table";
            this.TimeTable.UseVisualStyleBackColor = false;
            this.TimeTable.Click += new System.EventHandler(this.TimeTable_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(240, 324);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 146);
            this.button1.TabIndex = 41;
            this.button1.Text = "Manage Events";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageNoticeBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimeTable);
            this.Name = "ManageNoticeBoard";
            this.Text = "ManageNoticeBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private Button TimeTable;
        private Button button1;
    }
}