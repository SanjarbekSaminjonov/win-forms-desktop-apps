namespace Kurs_Ishi
{
    partial class AllTodos
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
            this.button1 = new System.Windows.Forms.Button();
            this.listTodos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Orqaga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listTodos
            // 
            this.listTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.listTodos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTodos.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listTodos.ForeColor = System.Drawing.Color.Yellow;
            this.listTodos.FormattingEnabled = true;
            this.listTodos.ItemHeight = 32;
            this.listTodos.Location = new System.Drawing.Point(28, 87);
            this.listTodos.Name = "listTodos";
            this.listTodos.Size = new System.Drawing.Size(368, 512);
            this.listTodos.TabIndex = 1;
            this.listTodos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listTodos_MouseClick);
            // 
            // AllTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(430, 650);
            this.Controls.Add(this.listTodos);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllTodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllTodos";
            this.Load += new System.EventHandler(this.AllTodos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private ListBox listTodos;
    }
}