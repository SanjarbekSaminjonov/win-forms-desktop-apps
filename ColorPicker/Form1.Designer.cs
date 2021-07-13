
namespace ColorPicker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xuiColorPicker1 = new XanderUI.XUIColorPicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiColorPicker1
            // 
            this.xuiColorPicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xuiColorPicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiColorPicker1.Location = new System.Drawing.Point(247, 136);
            this.xuiColorPicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xuiColorPicker1.Name = "xuiColorPicker1";
            this.xuiColorPicker1.PickerImage = ((System.Drawing.Image)(resources.GetObject("xuiColorPicker1.PickerImage")));
            this.xuiColorPicker1.SelectedColor = System.Drawing.Color.Empty;
            this.xuiColorPicker1.ShowColorPreview = true;
            this.xuiColorPicker1.Size = new System.Drawing.Size(233, 233);
            this.xuiColorPicker1.TabIndex = 0;
            this.xuiColorPicker1.Text = "Color Picker";
            this.xuiColorPicker1.SelectedColorChanged += new System.EventHandler(this.xuiColorPicker1_SelectedColorChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.xuiColorPicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 530);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 503);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(695, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Select color";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 530);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIColorPicker xuiColorPicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

