namespace TraficRules
{
    partial class RuleItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgAlt = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAlt
            // 
            this.imgAlt.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imgAlt.Location = new System.Drawing.Point(278, 104);
            this.imgAlt.Name = "imgAlt";
            this.imgAlt.Size = new System.Drawing.Size(649, 90);
            this.imgAlt.TabIndex = 1;
            this.imgAlt.Text = "6t8u7yiuyiuy";
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.White;
            this.image.Location = new System.Drawing.Point(10, 10);
            this.image.Margin = new System.Windows.Forms.Padding(10);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(255, 237);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // RuleItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.image);
            this.Controls.Add(this.imgAlt);
            this.Name = "RuleItem";
            this.Size = new System.Drawing.Size(953, 257);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label imgAlt;
        private PictureBox image;
    }
}
