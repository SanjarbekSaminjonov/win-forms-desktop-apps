namespace CourseWork
{
    partial class Form2
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
            this.title = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.groupNumber = new System.Windows.Forms.TextBox();
            this.currentMark = new System.Windows.Forms.TextBox();
            this.middleMark = new System.Windows.Forms.TextBox();
            this.finalMark = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(294, 41);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(359, 30);
            this.title.TabIndex = 0;
            this.title.Text = "Talaba va uning baholarini kiriting";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fName
            // 
            this.fName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fName.Location = new System.Drawing.Point(203, 185);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(240, 34);
            this.fName.TabIndex = 2;
            // 
            // lName
            // 
            this.lName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lName.Location = new System.Drawing.Point(203, 262);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(240, 34);
            this.lName.TabIndex = 4;
            // 
            // groupNumber
            // 
            this.groupNumber.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupNumber.Location = new System.Drawing.Point(203, 348);
            this.groupNumber.Name = "groupNumber";
            this.groupNumber.Size = new System.Drawing.Size(240, 34);
            this.groupNumber.TabIndex = 6;
            // 
            // currentMark
            // 
            this.currentMark.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentMark.Location = new System.Drawing.Point(521, 185);
            this.currentMark.Name = "currentMark";
            this.currentMark.Size = new System.Drawing.Size(240, 34);
            this.currentMark.TabIndex = 8;
            this.currentMark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currentMark_KeyPress);
            // 
            // middleMark
            // 
            this.middleMark.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.middleMark.Location = new System.Drawing.Point(521, 262);
            this.middleMark.Name = "middleMark";
            this.middleMark.Size = new System.Drawing.Size(240, 34);
            this.middleMark.TabIndex = 10;
            this.middleMark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currentMark_KeyPress);
            // 
            // finalMark
            // 
            this.finalMark.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finalMark.Location = new System.Drawing.Point(521, 348);
            this.finalMark.Name = "finalMark";
            this.finalMark.Size = new System.Drawing.Size(240, 34);
            this.finalMark.TabIndex = 12;
            this.finalMark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currentMark_KeyPress);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(343, 465);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 30);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Orqaga";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(521, 465);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 30);
            this.save.TabIndex = 14;
            this.save.Text = "Saqlash";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(203, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Talaba ismi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(203, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Talaba familiyasi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(203, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Talaba guruh raqami";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(521, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Joriy nazorat bahosi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(521, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Oraliq nazorat bahosi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(521, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Yakuniy nazorat bahosi";
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.errorMsg.ForeColor = System.Drawing.Color.Red;
            this.errorMsg.Location = new System.Drawing.Point(318, 98);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(0, 27);
            this.errorMsg.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.finalMark);
            this.Controls.Add(this.middleMark);
            this.Controls.Add(this.currentMark);
            this.Controls.Add(this.groupNumber);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yangi student qo\'shish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title;
        private TextBox fName;
        private TextBox lName;
        private TextBox groupNumber;
        private TextBox currentMark;
        private TextBox middleMark;
        private TextBox finalMark;
        private Button cancel;
        private Button save;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label errorMsg;
    }
}