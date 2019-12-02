using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Access.Dao;

namespace TransformApplications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    InitialDirectory = @"D:\",
                    Title = "Browse Access DB Files Only",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "Access DB Files",
                    Filter = "Access DB Files (*.accdb)|*.accdb",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textFileName.Text = openFileDialog1.FileName;
                }
                openFileDialog1.Dispose();

                #region OLEDB Section
                OleDbConnection odbcConnection =
                    new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textFileName.Text.ToString());
                odbcConnection.Open();
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from RawDataReport", odbcConnection);
                DataSet ds = new DataSet();
                oleDbDataAdapter.Fill(ds, "RawDataReport");
                odbcConnection.Close();
                odbcConnection.Dispose();
                #endregion

                #region ExcelFile Operations
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWorkBook = null;
                int fileNumber = new Random().GetHashCode();
                string fileName = "RawDataFile_AUG13" + fileNumber;
                var workbook = excelApp.Workbooks.Add();
                string DefaultFilePath = txtFileSave.Text;
                if (string.IsNullOrEmpty(DefaultFilePath))
                {
                    MessageBox.Show("You are not choosing any save location so, Default Path considered");
                    DefaultFilePath = @"D:\TransformFiles";
                }
                if (!System.IO.Directory.Exists(DefaultFilePath))
                {
                    DirectoryInfo directoryInfo = System.IO.Directory.CreateDirectory(DefaultFilePath);
                }
                string fileSavePath = DefaultFilePath + "\\" +fileName + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".xlsx";
                workbook.SaveAs(fileSavePath);
                excelWorkBook = excelApp.Workbooks.Open(fileSavePath);

                foreach (System.Data.DataTable table in ds.Tables)
                {
                    //Add a new worksheet to workbook with the Datatable name
                    Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
                    excelWorkSheet.Name = table.TableName;

                    for (int i = 1; i < table.Columns.Count + 1; i++)
                    {
                        excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                    }

                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        progressBar1.Value = j * progressBar1.Maximum / table.Rows.Count;
                        label1.Text = "Progressing " + (j + 1).ToString() + "of " + table.Rows.Count;
                        int percentage = ((j + 1) * 100) / table.Rows.Count;
                        lblpercentage.Text = percentage.ToString() + " %";
                        for (int k = 0; k < table.Columns.Count; k++)
                        {
                            excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                        }
                        System.Windows.Forms.Application.DoEvents();
                    }
                    lblpercentage.Text = "Done! Data Transformed for Reports";
                }
                excelWorkBook.Save();
                excelWorkBook.Close();
                excelApp.Quit();
                #endregion

                linkLabel2.Text = fileSavePath;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }
        }

        
        private void btnSaveLoc_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileSave.Text = openFileDialog1.FileName;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel2.Text);
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                txtStandardFile.Text = openFileDialog2.FileName;
            }
            openFileDialog2.Dispose();
        }

        private void btnNonStandard_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                txtNonStandardFile.Text = openFileDialog2.FileName;
            }
            openFileDialog2.Dispose();
        }

        private void btnStdClear_Click(object sender, EventArgs e)
        {
            txtStandardFile.Text = "";
            txtNonStandardFile.Text = "";
        }

        private void btnStandardizationSubmit_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlsApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlsApp == null)
            {
                MessageBox.Show("EXCEL could not be started. Check that your office installation and project references are correct.");
            }

            Excel.Workbook wb = xlsApp.Workbooks.Open(txtStandardFile.Text,
                0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);
            //Excel.Workbook xlWorkbook 
            Excel.Sheets sheets = wb.Worksheets;
            Excel.Worksheet ws = (Excel.Worksheet)sheets[1];

            //ws.Cells[1, 1] = "Test name";

            int usedRange = ws.UsedRange.Columns.Count;

            Dictionary<string, string> standardFileColumns = new Dictionary<string, string>();

            for (int i = 0; i < usedRange; i++)
            {
                standardFileColumns.Add(string.Format("{0}:{1}", 1, i + 1), ws.Cells[1, i + 1].Value.ToString());
            }

            //Dictionary<string, string> excelInfo = excelColumns;

            //string myKey = excelColumns.FirstOrDefault(x => x.Value == "one").Key;

            Excel.Workbook wb2 = xlsApp.Workbooks.Open(txtNonStandardFile.Text,
                0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);
            //Excel.Workbook xlWorkbook 
            Excel.Sheets sheets2 = wb2.Worksheets;
            Excel.Worksheet ws2 = (Excel.Worksheet)sheets2[1];

            //ws.Cells[1, 1] = "Test name";

            int usedRange2 = ws2.UsedRange.Columns.Count;

            Dictionary<string, string> nonStandardFileColumns = new Dictionary<string, string>();

            for (int i = 0; i < usedRange2; i++)
            {
                nonStandardFileColumns.Add(string.Format("{0}:{1}", 1, i + 1), ws2.Cells[1, i + 1].Value.ToString());
            }

            List<string> lstStandardFileColumns = standardFileColumns.Values.ToList();
            List<string> lstNonStandardFileColumns = nonStandardFileColumns.Values.ToList();

            var differences =  lstStandardFileColumns.Except(lstNonStandardFileColumns);

            string differencelement = string.Empty;
            differencelement = string.Join(",", differences);
            MessageBox.Show("Missing Elements are " + differencelement);

            

            for (int i = 0; i < usedRange2; i++)
            {
                if(ws2.Cells[1, i + 1].Value.ToString().Contains("Motting S1"))
                {
                    ws2.Cells[1, i + 1] = "Mottling _S1";
                }
                else if (ws2.Cells[1, i + 1].Value.ToString().Contains("Motting S2"))
                {
                    ws2.Cells[1, i + 1] = "Mottling _S2";
                }
                else if (ws2.Cells[1, i + 1].Value.ToString().Contains("Pen Alignment S1"))
                {
                    ws2.Cells[1, i + 1] = "Pen Alignment_S1";
                }
                else if (ws2.Cells[1, i + 1].Value.ToString().Contains("Pen Alignment S2"))
                {
                    ws2.Cells[1, i + 1] = "Pen Alignment_S2";
                }
                else if (ws2.Cells[1, i + 1].Value.ToString().Contains("Incomplete Printing"))
                {
                    ws2.Cells[1, i + 1] = "Incomplete Printing _S1";
                }
            }

            nonStandardFileColumns.Clear();

            for (int i = 0; i < usedRange2; i++)
            {
                nonStandardFileColumns.Add(string.Format("{0}:{1}", 1, i + 1), ws2.Cells[1, i + 1].Value.ToString());
            }

            lstNonStandardFileColumns.Clear();
            lstNonStandardFileColumns = nonStandardFileColumns.Values.ToList();


            List<string> requiredElements = new List<string>();
            requiredElements.Add("Pen Alignment_S2");
            requiredElements.Add("Image Shift_S1");
            requiredElements.Add("Image Shift_S2");
            requiredElements.Add("Incomplete Printing _S2");
            requiredElements.Add("Vertical K bar_S1");
            requiredElements.Add("Vertical K bar_S2");

            for (int i = 0; i < requiredElements.Count; i++)
            {
                if (lstNonStandardFileColumns.Contains(requiredElements[i]))
                {

                }
                else
                {
                    ws2.Cells[1, ws2.UsedRange.Columns.Count + 1] = requiredElements[i];
                }
            }


            //wb.Save();
            //wb.Close();
            wb2.SaveCopyAs(txtNonStandardFile.Text);

            Marshal.ReleaseComObject(wb2);
            Marshal.ReleaseComObject(xlsApp);

            //wb2.Close();
            //xlsApp.Quit();

            

            MessageBox.Show("Completed");

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                DBEngine dBEngine = new DBEngine();
                var openDb = dBEngine.OpenDatabase(txtStandardFile.Text.ToString());
                openDb.CreateQueryDef("RawDataReports", "Select * from DataEntryDefect");
                openDb.Close();

                





            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
