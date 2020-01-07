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

namespace eHairdresserSalon_UI.AdditionalTreatments
{
    public partial class DodatniTretmaniListForm : Form
    {
        private WebAPIHelper dodatniTretmaniService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/DodatniTretmani");
        private WebAPIHelper vrsteUslugaService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/VrsteUsluga");

        public DodatniTretmaniListForm()
        {
            InitializeComponent();
            dodatniTretmaniGridView.AutoGenerateColumns = true;
        }

        private void BindVrsteUsluga()
        {
            HttpResponseMessage response = vrsteUslugaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<VrsteUsluga_Result> lst = response.Content.ReadAsAsync<List<VrsteUsluga_Result>>().Result;
                lst.Insert(0, new VrsteUsluga_Result() { Naziv = "Odaberite: " });
                vrstaUslugeComboBox.DataSource = lst;
                vrstaUslugeComboBox.DisplayMember = "Naziv";
                vrstaUslugeComboBox.ValueMember = "VrstaUslugeID";
            }
        }

        void BindForm()
        {
            HttpResponseMessage response = dodatniTretmaniService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<DodatniTretmani_Result> additionalTreatments = response.Content.ReadAsAsync<List<DodatniTretmani_Result>>().Result;
                dodatniTretmaniGridView.DataSource = additionalTreatments;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void DodatniTretmaniListForm_Load(object sender, EventArgs e)
        {
            BindVrsteUsluga();
            BindForm();
        }

        private void DodajDodatniTretmanBtn_Click(object sender, EventArgs e)
        {
            DodajDodatniTretman frm = new DodajDodatniTretman();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }

        private void TraziBtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = dodatniTretmaniService.GetActionResponse("SearchByName", NazivTretmanaInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<DodatniTretmani_Result> dodatniTretmani = response.Content.ReadAsAsync<List<DodatniTretmani_Result>>().Result;
                dodatniTretmaniGridView.DataSource = dodatniTretmani;
                dodatniTretmaniGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void IzmijeniBtn_Click(object sender, EventArgs e)
        {
            if (dodatniTretmaniGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite tretman!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                IzmijeniDodatniTretman idt = new IzmijeniDodatniTretman(Convert.ToInt32(dodatniTretmaniGridView.SelectedRows[0].Cells[0].Value));
                idt.ShowDialog();
                BindForm();
            }
        }
    }
}
