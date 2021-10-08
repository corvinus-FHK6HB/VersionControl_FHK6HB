using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ExcelExport
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities();
        List<Flat> Lakások;
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        string[] headers;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            CreateExcel();
        }
        private void LoadData()
        {
            Lakások = context.Flats.ToList();
        }
        private void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;
                CreateTable();
                FormatTable();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }

        }
        private void CreateTable()
        {
            headers = new string[]
            {
             "Kód",
             "Eladó",
             "Oldal",
             "Kerület",
             "Lift",
             "Szobák száma",
             "Alapterület (m2)",
             "Ár (mFt)",
             "Négyzetméter ár (Ft/m2)"
            };
            for (int i = 0; i < headers.Length; i++)
                xlSheet.Cells[1, 1 + i] = headers[i];

            object[,] values = new object[Lakások.Count, headers.Length];

            int counter = 0;
            foreach (var lakás in Lakások)
            {
                values[counter, 0] = lakás.Code;
                values[counter, 1] = lakás.Vendor;
                values[counter, 2] = lakás.Side;
                values[counter, 3] = lakás.District;
                values[counter, 4] = lakás.Elevator
                    ? "van"
                    : "Nincs";
                values[counter, 5] = lakás.NumberOfRooms;
                values[counter, 6] = lakás.FloorArea;
                values[counter, 7] = lakás.Price;
                values[counter, 8] = "";
                counter++;
            }

            var range = xlSheet.get_Range(
                GetCell(2, 1),
                GetCell(1 + values.GetLength(0), values.GetLength(1)));
            range.Value2 = values;
        }

        private void FormatTable()
        {
            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.LightBlue;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }


    }
}
