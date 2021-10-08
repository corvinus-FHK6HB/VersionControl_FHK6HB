using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelExport
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities();
        List<Flat> Lakások; 
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            Lakások = context.Flats.ToList();
        }
    }
}
