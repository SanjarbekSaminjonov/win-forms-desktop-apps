namespace CourseWork
{
    partial class Form1
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
            this.newStudent = new System.Windows.Forms.Button();
            this.viewStudents = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newStudent
            // 
            this.newStudent.BackColor = System.Drawing.Color.Orange;
            this.newStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newStudent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newStudent.ForeColor = System.Drawing.Color.Black;
            this.newStudent.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newStudent.Location = new System.Drawing.Point(183, 286);
            this.newStudent.Name = "newStudent";
            this.newStudent.Size = new System.Drawing.Size(184, 76);
            this.newStudent.TabIndex = 0;
            this.newStudent.Text = "Yangi talaba qo\'shish";
            this.newStudent.UseVisualStyleBackColor = false;
            this.newStudent.Click += new System.EventHandler(this.newStudent_Click);
            // 
            // viewStudents
            // 
            this.viewStudents.BackColor = System.Drawing.Color.Orange;
            this.viewStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewStudents.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewStudents.ForeColor = System.Drawing.Color.Black;
            this.viewStudents.Location = new System.Drawing.Point(399, 286);
            this.viewStudents.Name = "viewStudents";
            this.viewStudents.Size = new System.Drawing.Size(184, 76);
            this.viewStudents.TabIndex = 1;
            this.viewStudents.Text = "Talaba va baholarni ko\'rish";
            this.viewStudents.UseVisualStyleBackColor = false;
            this.viewStudents.Click += new System.EventHandler(this.viewStudents_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Orange;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(615, 286);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(184, 76);
            this.exit.TabIndex = 2;
            this.exit.Text = "Dasturdan chiqish";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CourseWork.Properties.Resources.university_105709_960_720;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.viewStudents);
            this.Controls.Add(this.newStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baholar qaydnomasi tizimi";
            this.ResumeLayout(false);

        }

        #endregion

        private Button newStudent;
        private Button viewStudents;
        private Button exit;
    }
}