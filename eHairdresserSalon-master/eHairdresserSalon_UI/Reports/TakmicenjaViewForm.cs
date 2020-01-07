using eHairdresserSalon_API.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHairdresserSalon_UI.Reports
{
    public partial class TakmicenjaViewForm : Form
    {

        public List<Takmicenja_Report> takmicenja = new List<Takmicenja_Report>();

        public TakmicenjaViewForm()
        {
            InitializeComponent();
        }

        private void TakmicenjaViewForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("dsPrijavljeniKlijenti", takmicenja);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
