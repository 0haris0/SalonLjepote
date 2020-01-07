using eHairdresserSalon_API.Models;
using eHairdresserSalon_UI.Util;
using Newtonsoft.Json;
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

namespace eHairdresserSalon_UI.Services
{
    public partial class UslugeListForm : Form
    {
        private WebAPIHelper uslugeService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Usluge");
        private WebAPIHelper vrsteUslugaService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/VrsteUsluga");

        public UslugeListForm()
        {
            InitializeComponent();
            //BindVrsteUsluga();
            uslugeGridView.AutoGenerateColumns = true;
        }
        void BindForm()
        {
            HttpResponseMessage response = uslugeService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Usluge_Result> services = response.Content.ReadAsAsync<List<Usluge_Result>>().Result;
                uslugeGridView.DataSource = services;
            }

            //HttpResponseMessage response = uslugeService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeComboBox.SelectedValue.ToString());

            //if (response.IsSuccessStatusCode)
            //{
            //    //List<Usluge_Result> services = response.Content.ReadAsAsync<List<Usluge_Result>>().Result;
            //    uslugeGridView.DataSource = response.Content.ReadAsAsync<List<Usluge_Result>>().Result;
            //}
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
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

        private void UslugeListForm_Load(object sender, EventArgs e)
        {
            BindVrsteUsluga();
            BindForm();
        }

        private void TraziBtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = uslugeService.GetActionResponse("SearchByName", NazivUslugeInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<Usluge_Result> services = response.Content.ReadAsAsync<List<Usluge_Result>>().Result;
                uslugeGridView.DataSource = services;
                uslugeGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void DodajUsluguBtn_Click(object sender, EventArgs e)
        {
            DodajUslugu frm = new DodajUslugu();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }

        private void IzmijeniUsluguBtn_Click(object sender, EventArgs e)
        {
            if (uslugeGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite uslugu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                IzmijeniUslugu frm = new IzmijeniUslugu(Convert.ToInt32(uslugeGridView.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
                BindForm();
            }
        }

        private void vrstaUslugeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HttpResponseMessage response = uslugeService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeComboBox.SelectedValue.ToString());

            //if (response.IsSuccessStatusCode)
            //{
            //    //List<Usluge_Result> services = response.Content.ReadAsAsync<List<Usluge_Result>>().Result;
            //    uslugeGridView.DataSource = response.Content.ReadAsAsync<List<Usluge_Result>>().Result;
            //}
            //else
            //{
            //    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            //}

            if (vrstaUslugeComboBox.SelectedItem != null)
            {
                int vrstaUslugeID = (vrstaUslugeComboBox.SelectedItem as VrsteUsluga_Result).VrstaUslugeID;
                HttpResponseMessage response = uslugeService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeID.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jsonObject = response.Content.ReadAsStringAsync();
                    List<Usluge_Result> termini = JsonConvert.DeserializeObject<List<Usluge_Result>>(jsonObject.Result);
                    uslugeGridView.DataSource = termini;
                }
            }
        }
    }
}
