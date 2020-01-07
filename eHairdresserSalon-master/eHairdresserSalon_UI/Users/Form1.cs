using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using eHairdresserSalon_API.Models;
using eHairdresserSalon_UI.Util;
using eHairdresserSalon_UI.Users;
using System.Configuration;

namespace eHairdresserSalon_UI
{
    public partial class IndexForm : Form
    {
        private WebAPIHelper klijentiService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Klijenti");

        public IndexForm()
        {
            InitializeComponent();
        }

        void BindForm()
        {
            HttpResponseMessage response = klijentiService.GetResponse();

            if(response.IsSuccessStatusCode)
            {
                List<Klijenti_Result> users = response.Content.ReadAsAsync<List<Klijenti_Result>>().Result;
                KlijentiGridView.DataSource = users;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindForm();
        }


        private void dodajKlijentaButton_Click(object sender, EventArgs e)
        {
            DodajKlijenta frm = new DodajKlijenta();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                BindForm();
            }
        }

        private void traziButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = klijentiService.GetActionResponse("SearchByName", imePrezimeInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<Klijenti_Result> klijenti = response.Content.ReadAsAsync<List<Klijenti_Result>>().Result;
                KlijentiGridView.DataSource = klijenti;
                KlijentiGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void izmijeniKlijentaButton_Click(object sender, EventArgs e)
        {
            if (KlijentiGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite klijenta!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EditForm frm = new EditForm(Convert.ToInt32(KlijentiGridView.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
                BindForm();
            }
        }

        private void rodjendaniBtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = klijentiService.GetActionResponse("SearchByBirthDate");

            if (response.IsSuccessStatusCode)
            {
                List<Klijenti_Result> klijenti = response.Content.ReadAsAsync<List<Klijenti_Result>>().Result;
                KlijentiGridView.DataSource = klijenti;
                KlijentiGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AktivirajKlijenta frm = new AktivirajKlijenta();
            frm.ShowDialog();
        }
    }
}
