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
    public partial class AppointmentsListForm : Form
    {
        private WebAPIHelper terminiService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Termini");

        public AppointmentsListForm()
        {
            InitializeComponent();
        }

        void BindForm()
        {
            HttpResponseMessage response = terminiService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Termini_Result> termini = response.Content.ReadAsAsync<List<Termini_Result>>().Result;
                TerminiGridView.DataSource = termini;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void AppointmentsListForm_Load(object sender, EventArgs e)
        {
            BindForm();
        }

        private void DodajNoviTerminBtn_Click(object sender, EventArgs e)
        {
            DodajTermin frm = new DodajTermin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }

        private void traziTerminBtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = terminiService.GetActionResponse("SearchByDate", datumTerminaDateTimePicker.Value.ToUniversalTime().ToString("dd-MM-yyyy"));

            if (response.IsSuccessStatusCode)
            {
                List<Termini_Result> termini = response.Content.ReadAsAsync<List<Termini_Result>>().Result;
                TerminiGridView.DataSource = termini;
                TerminiGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void IzmijeniTerminBtn_Click(object sender, EventArgs e)
        {
            if (TerminiGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite termin!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                IzmijeniTermin it = new IzmijeniTermin(Convert.ToInt32(TerminiGridView.SelectedRows[0].Cells[0].Value));
                it.ShowDialog();
                BindForm();
            }
        }

        private void PrintajAktivneTermineBtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage responseTermini = terminiService.GetActionResponse("SearchByAktivniTermini");
            if (responseTermini.IsSuccessStatusCode)
            {
                List<Termini_Result> t = responseTermini.Content.ReadAsAsync<List<Termini_Result>>().Result;
                Reports.ReportViewForm frm = new Reports.ReportViewForm();
                frm.termini = t;
                frm.Show();
            }
        }
    }
}
