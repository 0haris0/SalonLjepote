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

namespace eHairdresserSalon_UI.Stock
{
    public partial class SkladisteListForm : Form
    {
        private WebAPIHelper skladisteService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Skladiste");

        public SkladisteListForm()
        {
            InitializeComponent();
            SkladisteGridView.AutoGenerateColumns = true;
        }
        private void SkladisteListForm_Load(object sender, EventArgs e)
        {
            BindForm();
        }

        void BindForm()
        {
            HttpResponseMessage response = skladisteService.GetActionResponse("SearchByName", pretragaInput.Text.Trim().ToString());

            if (response.IsSuccessStatusCode)
            {
                List<Skladiste_Result> skladiste = response.Content.ReadAsAsync<List<Skladiste_Result>>().Result;
                SkladisteGridView.DataSource = skladiste;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }


        private void TraziBtn_Click(object sender, EventArgs e)
        {
            BindForm();
        }

        private void IzmijeniProizvodBtn_Click(object sender, EventArgs e)
        {
            if (SkladisteGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite proizvod!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                IzmijeniKolicinu ik = new IzmijeniKolicinu(Convert.ToInt32(SkladisteGridView.SelectedRows[0].Cells[0].Value));
                ik.ShowDialog();
                BindForm();
            }
        }
    }
}
