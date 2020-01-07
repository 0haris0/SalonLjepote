using eHairdresserSalon_API.Models;
using eHairdresserSalon_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHairdresserSalon_UI.Appointments
{
    public partial class AktivniTermini : Form
    {
        private WebAPIHelper terminiService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Termini");
        public List<Termini_Result> result { get; set; }


        public AktivniTermini()
        {
            InitializeComponent();
        }

        void BindForm()
        {

            HttpResponseMessage response = terminiService.GetActionResponse("SearchByAktivniTermini");

            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsAsync<List<Termini_Result>>().Result;
                TerminiGridView.DataSource = result;
                TerminiGridView.ClearSelection();
            }
        }

        private void ProcesirajBtn_Click(object sender, EventArgs e)
        {
            Reports.ReportViewForm frm = new Reports.ReportViewForm();
            frm.termini = result;
            frm.ShowDialog();
        }

        private void AktivniTermini_Load(object sender, EventArgs e)
        {
            BindForm();
        }
    }
}
