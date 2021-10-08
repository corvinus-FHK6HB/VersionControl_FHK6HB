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
                //createtable
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
            string[] headers = new string[]
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
                values[counter, 4] = lakás.Elevator;
                values[counter, 5] = lakás.NumberOfRooms;
                values[counter, 6] = lakás.FloorArea;
                values[counter, 7] = lakás.Price;
                values[counter, 8] = "";
                counter++;
            }
        }
    }
}
