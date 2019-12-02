using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TransformApplications
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
            }
            openFileDialog1.Dispose();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtFileName.Text = string.Empty;
        }

        private DataSet GetDataSet(string fileName)
        {
            DataSet ds = new DataSet();

            List<string> columnsList = new List<string>();

            System.Data.DataTable dtResult = null;
            int totalSheet = 0; //No of sheets on excel file  
            using (OleDbConnection objConn =
                new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';"))
            {
                objConn.Open();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter oleda = new OleDbDataAdapter();

                System.Data.DataTable dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string sheetName = string.Empty;
                if (dt != null)
                {
                    var tempDataTable = (from dataRow in dt.AsEnumerable()
                                         where !dataRow["TABLE_NAME"].ToString().Contains("FilterDatabase")
                                         select dataRow).CopyToDataTable();
                    dt = tempDataTable;
                    totalSheet = dt.Rows.Count;
                    sheetName = dt.Rows[0]["TABLE_NAME"].ToString();
                }
                cmd.Connection = objConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                oleda = new OleDbDataAdapter(cmd);
                oleda.Fill(ds, "RawDataReport");

                //dtResult = ds.Tables["RawDataReport"];
                objConn.Close();
                //return dtResult; //Returning Dattable  

                //DataColumnCollection dataColumnCollection = ds.Tables[0].Columns;

                //columnsList = ds.Tables[0].Columns.Cast<DataColumn>()
                //                 .Select(x => x.ColumnName).ToList();

                //dataColumnCollection.GetEnumerator();

            }

            return ds;
        }

        private static string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            lblDisplay.Visible = true;

            DataSet ds = GetDataSet(@"Mappers\SayanMappersList.xlsx");

            string[] olddefects = ds.Tables[0].Rows.Cast<DataRow>().Select(x => x.Field<string>("Old Defects")).Where(c=>c!=null).ToArray();

            string[] newDefects = ds.Tables[0].Rows.Cast<DataRow>().Select(x => x.Field<string>("New Defects")).Where(c => c != null).ToArray();

            lblDisplay.Text = "Reading mappers";

            string[] moreDefects = ds.Tables[0].Rows.Cast<DataRow>().Select(x => x.Field<string>("Newly Added")).Where(c => c != null).ToArray();

            string[] removeDefects = ds.Tables[0].Rows.Cast<DataRow>().Select(x => x.Field<string>("Need to remove")).Where(c => c != null).ToArray();

           
            //List<string> exceptElements = olddefects.Except(newDefects).ToList();

            if (!string.IsNullOrEmpty(txtFileName.Text))
            {

                Microsoft.Office.Interop.Excel.Application xlsApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlsApp == null)
                {
                    MessageBox.Show("EXCEL could not be started. Check that your office installation and project references are correct.");
                }

                Excel.Workbook wb = xlsApp.Workbooks.Open(txtFileName.Text,
                    0, false, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);
                //Excel.Workbook xlWorkbook 
                Excel.Sheets sheets = wb.Worksheets;
                Excel.Worksheet ws = (Excel.Worksheet)sheets[1];

                try
                {

                    //ws.Cells[1, 1] = "Test name";

                    int usedRange = ws.UsedRange.Columns.Count;

                    Dictionary<string, string> standardFileColumns = new Dictionary<string, string>();

                    for (int i = 0; i < usedRange; i++)
                    {
                        standardFileColumns.Add(string.Format("{0},{1}", 1, i + 1), ws.Cells[1, i + 1].Value.ToString());
                    }

                    try
                    {

                        for (int indx = 0; indx < olddefects.Length; indx++)
                        {
                            string myKey = standardFileColumns.FirstOrDefault(x => x.Value == olddefects[indx]).Key;

                            if (!string.IsNullOrEmpty(myKey))
                            {

                                int i = Convert.ToInt16(myKey.Split(',')[0]);
                                int j = Convert.ToInt16(myKey.Split(',')[1]);

                                ws.Cells[i, j] = newDefects[indx];

                                lblDisplay.Text = "Modifying Defect Name From " + olddefects[indx] + " To " + newDefects[indx];
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }

                    for (int jndex = 0; jndex < moreDefects.Length; jndex++)
                    {

                        string myKey = standardFileColumns.FirstOrDefault(x => x.Value == moreDefects[jndex]).Key;

                        if (string.IsNullOrEmpty(myKey))
                        {

                            // object rangeNumber = GetExcelColumnName(Convert.ToInt16(myKey.Split(',')[1])) + "1";

                            //int js = usedRange + jndex;

                            //object rangeNumber = GetExcelColumnName(js) + "1";

                            ws.Cells[1, (usedRange + jndex) + 1] = moreDefects[jndex];

                            lblDisplay.Text = "Adding New Defects " + moreDefects[jndex];
                        }
                    }
 
                    for (int arr = 0; arr < removeDefects.Length; arr++)
                    {

                        usedRange = ws.UsedRange.Columns.Count;

                        Dictionary<string, string> deletedFileColumns = new Dictionary<string, string>();

                        for (int i = 0; i < usedRange; i++)
                        {
                            deletedFileColumns.Add(string.Format("{0},{1}", 1, i + 1), ws.Cells[1, i + 1].Value.ToString());
                        }

                        string myKey = deletedFileColumns.FirstOrDefault(x => x.Value == removeDefects[arr]).Key;

                        if (!string.IsNullOrEmpty(myKey))
                        {

                            object rangeNumber = GetExcelColumnName(Convert.ToInt16(myKey.Split(',')[1])) + "1";

                            Excel.Range range = (Excel.Range)ws.get_Range(rangeNumber, Missing.Value);
                            range.EntireColumn.Delete(Missing.Value);
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(range);

                            lblDisplay.Text = "Removing UnWanted Defects " + removeDefects[arr];
                        }
                    }

                    wb.Save();

                    wb.SaveCopyAs("DUP_BYS-SG-CADEMS-BE-20190926_CUSLT Ambient 14-Oct to 4-Nov2.xlsx");

                    wb.Close();
                }
                catch (Exception ex)
                {

                    Marshal.ReleaseComObject(wb);
                    Marshal.ReleaseComObject(xlsApp);
                }

                Marshal.ReleaseComObject(wb);
                Marshal.ReleaseComObject(xlsApp);

            }

            MessageBox.Show(ds.GetXml().ToString());

            lblDisplay.Text = "Excel File Was Ready For Use at DUP_BYS-SG-CADEMS-BE-20190926_CUSLT Ambient 14-Oct to 4-Nov2.xlsx";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblDisplay.Visible = false;
            lnkMergeFile.Visible = false;
        }

        private void btnMergeClear_Click(object sender, EventArgs e)
        {
            txtF1.Text = "";
            txtF2.Text = "";
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtF1.Text) || !string.IsNullOrEmpty(txtF2.Text))
            {
                string folderName = @"D:\RawData Reports";

                if (!System.IO.Directory.Exists(folderName))
                {
                    System.IO.Directory.CreateDirectory(folderName);
                }

                string destinationPath = @"D:\RawData Reports\BYS-SG-CADEMS-BE-20190926_CUSLT Ambient" + DateTime.Now.ToString("_MMMdd_yyyy_HHmmss") + ".xlsx";

                lnkMergeFile.Visible = true;

                Workbook workbook = new Workbook();
                workbook.LoadFromFile(txtF1.Text);

                lnkMergeFile.Text = "Reading your F1 File";

                Workbook workbook2 = new Workbook();
                workbook2.LoadFromFile(txtF2.Text);

                lnkMergeFile.Text = "Reading your F2 File";

                Worksheet sheet2 = workbook2.Worksheets[0];
                DataTable dataTable = sheet2.ExportDataTable();
                Worksheet sheet1 = workbook.Worksheets[0];


                int colCount = dataTable.Columns.Count;

                sheet1.InsertDataTable(dataTable, false, sheet1.LastRow + 1, 1);

                lnkMergeFile.Text = "Merging your F1 & F2 Files";

                workbook.SaveToFile(destinationPath);

                lnkMergeFile.Text = "Merging was done";

                Microsoft.Office.Interop.Excel.Application xlsApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlsApp == null)
                {
                    MessageBox.Show("EXCEL could not be started. Check that your office installation and project references are correct.");
                }
                Excel.Workbook wb = xlsApp.Workbooks.Open(destinationPath,
                        0, false, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);
                //Excel.Workbook xlWorkbook 
                Excel.Sheets sheets = wb.Worksheets;
                Excel.Worksheet ws = (Excel.Worksheet)sheets[2];

                xlsApp.DisplayAlerts = false;
                ws.Delete();

                wb.Save();

                wb.Close();

                Marshal.ReleaseComObject(wb);
                Marshal.ReleaseComObject(xlsApp);

                lnkMergeFile.Text = destinationPath;
            }
            else
            {
                MessageBox.Show("No files were selected for progressing");
            }
        }

        private void btnBrowseF1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtF1.Text = openFileDialog1.FileName;
            }
            openFileDialog1.Dispose();
        }

        private void btnBrowseF2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtF2.Text = openFileDialog1.FileName;
            }
            openFileDialog1.Dispose();
        }

        private void lnkMergeFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lnkMergeFile.Text);
        }

        private void btnSkuClear_Click(object sender, EventArgs e)
        {
            txtSkuFile.Text = "";
        }

        private void btnSkuStart_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtSkuFile.Text))
            {
                var connectionStringBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder();
                connectionStringBuilder.DataSource = txtSkuFile.Text;
                connectionStringBuilder.Provider = "Microsoft.ACE.OLEDB.12.0";
                connectionStringBuilder.Add("Extended Properties", "Excel 12.0;");
                string[] requiredSKU = new string[] { "Sayan Premium Plus", "Sayan WL", "Sayan Lite" };

                for (int i = 1; i <= 3; i++)
                {
                    using (var connection = new System.Data.OleDb.OleDbConnection(connectionStringBuilder.ToString()))
                    {
                        connection.Open();
                        var updateCommand = connection.CreateCommand();
                        updateCommand.CommandText = "update [RawDataReport$] R set R.[Program & SKU] = '" + requiredSKU[i - 1] + "' where LEFT(R.Address, 1)  = " + i + " AND R.Address is NOT NULL";
                        updateCommand.ExecuteNonQuery();

                    }
                }

                txtSkuFile.Text = "";
                MessageBox.Show("Completed");
            }  
        }

        private void btnSkuFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSkuFile.Text = openFileDialog1.FileName;
            }
            openFileDialog1.Dispose();
        }
    }
}
