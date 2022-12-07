using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AlgimedTask
{
    //написать комменты, удалить лишние юзинги
    public partial class mainForm : Form
    {
        public static string filePath = $@"{AppDomain.CurrentDomain.BaseDirectory}..\..\..\Data\Input Data_ПО.csv";
        private List<string> headCells = new List<string> { "C01", "D01", "F01" };
        private List<string> sideCells = new List<string> { "E01", "G01", "H01", };
        private Result[] results;
        private double[] headCellsNum;
        private double[] sideCellsNum;
        private double[,] resultMatrix;
        Excel.Application excel;
        Workbook wb;
        Worksheet ws;


        public mainForm()
        {
            InitializeComponent();
            fileTextBox.Text = Path.GetFileName(filePath);
            upper1.Text = headCells[0];
            upper2.Text = headCells[1];
            upper3.Text = headCells[2];
            side1.Text = sideCells[0];
            side2.Text = sideCells[1];
            side3.Text = sideCells[2];
            CreateResultMatrix();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            DbOutputForm form = new DbOutputForm(results);
            form.ShowDialog();
        }

        private void CreateResultMatrix() //culate our matrix of results always when we change file, values in this file or when we chande needed cells
        {
            results = new Result[sideCells.Count * headCells.Count];
            ReadExcel();
            listView.Items.Clear();
            resultMatrix = new double[sideCells.Count, headCells.Count];
            int counter = 0;
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = Math.Round(Math.Pow(headCellsNum[j] - sideCellsNum[i], 2), 2);
                    listView.Items.Add($"{resultMatrix[i, j]}");
                    results[counter] = new Result();
                    results[counter].Cell = $"{headCells[i]}_{sideCells[j]}";
                    results[counter].Value = resultMatrix[i, j];
                    counter++;
                }

            }
        }

        private void ReadExcel() //find our cells in the file and take needed values
        {

            headCellsNum = new double[headCells.Count];
            sideCellsNum = new double[sideCells.Count];

            excel = new Excel.Application();
            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Excel.Range cell = ws.UsedRange;
            int rowCount = cell.Rows.Count;

            Parallel.For(0, headCells.Count, i =>
            {
                for (int j = 1; j <= rowCount; j++)
                {
                    if (cell.Cells[j, 1].Value == headCells[i])
                        headCellsNum[i] = cell.Cells[j, 6].Value;
                    else if (cell.Cells[j, 1].Value == sideCells[i])
                        sideCellsNum[i] = cell.Cells[j, 6].Value;
                }
            });
            wb.Close(0);
            excel.Quit();
            KillExcelProc();
        }
        private void chooseExcelButton_Click(object sender, EventArgs e) //to choose a needed excel file
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (Path.GetExtension(openFileDialog.FileName) == ".csv" || Path.GetExtension(openFileDialog.FileName) == ".xlsx")
            {
                filePath = openFileDialog.FileName;
                fileTextBox.Text = Path.GetFileName(filePath);
            }
            else MessageBox.Show("Please select .xlsx or .csv file");
            CreateResultMatrix();
        }
        private void changeCellsButton_Click(object sender, EventArgs e) //open fields to change a needed cells
        {
            upper1.Enabled = true;
            upper2.Enabled = true;
            upper3.Enabled = true;

            side1.Enabled = true;
            side2.Enabled = true;
            side3.Enabled = true;

            saveCellsButton.Visible = true;
        }
        private void saveCellsButton_Click(object sender, EventArgs e) //save new cells and recalculate our matrix of results
        {
            headCells[0] = upper1.Text;
            headCells[1] = upper2.Text;
            headCells[2] = upper3.Text;

            sideCells[0] = side1.Text;
            sideCells[1] = side2.Text;
            sideCells[2] = side3.Text;

            CreateResultMatrix();

            upper1.Enabled = false;
            upper2.Enabled = false;
            upper3.Enabled = false;

            side1.Enabled = false;
            side2.Enabled = false;
            side3.Enabled = false;

            saveCellsButton.Visible = false;
        }

        private void openExcelButton_Click(object sender, EventArgs e) 
        {
            var proc = new Process();
            proc.StartInfo = new ProcessStartInfo(filePath)
            {
                UseShellExecute = true
            };
            proc.Start();
            proc.WaitForExit();     //if we changed something then we closed the file 
            CreateResultMatrix();   //=> recalculate our matrix of results
        }

        private void KillExcelProc() //from task manager
        {
            int ExcelHwnd = excel.Hwnd;
            Process[] localExcel = Process.GetProcessesByName("EXCEL");
            foreach (Process Pgm in localExcel)
            {
                excel.WindowState = XlWindowState.xlMinimized;
                excel.Visible = true;
                if ((Pgm.ProcessName == "EXCEL") && (ExcelHwnd == Pgm.MainWindowHandle.ToInt32()))
                {
                    Pgm.Kill();
                }
            }
        }
    }
}
