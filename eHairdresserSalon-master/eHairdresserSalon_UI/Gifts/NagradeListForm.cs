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

namespace eHairdresserSalon_UI.Gifts
{
    public partial class NagradeListForm : Form
    {
        private WebAPIHelper nagradeService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Nagrade");

        public NagradeListForm()
        {
            InitializeComponent();
            BindForm();
        }

        void BindForm()
        {
            HttpResponseMessage response = nagradeService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Nagrade_Result> nagrade = response.Content.ReadAsAsync<List<Nagrade_Result>>().Result;
                NagradeDataGridView.DataSource = nagrade;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }


        private void DodajNagraduBtn_Click(object sender, EventArgs e)
        {
            DodajNagradu frm = new DodajNagradu();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }

        private void IzmijeniNagraduBtn_Click(object sender, EventArgs e)
        {
            if (NagradeDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite nagradu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                IzmijeniNagradu frm = new IzmijeniNagradu(Convert.ToInt32(NagradeDataGridView.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
                BindForm();
            }
        }

        private void TraziButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = nagradeService.GetActionResponse("SearchByName", NazivNagradeInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<Nagrade_Result> nagrade = response.Content.ReadAsAsync<List<Nagrade_Result>>().Result;
                NagradeDataGridView.DataSource = nagrade;
                NagradeDataGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
    }
}
