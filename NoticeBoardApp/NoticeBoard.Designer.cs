namespace NoticeBoardApp
{
    partial class NoticeBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticeBoard));
            this.TimeTable = new System.Windows.Forms.Button();
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
            this.TimeTable.Location = new System.Drawing.Point(181, 222);
            this.TimeTable.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.Size = new System.Drawing.Size(473, 83);
            this.TimeTable.TabIndex = 66;
            this.TimeTable.Text = "View Time Table";
            this.TimeTable.UseVisualStyleBackColor = false;
            this.TimeTable.Click += new System.EventHandler(this.TimeTable_Click);
            // 
            // NoticeBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.TimeTable);
            this.Name = "NoticeBoard";
            this.Text = "NoticeBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private Button TimeTable;
    }
}