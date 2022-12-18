using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using ExcelDataReader;

namespace MSEXCEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        DataTableCollection dataTableCollection;

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog() 
                { 
                    Filter="Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" 
                })
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    fileNameText.Text = open.FileName;
                    using (var streem = File.Open(open.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(streem))
                        {
                            var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true },
                            });
                            dataTableCollection = result.Tables;
                            selectSheet.Items.Clear();
                            foreach (DataTable table in dataTableCollection)
                            {
                                selectSheet.Items.Add(table.TableName);
                            }
                            selectSheet.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void selectSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = dataTableCollection[selectSheet.SelectedItem.ToString()];
            dataGridView.DataSource = dt;
        }
    }
}
