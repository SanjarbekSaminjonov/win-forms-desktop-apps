using System;
using System.Windows.Forms;
using Xceed.Words.NET;
using System.Diagnostics;


namespace MSWORD
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        string gpath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        private void create_Click(object sender, EventArgs e)
        {
            string textMessage = textBox.Text.Trim();
            string fileName = fileNameInp.Text.Trim().Replace(' ', '-');

            if (textMessage == string.Empty)
            {
                MessageBox.Show("Matn kiritish maydoni bo'sh,\nIltimos matn kiriting!", "Empty");
            }
            else if (fileName == string.Empty)
            {
                MessageBox.Show("Fayl nomi kiritilmadi!", "Empty");
            }
            else
            {
                gpath += $@"/{fileName}.docx";
                DocX obj = DocX.Create(gpath);
                obj.InsertParagraph(textMessage);
                obj.Save();

                Process.Start("winword.exe", gpath);
                MessageBox.Show("Fayl muvaffaqqiyatli saqlandi!", "Finished");
                Application.Exit();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
            fileNameInp.Text = string.Empty;
        }
    }
}
