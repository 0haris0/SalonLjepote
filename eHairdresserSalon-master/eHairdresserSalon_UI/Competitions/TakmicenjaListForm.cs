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

namespace eHairdresserSalon_UI.Competitions
{
    public partial class TakmicenjaListForm : Form
    {
        private WebAPIHelper takmicenjaService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Takmicenja");

        public TakmicenjaListForm()
        {
            InitializeComponent();
        }

        void BindForm()
        {
            HttpResponseMessage response = takmicenjaService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Takmicenja_Result> competitions = response.Content.ReadAsAsync<List<Takmicenja_Result>>().Result;
                TakmicenjaGridView.DataSource = competitions;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void DodajTakmicenjeBtn_Click(object sender, EventArgs e)
        {
            DodajTakmicenje frm = new DodajTakmicenje();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }

        private void TraziButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = takmicenjaService.GetActionResponse("SearchByPlace", MjestoInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<Takmicenja_Result> takmicenja = response.Content.ReadAsAsync<List<Takmicenja_Result>>().Result;
                TakmicenjaGridView.DataSource = takmicenja;
                TakmicenjaGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void TakmicenjaListForm_Load(object sender, EventArgs e)
        {
            BindForm();
        }

        private void IzmijeniTakmicenjeBtn_Click(object sender, EventArgs e)
        {
            if (TakmicenjaGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite takmičenje!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                IzmijeniTakmicenje frm = new IzmijeniTakmicenje(Convert.ToInt32(TakmicenjaGridView.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
                BindForm();
            }
        }

        private void printajBtn_Click(object sender, EventArgs e)
        {
            if (TakmicenjaGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite termin!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int takmicenjeID = Convert.ToInt32(TakmicenjaGridView.SelectedRows[0].Cells[0].Value);

                HttpResponseMessage responseTakmicenje = takmicenjaService.GetActionResponse("GetKlijentiByTakmicenje", takmicenjeID.ToString());
                if(responseTakmicenje.IsSuccessStatusCode)
                {
                    List<Takmicenja_Report> t = responseTakmicenje.Content.ReadAsAsync<List<Takmicenja_Report>>().Result;
                    Reports.TakmicenjaViewForm frm = new Reports.TakmicenjaViewForm();
                    frm.takmicenja = t;
                    frm.Show();
                }

            }
        }
    }
}
