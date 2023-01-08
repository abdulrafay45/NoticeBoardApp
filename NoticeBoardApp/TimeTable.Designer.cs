namespace NoticeBoardApp
{
    partial class TimeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTable));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewTimeTable = new System.Windows.Forms.Button();
            this.degreeCombo = new System.Windows.Forms.ComboBox();
            this.semesterCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(59, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 42);
            this.label1.TabIndex = 73;
            this.label1.Text = "Degree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(437, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 42);
            this.label2.TabIndex = 74;
            this.label2.Text = "Semester";
            // 
            // viewTimeTable
            // 
            this.viewTimeTable.BackColor = System.Drawing.Color.RoyalBlue;
            this.viewTimeTable.FlatAppearance.BorderSize = 3;
            this.viewTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTimeTable.Font = new System.Drawing.Font("Arial Black", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.viewTimeTable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewTimeTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewTimeTable.Location = new System.Drawing.Point(129, 323);
            this.viewTimeTable.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.viewTimeTable.Name = "viewTimeTable";
            this.viewTimeTable.Size = new System.Drawing.Size(482, 83);
            this.viewTimeTable.TabIndex = 75;
            this.viewTimeTable.Text = "View Time table";
            this.viewTimeTable.UseVisualStyleBackColor = false;
            this.viewTimeTable.Click += new System.EventHandler(this.viewTimeTable_Click);
            // 
            // degreeCombo
            // 
            this.degreeCombo.FormattingEnabled = true;
            this.degreeCombo.Location = new System.Drawing.Point(63, 142);
            this.degreeCombo.Name = "degreeCombo";
            this.degreeCombo.Size = new System.Drawing.Size(285, 33);
            this.degreeCombo.TabIndex = 76;
            // 
            // semesterCombo
            // 
            this.semesterCombo.FormattingEnabled = true;
            this.semesterCombo.Location = new System.Drawing.Point(437, 142);
            this.semesterCombo.Name = "semesterCombo";
            this.semesterCombo.Size = new System.Drawing.Size(278, 33);
            this.semesterCombo.TabIndex = 77;
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.semesterCombo);
            this.Controls.Add(this.degreeCombo);
            this.Controls.Add(this.viewTimeTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TimeTable";
            this.Text = "TimeTable";
            this.Load += new System.EventHandler(this.TimeTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button viewTimeTable;
        private ComboBox degreeCombo;
        private ComboBox semesterCombo;
    }
}