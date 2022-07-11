namespace TraficRules
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
            this.backButton = new System.Windows.Forms.PictureBox();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ruleItem1 = new TraficRules.RuleItem();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.panelScroll.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Image = global::TraficRules.Properties.Resources.back;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 80);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 4;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panelScroll
            // 
            this.panelScroll.Controls.Add(this.flowLayoutPanel1);
            this.panelScroll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelScroll.Location = new System.Drawing.Point(0, 83);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(1100, 717);
            this.panelScroll.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.ruleItem1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(63, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1005, 688);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ruleItem1
            // 
            this.ruleItem1.BackColor = System.Drawing.Color.White;
            this.ruleItem1.Image = global::TraficRules.Properties.Resources.img1_1;
            this.ruleItem1.ImgAlt = "fhgthjjjjjjjjjj";
            this.ruleItem1.Location = new System.Drawing.Point(3, 3);
            this.ruleItem1.Name = "ruleItem1";
            this.ruleItem1.Size = new System.Drawing.Size(987, 232);
            this.ruleItem1.TabIndex = 0;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(108, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(906, 39);
            this.title.TabIndex = 6;
            this.title.Text = "label1";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panelScroll);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.panelScroll.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox backButton;
        private Panel panelScroll;
        private FlowLayoutPanel flowLayoutPanel1;
        private RuleItem ruleItem1;
        private Label title;
    }
}